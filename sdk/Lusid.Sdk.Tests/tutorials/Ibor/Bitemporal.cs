using System;
using System.Collections.Generic;
using System.Threading;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Tests.Utilities;
using Lusid.Sdk.Utilities;
using LusidFeatures;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Tutorials.Ibor
{
    [TestFixture]
    public class Bitemporal
    {
        private ILusidApiFactory _apiFactory;
        private TestDataUtilities _testDataUtilities;
        private IList<string> _instrumentIds;

        [OneTimeSetUp]
        public void SetUp()
        {
            _apiFactory = LusidApiFactoryBuilder.Build("secrets.json");
            
            var instrumentLoader = new InstrumentLoader(_apiFactory);
            _instrumentIds = instrumentLoader.LoadInstruments();
            _testDataUtilities = new TestDataUtilities(_apiFactory.Api<ITransactionPortfoliosApi>());
        }
        
        [Test]
        [LusidFeature("F13-7")]
        public void Apply_Bitemporal_Portfolio_Change()
        {
            var portfolioId = _testDataUtilities.CreateTransactionPortfolio(TestDataUtilities.TutorialScope);

            var newTransactions = new List<TransactionRequest>
            {
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[0], 100, 101, "GBP", new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero), "Buy"),
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[1], 100, 102, "GBP", new DateTimeOffset(2018, 1, 2, 0, 0, 0, TimeSpan.Zero), "Buy"),
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[2], 100, 103, "GBP", new DateTimeOffset(2018, 1, 3, 0, 0, 0, TimeSpan.Zero), "Buy"),
            };
            
            //    add initial batch of transactions
            var initialResult = _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(TestDataUtilities.TutorialScope, portfolioId, newTransactions);

            var asAtBatch1 = initialResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    add another transaction for 2018-1-8
            var laterResult = _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(TestDataUtilities.TutorialScope, portfolioId, new List<TransactionRequest>
            {
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[3], 100, 104, "GBP", new DateTimeOffset(2018, 1, 8, 0, 0, 0, TimeSpan.Zero), "Buy"),
            });

            var asAtBatch2 = laterResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    add back-dated transaction
            var backDatedResult = _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(TestDataUtilities.TutorialScope, portfolioId, new List<TransactionRequest>
            {
                _testDataUtilities.BuildTransactionRequest(_instrumentIds[4], 100, 105, "GBP", new DateTimeOffset(2018, 1, 5, 0, 0, 0, TimeSpan.Zero), "Buy"),
            });

            var asAtBatch3 = backDatedResult.Version.AsAtDate;
            Thread.Sleep(500);

            //    list transactions
            var transactions = _apiFactory.Api<ITransactionPortfoliosApi>().GetTransactions(TestDataUtilities.TutorialScope, portfolioId, asAt: asAtBatch1);
            
            Assert.That(transactions.Values.Count, Is.EqualTo(3), $"AsAt: {asAtBatch1:o}");
            Console.WriteLine($"transactions at {asAtBatch1}");
            PrintTransactions(transactions.Values);

            transactions = _apiFactory.Api<ITransactionPortfoliosApi>().GetTransactions(TestDataUtilities.TutorialScope, portfolioId, asAt: asAtBatch2);
            
            Assert.That(transactions.Values.Count, Is.EqualTo(4), $"AsAt: {asAtBatch2:o}");
            Console.WriteLine($"transactions at {asAtBatch2}");
            PrintTransactions(transactions.Values);

            transactions = _apiFactory.Api<ITransactionPortfoliosApi>().GetTransactions(TestDataUtilities.TutorialScope, portfolioId, asAt: asAtBatch3);
            
            Assert.That(transactions.Values.Count, Is.EqualTo(5), $"AsAt: {asAtBatch3:o}");
            Console.WriteLine($"transactions at {asAtBatch3}");
            PrintTransactions(transactions.Values);

            transactions = _apiFactory.Api<ITransactionPortfoliosApi>().GetTransactions(TestDataUtilities.TutorialScope, portfolioId);
            
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
    }
}