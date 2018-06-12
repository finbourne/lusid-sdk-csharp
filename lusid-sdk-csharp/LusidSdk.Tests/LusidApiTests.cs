using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
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
                var tokenRequest = new HttpRequestMessage(HttpMethod.Post, tokenUrl);
                tokenRequest.Content = new StringContent(tokenRequestBody);
                tokenRequest.Content.Headers.ContentType =
                    new MediaTypeHeaderValue("application/x-www-form-urlencoded");

                var response = httpClient.SendAsync(tokenRequest).Result;
                var body = response.Content.ReadAsStringAsync().Result;
                response.EnsureSuccessStatusCode();
                _apiToken = JsonConvert.DeserializeObject<Dictionary<string, string>>(body)["access_token"];
            }
        }

        private static T AssertResponseIsNotError<T>(object response) where T : class 
        {
            switch (response)
            {                
                case ErrorResponse error:
                    Assert.Fail(error.DetailedMessage);
                    break;
                case T value:
                    return value;
                default:
                    Assert.Fail($"unknown response: {response.GetType()}");
                    break;
            }
            return null;
        }

        [Test]
        public void Create_Portfolio()
        {
            var credentials = new TokenCredentials(_apiToken);
            var client = new LUSIDAPI(new Uri(_apiUrl, UriKind.Absolute), credentials);

            const string scope = "finbourne";
            var uuid = Guid.NewGuid().ToString();
            var request = new CreatePortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", "GBP");

            var result = client.CreatePortfolio(scope, request);
            var portfolio = AssertResponseIsNotError<PortfolioDto>(result);

            Assert.That(portfolio.Name, Is.EqualTo(request.Name));
        }

        [Test]
        public void Create_Portfolio_With_Properties()
        {
            var credentials = new TokenCredentials(_apiToken);
            var client = new LUSIDAPI(new Uri(_apiUrl, UriKind.Absolute), credentials);

            var uuid = Guid.NewGuid().ToString();
            const string scope = "finbourne";
            var propertyName = $"fund-style-{uuid}";
            var propertyKey = $"Portfolio/{scope}/{propertyName}";

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
            var propertyDefinitionResult = client.CreatePropertyDefinition(propertyDefinition);
            AssertResponseIsNotError<PropertyDefinitionDto>(propertyDefinitionResult);
            
            var request = new CreatePortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", "GBP");

            //    create portfolio
            var result = client.CreatePortfolio(scope, request);
            var portfolio = AssertResponseIsNotError<PortfolioDto>(result);

            Assert.That(portfolio?.Name, Is.EqualTo(request.Name));

            //    get portfolioId
            var portfolioId = portfolio?.Id.Code;

            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            const string propertyValue = "Active";
            var property = new PropertyDto(propertyKey, propertyValue);

            //    add the portfolio property
            var upsertResult = client.UpsertPortfolioProperties(scope, portfolioId,new List<PropertyDto> {property}, portfolio?.Created);
            var propertiesResult = AssertResponseIsNotError<PortfolioPropertiesDto>(upsertResult);
            
            Assert.That(propertiesResult.OriginPortfolioId.Code, Is.EqualTo(request.Code), "unable to add properties");
            Assert.That(propertiesResult.Properties[0].Value, Is.EqualTo(propertyValue));
            
        }
        
        [Test]
        public void Create_Trade_With_Property()
        {
            var credentials = new TokenCredentials(_apiToken);
            var client = new LUSIDAPI(new Uri(_apiUrl, UriKind.Absolute), credentials);
           
            var uuid = Guid.NewGuid().ToString();
            const string scope = "finbourne";
            var propertyName = $"traderId-{uuid}";
            var propertyKey = $"Trade/{scope}/{propertyName}";

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
            var propertyDefinitionResult = client.CreatePropertyDefinition(propertyDefinition);
            AssertResponseIsNotError<PropertyDefinitionDto>(propertyDefinitionResult);

            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);

            //    create portfolio
            var request = new CreatePortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", "GBP", effectiveDate);
            var result = client.CreatePortfolio(scope, request);
            var portfolio = AssertResponseIsNotError<PortfolioDto>(result);

            Assert.That(portfolio?.Name, Is.EqualTo(request.Name));

            //    get portfolioId
            var portfolioId = portfolio?.Id.Code;

            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            const string propertyValue = "A Trader";
            
            //    create the trade
            var trade = new TradeDto()
            {
                TradeId = Guid.NewGuid().ToString(),
                Type = "Buy",
                SecurityUid = "FIGI_BBG001SMDKD5",
                SettlementCurrency = "GBP",
                TradeDate = effectiveDate,
                SettlementDate = effectiveDate,
                Units = 100,
                TradePrice = 12.3,
                TotalConsideration = 1230,
                Source = "Client",
                Properties = new List<PropertyDto>
                {
                    new PropertyDto(propertyKey, propertyValue)
                }
            };

            //    add the trade
            var upsertResult = client.UpsertTrades(scope, portfolioId, new List<TradeDto> {trade});
            AssertResponseIsNotError<UpsertPortfolioTradesDto>(upsertResult);                

            //    get the trades
            var getTradesResult = client.GetTrades(scope, portfolioId);                
            var trades = AssertResponseIsNotError<VersionedResourceListTradeDto>(getTradesResult);
            
            Assert.That(trades.Values.Count, Is.EqualTo(1));
            Assert.That(trades.Values[0].TradeId, Is.EqualTo(trade.TradeId));
            Assert.That(trades.Values[0].Properties[0].Value, Is.EqualTo(propertyValue));
        }

        [Test]
        public void Apply_Bitemporal_Portfolio_Change()
        {
            var credentials = new TokenCredentials(_apiToken);
            var client = new LUSIDAPI(new Uri(_apiUrl, UriKind.Absolute), credentials);
            
            const string scope = "finbourne";
            var uuid = Guid.NewGuid().ToString();            

            //    create the portfolio
            var request = new CreatePortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", "GBP", new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero));            

            //    create portfolio
            var portfolioResult = client.CreatePortfolio(scope, request);
            var portfolio = AssertResponseIsNotError<PortfolioDto>(portfolioResult);

            Assert.That(portfolio.Name, Is.EqualTo(request.Name));

            var portfolioId = portfolio.Id.Code;
            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            var tradeSpecs = new[]
                {
                    (Id: "FIGI_BBG001S7Z574", Price: 101, TradeDate: new DateTime(2018, 1, 1)),
                    (Id: "FIGI_BBG001SRKHW2", Price: 102, TradeDate: new DateTime(2018, 1, 2)),
                    (Id: "FIGI_BBG000005547", Price: 103, TradeDate: new DateTime(2018, 1, 3))
                }
                .OrderBy(i => i.Id);

            var newTrades = tradeSpecs.Select(id => BuildTrade(id.Id, id.Price, id.TradeDate));

            //    add initial batch of trades
            var addTradesResult = client.UpsertTrades(scope, portfolioId, newTrades.ToList());
            var initialResult = AssertResponseIsNotError<UpsertPortfolioTradesDto>(addTradesResult);            

            var asAtBatch1 = initialResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    add another trade for 2018-1-8
            var laterTradeResult = client.UpsertTrades(scope, portfolioId, new List<TradeDto>
            {
                BuildTrade("FIGI_BBG001S61MW8", 104, new DateTime(2018, 1, 8))
            });
            var laterResult = AssertResponseIsNotError<UpsertPortfolioTradesDto>(laterTradeResult);

            var asAtBatch2 = laterResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    add back-dated trade
            var backDatedTradeResult = client.UpsertTrades(scope, portfolioId, new List<TradeDto>
            {
                BuildTrade("FIGI_BBG001S6M3Z4", 105, new DateTime(2018, 1, 5))
            });
            var backDatedResult = AssertResponseIsNotError<UpsertPortfolioTradesDto>(backDatedTradeResult);

            var asAtBatch3 = backDatedResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    list trades
            var allTrades = client.GetTrades(scope, portfolioId, asAt: asAtBatch1);
            var trades = AssertResponseIsNotError<VersionedResourceListTradeDto>(allTrades);
            
            Assert.That(trades.Values.Count, Is.EqualTo(3), $"AsAt: {asAtBatch1:o}");
            Console.WriteLine($"trades at {asAtBatch1}");
            PrintTrades(trades.Values);

            allTrades = client.GetTrades(scope, portfolioId, asAt: asAtBatch2);
            trades = AssertResponseIsNotError<VersionedResourceListTradeDto>(allTrades);
            
            Assert.That(trades.Values.Count, Is.EqualTo(4), $"AsAt: {asAtBatch2:o}");
            Console.WriteLine($"trades at {asAtBatch2}");
            PrintTrades(trades.Values);

            allTrades = client.GetTrades(scope, portfolioId, asAt: asAtBatch3);
            trades = AssertResponseIsNotError<VersionedResourceListTradeDto>(allTrades);
            
            Assert.That(trades.Values.Count, Is.EqualTo(5), $"AsAt: {asAtBatch3:o}");
            Console.WriteLine($"trades at {asAtBatch3}");
            PrintTrades(trades.Values);

            allTrades = client.GetTrades(scope, portfolioId);
            trades = AssertResponseIsNotError<VersionedResourceListTradeDto>(allTrades);
            
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
                        $"{trade.SecurityUid}\t{trade.TradeDate?.Date.ToShortDateString()}\t{trade.Units}\t{trade.TradePrice}\t{trade.TotalConsideration}");
                }

                Console.WriteLine();
            }
        }

        [Test]
        public void Portfolio_Aggregation()
        {
            var credentials = new TokenCredentials(_apiToken);
            var client = new LUSIDAPI(new Uri(_apiUrl, UriKind.Absolute), credentials);
            
            const string scope = "finbourne";
            var uuid = Guid.NewGuid().ToString();            

            //    create the portfolio
            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            var request = new CreatePortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", "GBP", effectiveDate);            

            //    create portfolio
            var portfolioResult = client.CreatePortfolio(scope, request);
            var portfolio = AssertResponseIsNotError<PortfolioDto>(portfolioResult);

            Assert.That(portfolio.Name, Is.EqualTo(request.Name));

            var portfolioId = portfolio.Id.Code;
            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            var tradeSpecs = new[]
                {
                    (Id: "FIGI_BBG001S7Z574", Price: 101, TradeDate: effectiveDate),
                    (Id: "FIGI_BBG001SRKHW2", Price: 102, TradeDate: effectiveDate),
                    (Id: "FIGI_BBG000005547", Price: 103, TradeDate: effectiveDate)
                }
                .OrderBy(i => i.Id);

            var newTrades = tradeSpecs.Select(id => BuildTrade(id.Id, id.Price, id.TradeDate));

            //    add trades
            var addedTradesResult = client.UpsertTrades(scope, portfolioId, newTrades.ToList());
            AssertResponseIsNotError<UpsertPortfolioTradesDto>(addedTradesResult);
                        
            var checkExistsResult = client.GetAnalyticStore(scope, effectiveDate.Year, effectiveDate.Month, effectiveDate.Day) as ErrorResponse;

            if (checkExistsResult != null && checkExistsResult.Code == "AnalyticStoreNotFound")
            {
                //    create the analytic store
                var analyticStoreRequest = new CreateAnalyticStoreRequest(scope, effectiveDate);
                var analyticStoreResult = client.CreateAnalyticStore(analyticStoreRequest);
                AssertResponseIsNotError<AnalyticStoreDto>(analyticStoreResult);
            }
                        
            var prices = new[]
            {
                new SecurityAnalyticDataDto("FIGI_BBG001S7Z574", 100),
                new SecurityAnalyticDataDto("FIGI_BBG001SRKHW2", 200),
                new SecurityAnalyticDataDto("FIGI_BBG000005547", 300),
            };
            
            //    add prices
            var analyticsResult = client.InsertAnalytics(scope, effectiveDate.Year, effectiveDate.Month, effectiveDate.Day, prices);
            AssertResponseIsNotError<AnalyticStoreDto>(analyticsResult);
                       
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
            var aggregationResult = client.GetNestedAggregationByPortfolio(scope, portfolioId, aggregationRequest);
            AssertResponseIsNotError<NestedAggregationResponse>(aggregationResult);
        }
        
        private TradeDto BuildTrade(string id, double price, DateTimeOffset tradeDate)
        {
            return new TradeDto
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
            var credentials = new TokenCredentials(_apiToken);
            var client = new LUSIDAPI(new Uri(_apiUrl, UriKind.Absolute), credentials);
            
            var isins = new List<string> 
            {
                "IT0004966401",
                "FR0010192997"                
            };
            
            //    look up ids
            var lookupResult = client.LookupSecuritiesFromCodes("Isin", isins);
            var fbnIds = AssertResponseIsNotError<TryLookupSecuritiesFromCodesDto>(lookupResult);
            
            Assert.That(fbnIds.Values.Count, Is.GreaterThan(0));
        }
    }
    
}