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
        private List<string> _instrumentIds = new List<string>();

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

            var instruments = new List<(string Figi, string Name)>
            {
                (Figi: "BBG000C6K6G9", Name: "VODAFONE GROUP PLC"),
                (Figi: "BBG000C04D57", Name: "BARCLAYS PLC"),
                (Figi: "BBG000FV67Q4", Name: "NATIONAL GRID PLC"),
                (Figi: "BBG000BF0KW3", Name: "SAINSBURY (J) PLC"),
                (Figi: "BBG000BF4KL1", Name: "TAYLOR WIMPEY PLC")
            };            

            var upsertResponse =_client.UpsertInstruments(instruments.ToDictionary(
                k => k.Figi,
                v => new InstrumentDefinition(
                    name: v.Name,
                    identifiers: new Dictionary<string, string> {["Figi"] = v.Figi}
                )
            ));
            
            Assert.That(upsertResponse.Failed.Count, Is.EqualTo(0));
            
            var ids = _client.GetInstruments("Figi", instruments.Select(i => i.Figi).ToList());

            _instrumentIds = ids.Values.Select(x => x.Value.LusidInstrumentId).ToList();
        }

        [Test]
        public void Get_Schema_For_Response()
        {
            // GIVEN an instance of the LUSID client, and a portfolio created in LUSID
            var credentials = new TokenCredentials(_apiToken);
            var client = new LUSIDAPI(new Uri(_apiUrl, UriKind.Absolute), credentials);

            const string scope = "finbourne";
            var code = $"id-{Guid.NewGuid()}";

            var request = new CreateTransactionPortfolioRequest($"Portfolio-{code}", code, baseCurrency: "GBP");

            client.CreatePortfolio(scope, request);

            // WHEN the portfolio is queried
            var portfolioResponse = client.GetPortfolioWithHttpMessagesAsync(scope, code).Result;

            // THEN the result should include a schema Url
            var schemaHeaderItem = portfolioResponse.Response.Headers.First(h => h.Key == "lusid-schema-url");

            // AND which we we can use to query for the schema of the entity
            // TODO: Too difficult to convert the returned Url into parameters for the call to GetSchema
            Regex regex = new Regex(".+/(\\w+)");
            var entityType = regex.Match(schemaHeaderItem.Value.First());

            var schema = client.GetEntitySchema(entityType.Groups[1].Value);

            Assert.That(schema, Is.Not.Null);
            Assert.That(schema.Values, Is.Not.Empty);

            var fields = typeof(Portfolio).GetProperties().Select(p => p.Name).ToImmutableHashSet();
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
            var request = new CreateTransactionPortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", baseCurrency: "GBP");

            var portfolio = _client.CreatePortfolio(scope, request);

            Assert.That(portfolio.DisplayName, Is.EqualTo(request.DisplayName));
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
                Code = propertyName,
                ValueRequired = false,
                DisplayName = "Fund Style",
                LifeTime = "Perpetual",               
                DataTypeId = new ResourceId("default", "string")
            };

            //    create property definition
            var propertyDefinitionDto = _client.CreatePropertyDefinition(propertyDefinition);
                
            //    create portfolio
            var request = new CreateTransactionPortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", baseCurrency: "GBP");
            var portfolio = _client.CreatePortfolio(scope, request);

            Assert.That(portfolio?.DisplayName, Is.EqualTo(request.DisplayName));

            //    get portfolioId
            var portfolioId = portfolio?.Id.Code;

            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            const string propertyValue = "Active";

            //    add the portfolio property
            var properties = new Dictionary<string, PropertyValue> {[propertyDefinitionDto.Key] = new PropertyValue(propertyValue) };
            var propertiesResult = _client.UpsertPortfolioProperties(scope, portfolioId, properties, portfolio?.Created);
            
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
                Code = propertyName,
                ValueRequired = false,
                DisplayName = "Trader Id",
                LifeTime = "Perpetual",
                DataTypeId = new ResourceId("default", "string")
            };

            //    create property definition
            var propertyDefinitionDto =_client.CreatePropertyDefinition(propertyDefinition);

            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);

            //    create portfolio
            var request = new CreateTransactionPortfolioRequest(
                $"Portfolio-{uuid}", 
                $"id-{uuid}", 
                baseCurrency: "GBP", 
                created: effectiveDate
            );
            var portfolio = _client.CreatePortfolio(scope, request);

            Assert.That(portfolio?.DisplayName, Is.EqualTo(request.DisplayName));

            //    get portfolioId
            var portfolioId = portfolio?.Id.Code;

            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            const string propertyValue = "A Trader";
            
            //    create the transactions       
            var transaction = new TransactionRequest()
            {
                TransactionId = Guid.NewGuid().ToString(),
                Type = "Buy",
                InstrumentUid = _instrumentIds.First(),                
                TransactionDate = effectiveDate,
                SettlementDate = effectiveDate,
                Units = 100,
                TransactionPrice = new TransactionPrice(12.3, "Price"),
                TotalConsideration = new CurrencyAndAmount(1230, "GBP"),
                Source = "Client",
                Properties = new Dictionary<string, PerpetualPropertyValue>()
                {
                    [propertyDefinitionDto.Key] = new PerpetualPropertyValue(propertyValue)
                }
            };

            //    add the transaction
            _client.UpsertTransactions(scope, portfolioId, new List<TransactionRequest> {transaction});
            
            //    get the transactions
            var transactions = _client.GetTransactions(scope, portfolioId);                
            
            Assert.That(transactions.Values.Count, Is.EqualTo(1));
            Assert.That(transactions.Values[0].InstrumentUid, Is.EqualTo(transaction.InstrumentUid));
            Assert.That(transactions.Values[0].Properties[0].Value, Is.EqualTo(propertyValue));
        }

        [Test]
        public void Apply_Bitemporal_Portfolio_Change()
        {
            
            const string scope = "finbourne";
            var uuid = Guid.NewGuid().ToString();            

            //    create the portfolio
            var request = new CreateTransactionPortfolioRequest(
                $"Portfolio-{uuid}", 
                $"id-{uuid}", 
                baseCurrency: "GBP", 
                created: new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero)
            );            

            //    create portfolio
            var portfolio = _client.CreatePortfolio(scope, request);

            Assert.That(portfolio.DisplayName, Is.EqualTo(request.DisplayName));

            var portfolioId = portfolio.Id.Code;
            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            var transactionspecs = new[]
                {
                    (Id: _instrumentIds[0], Price: 101, TradeDate: new DateTime(2018, 1, 1)),
                    (Id: _instrumentIds[1], Price: 102, TradeDate: new DateTime(2018, 1, 2)),
                    (Id: _instrumentIds[2], Price: 103, TradeDate: new DateTime(2018, 1, 3))
                }
                .OrderBy(i => i.Id);

            var newtransactions = transactionspecs.Select(id => BuildTransaction(id.Id, id.Price, id.TradeDate));

            //    add initial batch of transactions
            var initialResult = _client.UpsertTransactions(scope, portfolioId, newtransactions.ToList());

            var asAtBatch1 = initialResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    add another transaction for 2018-1-8
            var laterResult = _client.UpsertTransactions(scope, portfolioId, new List<TransactionRequest>
            {
                BuildTransaction(_instrumentIds[3], 104, new DateTime(2018, 1, 8))
            });

            var asAtBatch2 = laterResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    add back-dated transaction
            var backDatedResult = _client.UpsertTransactions(scope, portfolioId, new List<TransactionRequest>
            {
                BuildTransaction(_instrumentIds[4], 105, new DateTime(2018, 1, 5))
            });

            var asAtBatch3 = backDatedResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    list transactions
            var transactions = _client.GetTransactions(scope, portfolioId, asAt: asAtBatch1);
            
            Assert.That(transactions.Values.Count, Is.EqualTo(3), $"AsAt: {asAtBatch1:o}");
            Console.WriteLine($"transactions at {asAtBatch1}");
            PrintTransactions(transactions.Values);

            transactions = _client.GetTransactions(scope, portfolioId, asAt: asAtBatch2);
            
            Assert.That(transactions.Values.Count, Is.EqualTo(4), $"AsAt: {asAtBatch2:o}");
            Console.WriteLine($"transactions at {asAtBatch2}");
            PrintTransactions(transactions.Values);

            transactions = _client.GetTransactions(scope, portfolioId, asAt: asAtBatch3);
            
            Assert.That(transactions.Values.Count, Is.EqualTo(5), $"AsAt: {asAtBatch3:o}");
            Console.WriteLine($"transactions at {asAtBatch3}");
            PrintTransactions(transactions.Values);

            transactions = _client.GetTransactions(scope, portfolioId);
            
            Console.WriteLine($"transactions at {DateTimeOffset.Now}");
            PrintTransactions(transactions.Values);

            //////
            //
            //    local functions

            void PrintTransactions(IEnumerable<Transaction> tradeList)
            {
                foreach (var transaction in tradeList)
                {
                    Console.WriteLine($"{transaction.InstrumentUid}\t{transaction.TransactionDate}\t{transaction.Units}\t{transaction.TransactionPrice}\t{transaction.TotalConsideration}");
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
            var request = new CreateTransactionPortfolioRequest(
                $"Portfolio-{uuid}", 
                $"id-{uuid}", 
                baseCurrency: "GBP", 
                created: effectiveDate
            );            

            //    create portfolio
            var portfolio = _client.CreatePortfolio(scope, request);

            Assert.That(portfolio.DisplayName, Is.EqualTo(request.DisplayName));

            var portfolioId = portfolio.Id.Code;
            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            var transactionspecs = new[]
                {
                    (Id: _instrumentIds[0], Price: 101, TradeDate: effectiveDate),
                    (Id: _instrumentIds[1], Price: 102, TradeDate: effectiveDate),
                    (Id: _instrumentIds[2], Price: 103, TradeDate: effectiveDate)
                }
                .OrderBy(i => i.Id);

            var newtransactions = transactionspecs.Select(id => BuildTransaction(id.Id, id.Price, id.TradeDate));

            //    add transactions
            _client.UpsertTransactions(scope, portfolioId, newtransactions.ToList());

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
                new InstrumentAnalytic(_instrumentIds[0], 100), 
                new InstrumentAnalytic(_instrumentIds[1], 200),
                new InstrumentAnalytic(_instrumentIds[2], 300),
            };
            
            //    add prices
            _client.SetAnalytics(scope, effectiveDate.Year, effectiveDate.Month, effectiveDate.Day, prices);
                       
            var aggregationRequest = new AggregationRequest
            {
                RecipeId = new ResourceId(scope, "default"),
                Metrics = new List<AggregateSpec>
                {
                    new AggregateSpec("Holding/default/PV", "Proportion"),
                    new AggregateSpec("Holding/default/PV", "Sum")
                },
                GroupBy = new List<string> {"Security/default/CommonName"},
                EffectiveAt = effectiveDate
            };

            //    do the aggregation
            _client.GetAggregationByPortfolio(scope, portfolioId, aggregationRequest);
        }
        
        private TransactionRequest BuildTransaction(string id, double price, DateTimeOffset tradeDate)
        {
            return new TransactionRequest()
            {
                TransactionId = Guid.NewGuid().ToString(),
                Type = "StockIn",
                InstrumentUid = id,
                TransactionDate = tradeDate,
                SettlementDate = tradeDate,
                Units = 100,
                TransactionPrice = new TransactionPrice(price, "Price"),
                TotalConsideration = new CurrencyAndAmount(100 * price, "GBP"),
                Source = "Client"
            };
        }

        [Test, Ignore("Isin not yet supported")]
         public void Lookup_Securities()
         {            
             var isins = new List<string> 
             {
                 "IT0004966401",
                 "FR0010192997"                
             };
             
             //    look up ids
             var fbnIds = _client.GetInstruments("Isin", isins);
             
             Assert.That(fbnIds.Values.Count, Is.EqualTo(2));
         }

        private TransactionRequest BuildTradeWithQuantity(string id, double price, double quantity,  DateTimeOffset tradeDate)
        {
            return new TransactionRequest
            {
                TransactionId = Guid.NewGuid().ToString(),
                Type = "StockIn",
                InstrumentUid = id,
                TransactionDate = tradeDate,
                SettlementDate = tradeDate,
                Units = quantity,
                TransactionPrice = new TransactionPrice(price, "Price"),
                TotalConsideration = new CurrencyAndAmount(quantity * price, "GBP"),
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
            var requestPortfolio = new CreateTransactionPortfolioRequest(
                portfolioName, 
                portfolioCode, 
                baseCurrency: "GBP", 
                created: yesterday
            );
            var portfolio = _client.CreatePortfolio(scope, requestPortfolio);
           
            //Book some transactions for yesterday
            var transactionsYesterday = new[]
            {
                (Id: _instrumentIds[0], Price: 100, Quantity: 1000, TradeDate: yesterday.AddHours(8)),
                (Id: _instrumentIds[0], Price: 101, Quantity: 2300, TradeDate: yesterday.AddHours(12)),
                (Id: _instrumentIds[1], Price: 102,  Quantity: -1000, TradeDate: yesterday.AddHours(9)),
                (Id: _instrumentIds[2], Price: 103, Quantity: 1200,  TradeDate: yesterday.AddHours(16)),
                (Id: _instrumentIds[3], Price: 103, Quantity: 2000,  TradeDate: yesterday.AddHours(9))
            };
            
            var transactions = transactionsYesterday.Select(id => BuildTradeWithQuantity(id.Id, id.Price, id.Quantity, id.TradeDate));

            //    add transactions
            _client.UpsertTransactions(scope, portfolioCode, transactions.ToList());

            //Book more transactions for today
            var transactionsToday = new[]
            {
                (Id: _instrumentIds[0], Price: 101.78, Quantity: -3000, TradeDate: today.AddHours(8)), //net long 300
                (Id: _instrumentIds[0], Price: 101.78, Quantity: 1500, TradeDate: today.AddHours(12)), //net long 1800
                (Id: _instrumentIds[1], Price: 102,  Quantity: 1000, TradeDate: today.AddHours(12)),  // flat
                (Id: _instrumentIds[2], Price: 103, Quantity: 1200,  TradeDate: today.AddHours(16)),  // long 2400
                (Id: _instrumentIds[3], Price: 103, Quantity: 1000,  TradeDate: today.AddHours(9)),   // long 3000 
                (Id: _instrumentIds[3], Price: 103, Quantity: 2000,  TradeDate: today.AddHours(20))   // long 5000 but outside recon window
            };

            transactions = transactionsToday.Select(id => BuildTradeWithQuantity(id.Id, id.Price, id.Quantity, id.TradeDate));

            //    add transactions
            var finalResult = _client.UpsertTransactions(scope, portfolioCode, transactions.ToList());

            //Using the last result find out its AsAtDate (based on the servers clock at the time of the test)
            var finalAsAtTime = finalResult.Version.AsAtDate;

            //So now we have the portfolio with 2 days worth of transactions, going to reconcile from T-1 20:00 to now,
            //this should reflect breaks for each instrument equal to the transactions from yesterday till 20 today. 

            var reconcileRequest =
                new PortfoliosReconciliationRequest(
                    new PortfolioReconciliationRequest(
                        new ResourceId(scope, portfolio.Id.Code),
                        yesterday.AddHours(20),
                        finalAsAtTime),
                    new PortfolioReconciliationRequest(
                        new ResourceId(scope, portfolio.Id.Code),
                        today.AddHours(16),
                        finalAsAtTime),
                    new List<string>());

            var listOfBreaks = _client.ReconcileHoldings(reconcileRequest);

            Console.WriteLine($"Breaks at {yesterday.AddHours(20)}");
            PrintBreaks(listOfBreaks.Values);

            /*
                Expecting 
                    _instrumentIds[0]    	-1500	-8094.73
                    _instrumentIds[3]    	1000	10300
                    _instrumentIds[2]    	1200	10300
                    _instrumentIds[1]    	1000	-10200
            */

           Assert.AreEqual(listOfBreaks.Values.Count, 4);

            var map = listOfBreaks.Values.ToDictionary(abreak => abreak.InstrumentUid);
            Assert.AreEqual(map[_instrumentIds[0]].DifferenceUnits, -1500);
            Assert.AreEqual(map[_instrumentIds[3]].DifferenceUnits, 1000);
            Assert.AreEqual(map[_instrumentIds[2]].DifferenceUnits, 1200);
            Assert.AreEqual(map[_instrumentIds[1]].DifferenceUnits, 1000);
            
            void PrintBreaks(IEnumerable<ReconciliationBreak> breaks)
            {
                foreach (var abreak in breaks)
                {
                    Console.WriteLine(
                        $"{abreak.InstrumentUid}\t{abreak.DifferenceUnits}\t{abreak.DifferenceCost}");
                }

                Console.WriteLine();
            }
        }

    }
    
}
 