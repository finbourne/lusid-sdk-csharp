using System;
using System.Collections.Generic;
using System.Linq;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Tests.Utilities;
using Lusid.Sdk.Utilities;
using LusidFeatures;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Tutorials.Ibor
{
    [TestFixture]
    public class Reconciliation
    {
        private ILusidApiFactory _apiFactory;
        private InstrumentLoader _instrumentLoader;
        private TestDataUtilities _testDataUtilities;
        private IList<string> _instrumentIds;

        [OneTimeSetUp]
        public void SetUp()
        {
            _apiFactory = LusidApiFactoryBuilder.Build("secrets.json");
            
            _instrumentLoader = new InstrumentLoader(_apiFactory);
            _instrumentIds = _instrumentLoader.LoadInstruments();
            _testDataUtilities = new TestDataUtilities(_apiFactory.Api<ITransactionPortfoliosApi>());
        }
        
        [LusidFeature("F20-1")]
        [Test]
        public void Reconcile_Portfolio()
        {
            var portfolioCode = _testDataUtilities.CreateTransactionPortfolio(TestDataUtilities.TutorialScope);
            
            var today = new DateTimeOffset(DateTimeOffset.UtcNow.Date).ToUniversalTime();
            var yesterday = today.AddDays(-1).ToUniversalTime();
            
            //    Create transactions for yesterday
            var yesterdaysTransactions = new List<TransactionRequest>
            {
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[0], 1000, 100, "GBP", yesterday.AddHours(8), "StockIn"),
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[0], 2300, 101, "GBP", yesterday.AddHours(12), "StockIn"),
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[1], -1000, 102, "GBP", yesterday.AddHours(9), "StockIn"),
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[2], 1200, 103, "GBP", yesterday.AddHours(16), "StockIn"),
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[3], 2000, 103, "GBP", yesterday.AddHours(9), "StockIn")
            };
            
            //    Add transactions
            _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(TestDataUtilities.TutorialScope, portfolioCode, yesterdaysTransactions);

            var todaysTransactions = new List<TransactionRequest>
            {
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[0], -3000, 101.78M, "GBP", today.AddHours(8), "StockIn"),    // net long 300
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[0], 1500, 101.78M, "GBP", today.AddHours(12), "StockIn"),    // net long 1800
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[1], 1000, 102, "GBP", today.AddHours(12), "StockIn"),       // flat                
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[2], 1200, 103, "GBP", today.AddHours(16), "StockIn"),       // long 2400
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[3], 1000, 103, "GBP", today.AddHours(9), "StockIn"),        // long 3000
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[3], 2000, 103, "GBP", today.AddHours(20), "StockIn")        // long 5000 but outside recon window
            };

            //    add transactions
            var finalResult = _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(TestDataUtilities.TutorialScope, portfolioCode, todaysTransactions);

            //Using the last result find out its AsAtDate (based on the servers clock at the time of the test)
            var finalAsAtTime = finalResult.Version.AsAtDate;

            //So now we have the portfolio with 2 days worth of transactions, going to reconcile from T-1 20:00 to now,
            //this should reflect breaks for each instrument equal to the transactions from yesterday till 20 today. 

            var reconcileRequest =
                new PortfoliosReconciliationRequest(
                    new PortfolioReconciliationRequest(
                        new ResourceId(TestDataUtilities.TutorialScope, portfolioCode),
                        yesterday.AddHours(20).ToString("o"),
                        finalAsAtTime),
                    new PortfolioReconciliationRequest(
                        new ResourceId(TestDataUtilities.TutorialScope, portfolioCode),
                        today.AddHours(16).ToString("o"),
                        finalAsAtTime),
                    new List<string>());

            var listOfBreaks = _apiFactory.Api<IReconciliationsApi>().ReconcileHoldings(portfoliosReconciliationRequest: reconcileRequest);

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
                    Console.WriteLine($"{abreak.InstrumentUid}\t{abreak.DifferenceUnits}\t{abreak.DifferenceCost.Amount}");
                }

                Console.WriteLine();
            }
        }

        
    }
}