using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.RegularExpressions;
using System.Threading;
using System.Web;
using Finbourne;
using Finbourne.Models;
using FinbourneClient;
using Microsoft.Extensions.Configuration;
using Microsoft.Rest;
using Newtonsoft.Json;
using NUnit.Framework;

namespace LusidSdk.Tests
{
    [TestFixture]
    public class LusidApiTests
    {
        private readonly ApiConfiguration _apiConfiguration = new ApiConfiguration();
        private string _apiToken;
        private string _apiUrl;
        private LUSIDAPI _client;
        private List<string> _securityIds = new List<string>();

        [OneTimeSetUp]
        public void SetUp()
        {
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("secrets.json")
                .Build();

            config.GetSection("api").Bind(_apiConfiguration);

            Assert.That(_apiConfiguration, Is.Not.Null);
            Assert.That(_apiConfiguration.ApiUrl, Is.Not.Null);

            var tokenUrl = Environment.GetEnvironmentVariable("FBN_TOKEN_URL") ?? _apiConfiguration.TokenUrl;
            var username = Environment.GetEnvironmentVariable("FBN_USERNAME") ?? _apiConfiguration.Username;
            var password = Environment.GetEnvironmentVariable("FBN_PASSWORD") ?? _apiConfiguration.Password;
            var clientId = Environment.GetEnvironmentVariable("FBN_CLIENT_ID") ?? _apiConfiguration.ClientId;
            var clientSecret = Environment.GetEnvironmentVariable("FBN_CLIENT_SECRET") ?? _apiConfiguration.ClientSecret;
            _apiUrl = Environment.GetEnvironmentVariable("FBN_LUSID_API_URL") ?? _apiConfiguration.ApiUrl;

            var tokenRequestBody = $"grant_type=password&username={HttpUtility.UrlEncode(username)}&password={HttpUtility.UrlEncode(password)}&scope=openid client groups&client_id={clientId}&client_secret={clientSecret}";

            using (var httpClient = new HttpClient())
            {
                //Only accept JSON
                httpClient.DefaultRequestHeaders.Accept.Clear();
                httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // gets the response
                var tokenRequest =
                    new HttpRequestMessage(HttpMethod.Post, tokenUrl) {Content = new StringContent(tokenRequestBody)};
                tokenRequest.Content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/x-www-form-urlencoded");

                var response = httpClient.SendAsync(tokenRequest).Result;
                var body = response.Content.ReadAsStringAsync().Result;
                response.EnsureSuccessStatusCode();
                _apiToken = JsonConvert.DeserializeObject<Dictionary<string, string>>(body)["access_token"];
            }
            
            var credentials = new TokenCredentials(_apiToken);
            _client = new LUSIDAPI(new Uri(_apiUrl, UriKind.Absolute), credentials);

            var figis = new List<string> {"BBG000C6K6G9","BBG000C04D57","BBG000FV67Q4","BBG000BF0KW3","BBG000BF4KL1"};
            var ids = _client.LookupSecuritiesFromCodesBulk("Figi", figis);

            this._securityIds = ids.Values.SelectMany(r => r.Values.Select(s => s.Uid)).ToList();

        }

        [Test]
        public void Get_Schema_For_Response()
        {
            // GIVEN an instance of the LUSID client, and a portfolio created in LUSID
            var credentials = new TokenCredentials(_apiToken);
            var client = new LUSIDAPI(new Uri(_apiUrl, UriKind.Absolute), credentials);

            const string scope = "finbourne";
            var code = $"id-{Guid.NewGuid()}";

            var request = new CreatePortfolioRequest($"Portfolio-{code}", code, "GBP");

            client.CreatePortfolio(scope, request);

            // WHEN the portfolio is queried
            var portfolioResponse = client.GetPortfolioWithHttpMessagesAsync(scope, code).Result;

            // THEN the resulty should include a schema Url
            var schemaHeaderItem = portfolioResponse.Response.Headers.First(h => h.Key == "lusid-schema-url");

            // AND which we we can use to query for the schema of the entity
            // TODO: Too difficult to convert the returned Url into parameters for the call to GetSchema
            Regex regex = new Regex(".+/(\\w+)");
            var entityType = regex.Match(schemaHeaderItem.Value.First());

            var schema = client.GetEntitySchema(entityType.Groups[1].Value);

            Assert.That(schema, Is.Not.Null);
            Assert.That(schema.Values, Is.Not.Empty);

            var fields = typeof(PortfolioDto).GetProperties().Select(p => p.Name).ToImmutableHashSet();
            foreach (var fieldSchema in schema.Values)
            {
                Assert.That(fields, Does.Contain(fieldSchema.Value.DisplayName));
            }
        }

