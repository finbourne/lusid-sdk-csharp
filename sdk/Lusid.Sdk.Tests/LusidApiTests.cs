using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Utilities;
using NUnit.Framework;

namespace Lusid.Sdk.Tests
{
    [TestFixture]
    public class LusidApiTests
    {
        private readonly string LUSID_INSTRUMENT_IDENTIFIER = "Instrument/default/LusidInstrumentId";
        
        private readonly ApiConfiguration _apiConfiguration = new ApiConfiguration();
        private List<string> _instrumentIds = new List<string>();

        private ILusidApiFactory _apiFactory;
       
        [OneTimeSetUp]
        public void SetUp()
        {
            _apiFactory = LusidApiFactoryBuilder.Build("secrets.json");

            var instruments = new List<(string Figi, string Name)>
            {
                (Figi: "BBG000C6K6G9", Name: "VODAFONE GROUP PLC"),
                (Figi: "BBG000C04D57", Name: "BARCLAYS PLC"),
                (Figi: "BBG000FV67Q4", Name: "NATIONAL GRID PLC"),
                (Figi: "BBG000BF0KW3", Name: "SAINSBURY (J) PLC"),
                (Figi: "BBG000BF4KL1", Name: "TAYLOR WIMPEY PLC")
            };            

            var upsertResponse = _apiFactory.Api<IInstrumentsApi>().UpsertInstruments(instruments.ToDictionary(
                k => k.Figi,
                v => new InstrumentDefinition(
                    name: v.Name,
                    identifiers: new Dictionary<string, InstrumentIdValue> {["Figi"] = new InstrumentIdValue(v.Figi) }
                )
            ));
            
            Assert.That(upsertResponse.Failed.Count, Is.EqualTo(0));
            
            var ids = _apiFactory.Api<IInstrumentsApi>().GetInstruments("Figi", instruments.Select(i => i.Figi).ToList());

             _instrumentIds = ids.Values.Select(x => x.Value.LusidInstrumentId).ToList();
        }
        
        
        [Test]
        public void Reference_Portfolio()
        {
            const string scope = "finbourne";
            var uuid = Guid.NewGuid().ToString();
            var request = new CreateReferencePortfolioRequest($"Portfolio-{uuid}", $"id-{uuid}", $"id-{uuid}");

            var portfolio = _apiFactory.Api<IReferencePortfolioApi>().CreateReferencePortfolio(scope, request);

            Assert.That(portfolio.Id.Code, Is.EqualTo(request.Code));

            var constituents = _apiFactory.Api<IReferencePortfolioApi>().GetReferencePortfolioConstituents(scope, portfolio.Id.Code);
            
            Assert.That(constituents, Is.Not.Null);
        }

        [Test]
        public void Create_Portfolio()
        {            
            const string scope = "finbourne";
            var uuid = Guid.NewGuid().ToString();
            var request = new CreateTransactionPortfolioRequest($"Portfolio-{uuid}", code: $"id-{uuid}", baseCurrency: "GBP");

            var portfolio = _apiFactory.Api<ITransactionPortfoliosApi>().CreatePortfolio(scope, request);

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
                Domain = CreatePropertyDefinitionRequest.DomainEnum.Portfolio,
                Scope = scope,
                Code = propertyName,
                ValueRequired = false,
                DisplayName = "Fund Style",
                LifeTime = CreatePropertyDefinitionRequest.LifeTimeEnum.Perpetual,               
                DataTypeId = new ResourceId("default", "string")
            };

            //    create property definition
            var propertyDefinitionDto = _apiFactory.Api<IPropertyDefinitionsApi>().CreatePropertyDefinition(propertyDefinition);
                
            //    create portfolio
            var request = new CreateTransactionPortfolioRequest($"Portfolio-{uuid}", code: $"id-{uuid}", baseCurrency: "GBP");
            var portfolio = _apiFactory.Api<ITransactionPortfoliosApi>().CreatePortfolio(scope, request);

            Assert.That(portfolio?.DisplayName, Is.EqualTo(request.DisplayName));

            //    get portfolioId
            var portfolioId = portfolio?.Id.Code;

            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            const string propertyValue = "Active";

