using System;
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Tests.Utilities;
using Lusid.Sdk.Utilities;
using LusidFeatures;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Tutorials.Ibor
{
    [TestFixture]
    public class Transactions
    {
        private IInstrumentsApi _instrumentsApi;
        private ITransactionPortfoliosApi _transactionPortfoliosApi;
        private IList<string> _instrumentIds;
        
        private TestDataUtilities _testDataUtilities;

        [OneTimeSetUp]
        public void SetUp()
        {
            var apiFactory = LusidApiFactoryBuilder.Build("secrets.json");

            _instrumentsApi = apiFactory.Api<IInstrumentsApi>();
            _transactionPortfoliosApi = apiFactory.Api<ITransactionPortfoliosApi>();
            
            var instrumentLoader = new InstrumentLoader(apiFactory);
            _instrumentIds = instrumentLoader.LoadInstruments();
            _testDataUtilities = new TestDataUtilities(apiFactory.Api<ITransactionPortfoliosApi>());
        }
        
        [LusidFeature("F13-9")]
        [Test]
        public void Load_Listed_Instrument_Transaction()
        {
            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            
            //    create the portfolio
            var portfolioCode = _testDataUtilities.CreateTransactionPortfolio(TestDataUtilities.TutorialScope);
            
            //    create the transaction request
            var transaction = new TransactionRequest(
                
                //    unique transaction id
                transactionId: Guid.NewGuid().ToString(),
                
                //    instruments must already exist in LUSID and have a valid LUSID instrument id
                instrumentIdentifiers: new Dictionary<string, string>
                {
                    [TestDataUtilities.LusidInstrumentIdentifier] = _instrumentIds[0]
                },
                
                type: "Buy",
                totalConsideration: new CurrencyAndAmount(1230, "GBP"),
                transactionDate: effectiveDate,
                settlementDate: effectiveDate,
                units: 100,
                transactionPrice: new TransactionPrice(12.3M),
                source: "Custodian");
            
            //    add the transaction
            _transactionPortfoliosApi.UpsertTransactions(TestDataUtilities.TutorialScope, portfolioCode, new List<TransactionRequest> {transaction});
            
            //    get the trade
            var transactions = _transactionPortfoliosApi.GetTransactions(TestDataUtilities.TutorialScope, portfolioCode);
            
            Assert.That(transactions.Values, Has.Count.EqualTo(1));
            Assert.That(transactions.Values[0].TransactionId, Is.EqualTo(transaction.TransactionId));
        }
        
        [LusidFeature("F13-2")]
        [Test]
        public void Load_Cash_Transaction()
        {
            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            
            //    create the portfolio
            var portfolioCode = _testDataUtilities.CreateTransactionPortfolio(TestDataUtilities.TutorialScope);
            
            //    create the transaction request
            var transaction = new TransactionRequest(
                
                //    unique transaction id
                transactionId: Guid.NewGuid().ToString(),
                
                //    instruments must already exist in LUSID and have a valid LUSID instrument id
                instrumentIdentifiers: new Dictionary<string, string>
                {
                    [TestDataUtilities.LusidCashIdentifier] = "GBP"
                },
                
                type: "FundsIn",
                totalConsideration: new CurrencyAndAmount(0.0M, "GBP"),
                transactionPrice: new TransactionPrice(0.0M),
                transactionDate: effectiveDate,
                settlementDate: effectiveDate,
                units: 100,
                source: "Custodian");
            
            //    add the transaction
            _transactionPortfoliosApi.UpsertTransactions(TestDataUtilities.TutorialScope, portfolioCode, new List<TransactionRequest> {transaction});
            
            //    get the trade
            var transactions = _transactionPortfoliosApi.GetTransactions(TestDataUtilities.TutorialScope, portfolioCode);
            
            Assert.That(transactions.Values, Has.Count.EqualTo(1));
            Assert.That(transactions.Values[0].TransactionId, Is.EqualTo(transaction.TransactionId));
        }
        
    }
}