        [Test]
        public void Create_Portfolio()
        {
            
            const string scope = "finbourne";
            var uuid = Guid.NewGuid().ToString();
            var request = new CreatePortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", "GBP");

            var portfolio = _client.CreatePortfolio(scope, request);

            Assert.That(portfolio.Name, Is.EqualTo(request.Name));
        }

        [Test]
        public void Create_Portfolio_With_Properties()
        {
            var uuid = Guid.NewGuid().ToString();
            const string scope = "finbourne";
            var propertyName = $"fund-style-{uuid}";

            var propertyDefinition = new CreatePropertyDefinitionRequest
            {
                Domain = "Portfolio",
                Scope = scope,
                Name = propertyName,
                ValueRequired = false,
                DisplayName = "Fund Style",
                LifeTime = "Perpetual",
                Sort = "sort",
                DataFormatId = new ResourceId("default", "string")
            };

            //    create property definition
            _client.CreatePropertyDefinition(propertyDefinition);
            
            //    create portfolio
            var request = new CreatePortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", "GBP");
            var portfolio = _client.CreatePortfolio(scope, request);

            Assert.That(portfolio?.Name, Is.EqualTo(request.Name));

            //    get portfolioId
            var portfolioId = portfolio?.Id.Code;

            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            const string propertyValue = "Active";
            var property = new CreatePropertyRequest(propertyValue, scope, propertyName);

            //    add the portfolio property
            var propertiesResult = _client.UpsertPortfolioProperties(scope, portfolioId,new List<CreatePropertyRequest> {property}, portfolio?.Created);
            
            Assert.That(propertiesResult.OriginPortfolioId.Code, Is.EqualTo(request.Code), "unable to add properties");
            Assert.That(propertiesResult.Properties[0].Value, Is.EqualTo(propertyValue));
            
        }
        
        [Test]
        public void Create_Trade_With_Property()
        {
           
            var uuid = Guid.NewGuid().ToString();
            const string scope = "finbourne";
            var propertyName = $"traderId-{uuid}";

            var propertyDefinition = new CreatePropertyDefinitionRequest
            {
                Domain = "Trade",
                Scope = scope,
                Name = propertyName,
                ValueRequired = false,
                DisplayName = "Trader Id",
                LifeTime = "Perpetual",
                Sort = "sort",
                DataFormatId = new ResourceId("default", "string")
            };

            //    create property definition
            _client.CreatePropertyDefinition(propertyDefinition);

            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);

            //    create portfolio
            var request = new CreatePortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", "GBP", effectiveDate);
            var portfolio = _client.CreatePortfolio(scope, request);

            Assert.That(portfolio?.Name, Is.EqualTo(request.Name));

            //    get portfolioId
            var portfolioId = portfolio?.Id.Code;

            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            const string propertyValue = "A Trader";
            
            //    create the trade
            var trade = new UpsertPortfolioTradeRequest()
            {
                TradeId = Guid.NewGuid().ToString(),
                Type = "Buy",
                SecurityUid = _securityIds[0],
                SettlementCurrency = "GBP",
                TradeDate = effectiveDate,
                SettlementDate = effectiveDate,
                Units = 100,
                TradePrice = 12.3,
                TotalConsideration = 1230,
                Source = "Client",
                Properties = new List<CreatePerpetualPropertyRequest>
                {
                    new CreatePerpetualPropertyRequest(propertyValue, scope, propertyName)
                }
            };

            //    add the trade
            _client.UpsertTrades(scope, portfolioId, new List<UpsertPortfolioTradeRequest> {trade});