            //    add the portfolio property
            var properties = new Dictionary<string, PropertyValue> {[propertyDefinitionDto.Key] = new PropertyValue(propertyValue) };
            var propertiesResult = _apiFactory.Api<IPortfoliosApi>().UpsertPortfolioProperties(scope, portfolioId, properties);
            
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
                Domain = CreatePropertyDefinitionRequest.DomainEnum.Trade,
                Scope = scope,
                Code = propertyName,
                ValueRequired = false,
                DisplayName = "Trader Id",
                LifeTime = CreatePropertyDefinitionRequest.LifeTimeEnum.Perpetual,
                DataTypeId = new ResourceId("default", "string")
            };

            //    create property definition
            var propertyDefinitionDto = _apiFactory.Api<IPropertyDefinitionsApi>().CreatePropertyDefinition(propertyDefinition);

            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);

            //    create portfolio
            var request = new CreateTransactionPortfolioRequest(
                $"Portfolio-{uuid}", 
                code: $"id-{uuid}", 
                baseCurrency: "GBP", 
                created: effectiveDate
            );
            var portfolio = _apiFactory.Api<ITransactionPortfoliosApi>().CreatePortfolio(scope, request);

            Assert.That(portfolio?.DisplayName, Is.EqualTo(request.DisplayName));

            //    get portfolioId
            var portfolioId = portfolio?.Id.Code;

            Assert.That(portfolioId, Is.Not.Null, "portfolioId null");

            const string propertyValue = "A Trader";
            
            //    create the transactions       
            var transaction = new TransactionRequest(
                transactionId: Guid.NewGuid().ToString(),
                type: "Buy",
                instrumentIdentifiers: new Dictionary<string, string> { ["Instrument/default/LusidInstrumentId"] = _instrumentIds.First() },                
                transactionDate: effectiveDate.ToLUSIDDate(),
                settlementDate: effectiveDate.ToLUSIDDate(),
                units: 100,
                transactionPrice: new TransactionPrice(12.3, TransactionPrice.TypeEnum.Price),
                totalConsideration: new CurrencyAndAmount(1230, "GBP"),
                source: "Custodian",
                properties: new Dictionary<string, PerpetualPropertyValue>
                {
                    [propertyDefinitionDto.Key] = new PerpetualPropertyValue(propertyValue)
                }
            );

            //    add the transaction
            _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(scope, portfolioId, new List<TransactionRequest> {transaction});
            
            //    get the transactions
            var transactions = _apiFactory.Api<ITransactionPortfoliosApi>().GetTransactions(scope, portfolioId);                
            
            Assert.That(transactions.Values.Count, Is.EqualTo(1));
            Assert.That(transactions.Values[0].InstrumentUid, Is.EqualTo(transaction.InstrumentIdentifiers.First().Value));
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
                code: $"id-{uuid}", 
                baseCurrency: "GBP", 
                created: new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero)
            );            

            //    create portfolio
            var portfolio = _apiFactory.Api<ITransactionPortfoliosApi>().CreatePortfolio(scope, request);

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
            var initialResult = _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(scope, portfolioId, newtransactions.ToList());

            var asAtBatch1 = initialResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    add another transaction for 2018-1-8
            var laterResult = _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(scope, portfolioId, new List<TransactionRequest>
            {
                BuildTransaction(_instrumentIds[3], 104, new DateTime(2018, 1, 8))
            });

            var asAtBatch2 = laterResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    add back-dated transaction
            var backDatedResult = _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(scope, portfolioId, new List<TransactionRequest>
            {
                BuildTransaction(_instrumentIds[4], 105, new DateTime(2018, 1, 5))
            });

            var asAtBatch3 = backDatedResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    list transactions
            var transactions = _apiFactory.Api<ITransactionPortfoliosApi>().GetTransactions(scope, portfolioId, asAt: asAtBatch1);
            
            Assert.That(transactions.Values.Count, Is.EqualTo(3), $"AsAt: {asAtBatch1:o}");
            Console.WriteLine($"transactions at {asAtBatch1}");
            PrintTransactions(transactions.Values);

            transactions = _apiFactory.Api<ITransactionPortfoliosApi>().GetTransactions(scope, portfolioId, asAt: asAtBatch2);
            
            Assert.That(transactions.Values.Count, Is.EqualTo(4), $"AsAt: {asAtBatch2:o}");
            Console.WriteLine($"transactions at {asAtBatch2}");
            PrintTransactions(transactions.Values);

            transactions = _apiFactory.Api<ITransactionPortfoliosApi>().GetTransactions(scope, portfolioId, asAt: asAtBatch3);
            
            Assert.That(transactions.Values.Count, Is.EqualTo(5), $"AsAt: {asAtBatch3:o}");
            Console.WriteLine($"transactions at {asAtBatch3}");
            PrintTransactions(transactions.Values);

            transactions = _apiFactory.Api<ITransactionPortfoliosApi>().GetTransactions(scope, portfolioId);
            
            Console.WriteLine($"transactions at {DateTimeOffset.Now}");
            PrintTransactions(transactions.Values);

            //////
            //
            //    local functions

            void PrintTransactions(IEnumerable<Transaction> tradeList)
            {
                foreach (var transaction in tradeList)
                {
                    Console.WriteLine($"{transaction.InstrumentUid}\t{transaction.TransactionDate}\t{transaction.Units}\t{transaction.TransactionPrice.Price}\t{transaction.TotalConsideration.Amount}");
                }

                Console.WriteLine();
            }
        }

        private TransactionRequest BuildTransaction(string id, double price, DateTimeOffset tradeDate)
        {
            return new TransactionRequest(        
                transactionId: Guid.NewGuid().ToString(),
                type: "StockIn",
                instrumentIdentifiers: new Dictionary<string, string> { [LUSID_INSTRUMENT_IDENTIFIER] = id },
                transactionDate: tradeDate.ToLUSIDDate(),
                settlementDate: tradeDate.ToLUSIDDate(),
                units: 100,
                transactionPrice: new TransactionPrice(price, TransactionPrice.TypeEnum.Price),
                totalConsideration: new CurrencyAndAmount(100 * price, "GBP"),
                source: "Custodian"
            );
        }

        [Test, Ignore("Isin not yet supported")]
         public void Lookup_Instruments()
         {            
             var isins = new List<string> 
             {
                 "IT0004966401",
                 "FR0010192997"                
             };
             
             //    look up ids
             var fbnIds = _apiFactory.Api<IInstrumentsApi>().GetInstruments("Isin", isins);
             
             Assert.That(fbnIds.Values.Count, Is.EqualTo(2));
         }

        private TransactionRequest BuildTradeWithQuantity(string id, double price, double quantity,  DateTimeOffset tradeDate)
        {
            return new TransactionRequest
            (
                transactionId: Guid.NewGuid().ToString(),
                type: "StockIn",
                instrumentIdentifiers: new Dictionary<string, string> { [LUSID_INSTRUMENT_IDENTIFIER] = id },
                transactionDate: tradeDate.ToLUSIDDate(),
                settlementDate: tradeDate.ToLUSIDDate(),
                units: quantity,
                transactionPrice: new TransactionPrice(price, TransactionPrice.TypeEnum.Price),
                totalConsideration: new CurrencyAndAmount(quantity * price, "GBP"),
                source: "Custodian"
            );
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
                code: portfolioCode, 
                baseCurrency: "GBP", 
                created: yesterday
            );
            var portfolio = _apiFactory.Api<ITransactionPortfoliosApi>().CreatePortfolio(scope, requestPortfolio);
           
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
            _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(scope, portfolioCode, transactions.ToList());

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
            var finalResult = _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(scope, portfolioCode, transactions.ToList());

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

            var listOfBreaks = _apiFactory.Api<IReconciliationsApi>().ReconcileHoldings(request: reconcileRequest);

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
                    Console.WriteLine($"{abreak.InstrumentUid}\t{abreak.DifferenceUnits}\t{abreak.DifferenceCost}");
                }

                Console.WriteLine();
            }
        }

    }
    
}
 