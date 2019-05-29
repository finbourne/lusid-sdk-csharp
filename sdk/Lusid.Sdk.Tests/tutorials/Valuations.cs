using System;
using System.Collections.Generic;
using System.Linq;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Utilities;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Tutorials
{
    [TestFixture]
    public class Valuations
    {
        private ILusidApiFactory _apiFactory;
        private InstrumentLoader _instrumentLoader;
        private TestDataUtilities _testDataUtilities;
        private IList<string> _instrumentIds;

        //    This defines the scope that entities will be created in
        private const string TutorialScope = "Testdemo";
        
        
        [OneTimeSetUp]
        public void SetUp()
        {
            _apiFactory = LusidApiFactoryBuilder.Build("secrets.json");
            
            _instrumentLoader = new InstrumentLoader(_apiFactory);
            _instrumentIds = _instrumentLoader.LoadInstruments();
            _testDataUtilities = new TestDataUtilities(_apiFactory.Api<ITransactionPortfoliosApi>());
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            _instrumentLoader.DeleteInstruments();
        }

        [Test]
        public void Run_Valuation()
        {
            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            
            //    Create the transaction portfolio
            var portfolioId = _testDataUtilities.CreateTransactionPortfolio(TutorialScope);

            var transactionSpecs = new[]
                {
                    (Id: _instrumentIds[0], Price: 101, TradeDate: effectiveDate),
                    (Id: _instrumentIds[1], Price: 102, TradeDate: effectiveDate),
                    (Id: _instrumentIds[2], Price: 103, TradeDate: effectiveDate)
                }
                .OrderBy(i => i.Id);

            var newTransactions = transactionSpecs.Select(id => _testDataUtilities.BuildTransactionRequest(id.Id, 100.0, id.Price, "GBP", id.TradeDate, "Buy"));

            //    Add transactions to the portfolio
            _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(TutorialScope, portfolioId, newTransactions.ToList());
            
            //    Set up analytic store used to store prices for the valuation
            var analyticStores = _apiFactory.Api<IAnalyticsStoresApi>().ListAnalyticStores();
            var store = analyticStores.Values.Where(s => s.Date == effectiveDate && s.Scope == TutorialScope);

            if (!store.Any())
            {
                //    Create the analytic store if one doesn't already exist
                var analyticStoreRequest = new CreateAnalyticStoreRequest(TutorialScope, effectiveDate);
                _apiFactory.Api<IAnalyticsStoresApi>().CreateAnalyticStore(analyticStoreRequest);
            }
                        
            var prices = new List<InstrumentAnalytic>
            {
                new InstrumentAnalytic(_instrumentIds[0], 100), 
                new InstrumentAnalytic(_instrumentIds[1], 200),
                new InstrumentAnalytic(_instrumentIds[2], 300)
            };
            
            //    Add prices to the analytics store
            _apiFactory.Api<IAnalyticsStoresApi>().SetAnalytics(TutorialScope, effectiveDate.Year, effectiveDate.Month, effectiveDate.Day, prices);
                       
            //    Create the aggregation request, this example calculates the percentage of total portfolio value and value by instrument 
            var aggregationRequest = new AggregationRequest(
                recipeId: new ResourceId(TutorialScope, "default"),
                metrics: new List<AggregateSpec>
                {
                    new AggregateSpec("Instrument/default/Name", AggregateSpec.OpEnum.Value),
                    new AggregateSpec("Holding/default/PV", AggregateSpec.OpEnum.Proportion),
                    new AggregateSpec("Holding/default/PV", AggregateSpec.OpEnum.Sum)
                },
                groupBy: new List<string> {"Instrument/default/Name"},
                effectiveAt: effectiveDate
            );

            //    Do the aggregation
            _apiFactory.Api<IAggregationApi>().GetAggregationByPortfolio(TutorialScope, portfolioId, request: aggregationRequest);
        }

    }
}