            //    get the trades
            var trades = _client.GetTrades(scope, portfolioId);                
            
            Assert.That(trades.Values.Count, Is.EqualTo(1));
            Assert.That(trades.Values[0].TradeId, Is.EqualTo(trade.TradeId));
            Assert.That(trades.Values[0].Properties[0].Value, Is.EqualTo(propertyValue));
        }

        [Test]
        public void Apply_Bitemporal_Portfolio_Change()
        {
            
            const string scope = "finbourne";
            var uuid = Guid.NewGuid().ToString();            

            //    create the portfolio
            var request = new CreatePortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", "GBP", new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero));            

            //    create portfolio
            var portfolio = _client.CreatePortfolio(scope, request);

            Assert.That(portfolio.Name, Is.EqualTo(request.Name));

            var portfolioId = portfolio.Id.Code;
            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            var tradeSpecs = new[]
                {
                    (Id: _securityIds[0], Price: 101, TradeDate: new DateTime(2018, 1, 1)),
                    (Id: _securityIds[1], Price: 102, TradeDate: new DateTime(2018, 1, 2)),
                    (Id: _securityIds[2], Price: 103, TradeDate: new DateTime(2018, 1, 3))
                }
                .OrderBy(i => i.Id);

            var newTrades = tradeSpecs.Select(id => BuildTrade(id.Id, id.Price, id.TradeDate));

            //    add initial batch of trades
            var initialResult = _client.UpsertTrades(scope, portfolioId, newTrades.ToList());

            var asAtBatch1 = initialResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    add another trade for 2018-1-8
            var laterResult = _client.UpsertTrades(scope, portfolioId, new List<UpsertPortfolioTradeRequest>
            {
                BuildTrade(_securityIds[3], 104, new DateTime(2018, 1, 8))
            });

            var asAtBatch2 = laterResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    add back-dated trade
            var backDatedResult = _client.UpsertTrades(scope, portfolioId, new List<UpsertPortfolioTradeRequest>
            {
                BuildTrade(_securityIds[4], 105, new DateTime(2018, 1, 5))
            });

            var asAtBatch3 = backDatedResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    list trades
            var trades = _client.GetTrades(scope, portfolioId, asAt: asAtBatch1);
            
            Assert.That(trades.Values.Count, Is.EqualTo(3), $"AsAt: {asAtBatch1:o}");
            Console.WriteLine($"trades at {asAtBatch1}");
            PrintTrades(trades.Values);

            trades = _client.GetTrades(scope, portfolioId, asAt: asAtBatch2);
            
            Assert.That(trades.Values.Count, Is.EqualTo(4), $"AsAt: {asAtBatch2:o}");
            Console.WriteLine($"trades at {asAtBatch2}");
            PrintTrades(trades.Values);

            trades = _client.GetTrades(scope, portfolioId, asAt: asAtBatch3);
            
            Assert.That(trades.Values.Count, Is.EqualTo(5), $"AsAt: {asAtBatch3:o}");
            Console.WriteLine($"trades at {asAtBatch3}");
            PrintTrades(trades.Values);

            trades = _client.GetTrades(scope, portfolioId);
            
            Console.WriteLine($"trades at {DateTimeOffset.Now}");
            PrintTrades(trades.Values);

            //////
            //
            //    local functions

            void PrintTrades(IEnumerable<TradeDto> tradeList)
            {
                foreach (var trade in tradeList)
                {
                    Console.WriteLine(
                        $"{trade.SecurityUid}\t{trade.TradeDate.Date.ToShortDateString()}\t{trade.Units}\t{trade.TradePrice}\t{trade.TotalConsideration}");
                }

                Console.WriteLine();
            }
        }

        [Test]
        public void Portfolio_Aggregation()
        {
            const string scope = "finbourne";
            var uuid = Guid.NewGuid().ToString();            

            //    create the portfolio
            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            var request = new CreatePortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", "GBP", effectiveDate);            

            //    create portfolio
            var portfolio = _client.CreatePortfolio(scope, request);

            Assert.That(portfolio.Name, Is.EqualTo(request.Name));

            var portfolioId = portfolio.Id.Code;
            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            var tradeSpecs = new[]
                {
                    (Id: _securityIds[0], Price: 101, TradeDate: effectiveDate),
                    (Id: _securityIds[1], Price: 102, TradeDate: effectiveDate),
                    (Id: _securityIds[2], Price: 103, TradeDate: effectiveDate)
                }
                .OrderBy(i => i.Id);

            var newTrades = tradeSpecs.Select(id => BuildTrade(id.Id, id.Price, id.TradeDate));

            //    add trades
            _client.UpsertTrades(scope, portfolioId, newTrades.ToList());

            bool mustCreateAnalyticsStore = false;
            try
            {
                _client.GetAnalyticStore(scope, effectiveDate.Year, effectiveDate.Month, effectiveDate.Day);
            }
            catch (ErrorResponseException ex)
            {
                mustCreateAnalyticsStore = ex.Body.Code == "AnalyticStoreNotFound";
            }

            if(mustCreateAnalyticsStore)
            {
                //    create the analytic store
                var analyticStoreRequest = new CreateAnalyticStoreRequest(scope, effectiveDate);
                _client.CreateAnalyticStore(analyticStoreRequest);
            }
                        
            var prices = new[]
            {
                new SecurityAnalyticDataDto(_securityIds[0], 100),
                new SecurityAnalyticDataDto(_securityIds[1], 200),
                new SecurityAnalyticDataDto(_securityIds[2], 300),
            };
            
            //    add prices
            _client.InsertAnalytics(scope, effectiveDate.Year, effectiveDate.Month, effectiveDate.Day, prices);
                       
            var aggregationRequest = new AggregationRequest
            {
                RecipeKey = scope,
                RecipeScope = scope,
                Metrics = new List<AggregateSpec>
                {
                    new AggregateSpec("Holding/default/PV", "Proportion"),
                    new AggregateSpec("Holding/default/PV", "Sum")
                },
                GroupBy = new List<string> {"Security/default/CommonName"},
                EffectiveAt = effectiveDate
            };

            //    do the aggregation
            _client.GetNestedAggregationByPortfolio(scope, portfolioId, aggregationRequest);
        }
        
        private UpsertPortfolioTradeRequest BuildTrade(string id, double price, DateTimeOffset tradeDate)
        {
            return new UpsertPortfolioTradeRequest
            {
                TradeId = Guid.NewGuid().ToString(),
                Type = "StockIn",
                SecurityUid = id,
                SettlementCurrency = "GBP",
                TradeDate = tradeDate,
                SettlementDate = tradeDate,
                Units = 100,
                TradePrice = price,
                TotalConsideration = 100 * price,
                Source = "Client"
            };
        }

        [Test]
        public void Lookup_Securities()
        {            
            var isins = new List<string> 
            {
                "IT0004966401",
                "FR0010192997"                
            };
            
            //    look up ids
            var fbnIds = _client.LookupSecuritiesFromCodes("Isin", isins);
            
            Assert.That(fbnIds.Values.Count, Is.EqualTo(2));
        }

        private UpsertPortfolioTradeRequest BuildTradeWithQuantity(string id, double price, double quantity,  DateTimeOffset tradeDate)
        {
            return new UpsertPortfolioTradeRequest
            {
                TradeId = Guid.NewGuid().ToString(),
                Type = "StockIn",
                SecurityUid = id,
                SettlementCurrency = "GBP",
                TradeDate = tradeDate,
                SettlementDate = tradeDate,
                Units = quantity,
                TradePrice = price,
                TotalConsideration = quantity * price,
                Source = "Client"
            };
        }

        [Test]
        public void Reconcile_Portfolio()
        {
            const string scope = "finbourne";
            var uuid = Guid.NewGuid().ToString();

            //Create a portfolio for testing against
            var portfolioName = $"Portfolio-{uuid}";
            var portfolioCode = $"Id-{uuid}";
            var today = new DateTimeOffset(DateTimeOffset.UtcNow.Date).ToUniversalTime();
            var yesterday = today.AddDays(-1);

            //Request creation for yesterday
            var requestPortfolio = new CreatePortfolioRequest(portfolioName, portfolioCode, "GBP", yesterday);
            var portfolio = _client.CreatePortfolio(scope, requestPortfolio);
           
            //Book some trades for yesterday
            var tradesYesterday = new[]
            {
                (Id: _securityIds[0], Price: 100, Quantity: 1000, TradeDate: yesterday.AddHours(8)),
                (Id: _securityIds[0], Price: 101, Quantity: 2300, TradeDate: yesterday.AddHours(12)),
                (Id: _securityIds[1], Price: 102,  Quantity: -1000, TradeDate: yesterday.AddHours(9)),
                (Id: _securityIds[2], Price: 103, Quantity: 1200,  TradeDate: yesterday.AddHours(16)),
                (Id: _securityIds[3], Price: 103, Quantity: 2000,  TradeDate: yesterday.AddHours(9))
            };
            
            var trades = tradesYesterday.Select(id => BuildTradeWithQuantity(id.Id, id.Price, id.Quantity, id.TradeDate));

            //    add trades
            _client.UpsertTrades(scope, portfolioCode, trades.ToList());

            //Book more trades for today
            var tradesToday = new[]
            {
                (Id: _securityIds[0], Price: 101.78, Quantity: -3000, TradeDate: today.AddHours(8)), //net long 300
                (Id: _securityIds[0], Price: 101.78, Quantity: 1500, TradeDate: today.AddHours(12)), //net long 1800
                (Id: _securityIds[1], Price: 102,  Quantity: 1000, TradeDate: today.AddHours(12)),  // flat
                (Id: _securityIds[2], Price: 103, Quantity: 1200,  TradeDate: today.AddHours(16)),  // long 2400
                (Id: _securityIds[3], Price: 103, Quantity: 1000,  TradeDate: today.AddHours(9)),   // long 3000 
                (Id: _securityIds[3], Price: 103, Quantity: 2000,  TradeDate: today.AddHours(20))   // long 5000 but outside recon window
            };

            trades = tradesToday.Select(id => BuildTradeWithQuantity(id.Id, id.Price, id.Quantity, id.TradeDate));

            //    add trades
            var finalResult = _client.UpsertTrades(scope, portfolioCode, trades.ToList());

            //Using the last result find out its AsAtDate (based on the servers clock at the time of the test)
            var finalAsAtTime = finalResult.Version.AsAtDate;

            //So now we have the portfolio with 2 days worth of trades, going to reconcile from T-1 20:00 to now,
            //this should reflect breaks for each security equal to the trades from yesterday till 20 today. 

            var reconcileRequest = new ReconciliationRequest(scope, portfolio.Id.Code, yesterday.AddHours(20),
                finalAsAtTime,
                scope, portfolio.Id.Code, today.AddHours(16), finalAsAtTime);

            var listOfBreaks = _client.PerformReconciliation(reconcileRequest);

            Console.WriteLine($"Breaks at {yesterday.AddHours(20)}");
            PrintBreaks(listOfBreaks.Values);

            /*
                Expecting 
                    _securityIds[0]    	-1500	-8094.73
                    _securityIds[3]    	1000	10300
                    _securityIds[2]    	1200	10300
                    _securityIds[1]    	1000	-10200
            */

            Assert.AreEqual(listOfBreaks.Values.Count, 4);

            var map = listOfBreaks.Values.ToDictionary(abreak => abreak.SecurityUid);
            Assert.AreEqual(map[_securityIds[0]].UnitsDifference, -1500);
            Assert.AreEqual(map[_securityIds[3]].UnitsDifference, 1000);
            Assert.AreEqual(map[_securityIds[2]].UnitsDifference, 1200);
            Assert.AreEqual(map[_securityIds[1]].UnitsDifference, 1000);
            
            void PrintBreaks(IEnumerable<ReconciliationBreakDto> breaks)
            {
                foreach (var abreak in breaks)
                {
                    Console.WriteLine(
                        $"{abreak.SecurityUid}\t{abreak.UnitsDifference}\t{abreak.CostDifference}");
                }

                Console.WriteLine();
            }
        }

    }
    
}
 