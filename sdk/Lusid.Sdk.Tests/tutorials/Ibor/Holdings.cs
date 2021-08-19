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
    public class Holdings
    {
        private ITransactionPortfoliosApi _transactionPortfoliosApi;
        private TestDataUtilities _testDataUtilities;
        private IList<string> _instrumentIds;

        [OneTimeSetUp]
        public void SetUp()
        {
            var apiFactory = LusidApiFactoryBuilder.Build("secrets.json");
            _transactionPortfoliosApi = apiFactory.Api<ITransactionPortfoliosApi>();
            
            _testDataUtilities = new TestDataUtilities(_transactionPortfoliosApi, apiFactory.Api<IPortfoliosApi>());

            var instrumentsLoader = new InstrumentLoader(apiFactory);
            _instrumentIds = instrumentsLoader.LoadInstruments().OrderBy(x => x).ToList();
        }
        
        [LusidFeature("F2")]
        [Test]
        public void Get_Holdings()
        {
            //    The currency of the cash and transactions
            const string currency = "GBP";
            
            //    The dates for which transactions are added to the portfolio.  All dates/times
            //    must be supplied in UTC
            var dayT1 = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            var dayTPlus5 = new DateTimeOffset(2018, 1, 5, 0, 0, 0, TimeSpan.Zero);
            var dayTPlus10 = new DateTimeOffset(2018, 1, 10, 0, 0, 0, TimeSpan.Zero);
            
            //    Create a portfolio
            var portfolioId = _testDataUtilities.CreateTransactionPortfolio(TestDataUtilities.TutorialScope);
            
            //    The list of transactions to add to LUSID
            var transactions = new List<TransactionRequest>();
            
            //    Add the starting cash position
            transactions.Add(_testDataUtilities.BuildCashFundsInTransactionRequest(100000, currency, dayT1));
            
            //    Add initial transactions on dayT1
            transactions.Add(_testDataUtilities.BuildTransactionRequest(_instrumentIds[0], 100.0M, 101.0M, currency, dayT1, "Buy"));
            transactions.Add(_testDataUtilities.BuildTransactionRequest(_instrumentIds[1], 100.0M, 102.0M, currency, dayT1, "Buy"));
            transactions.Add(_testDataUtilities.BuildTransactionRequest(_instrumentIds[2], 100.0M, 103.0M, currency, dayT1, "Buy"));
            
            //    On T+5, add a transaction in another instrument and another to increase the amount of instrument 1
            transactions.Add(_testDataUtilities.BuildTransactionRequest(_instrumentIds[1], 100.0M, 104.0M, currency, dayTPlus5, "Buy"));
            transactions.Add(_testDataUtilities.BuildTransactionRequest(_instrumentIds[3], 100.0M, 105.0M, currency, dayTPlus5, "Buy"));
            
            //    Upload the transactions to LUSID
            _transactionPortfoliosApi.UpsertTransactions(TestDataUtilities.TutorialScope, portfolioId, transactions);
            
            //    Get the portfolio holdings on T+10
            var holdings = _transactionPortfoliosApi.GetHoldings(TestDataUtilities.TutorialScope, portfolioId, effectiveAt: dayTPlus10);
            
            //    Ensure we have 5 holdings: 1 cash position and a position in 4 instruments that aggregates the 5 transactions
            Assert.That(holdings.Values.Count(), Is.EqualTo(5));
            
            holdings.Values.Sort((h1, h2) => String.Compare(h1.InstrumentUid, h2.InstrumentUid, StringComparison.Ordinal));
            
            //    Check the cash balance
            Assert.That(holdings.Values[0].InstrumentUid, Is.EqualTo($"CCY_{currency}"));
            
            //    Validate we have the correct instruments
            Assert.That(holdings.Values[1].InstrumentUid, Is.EqualTo(_instrumentIds[0]));
            Assert.That(holdings.Values[2].InstrumentUid, Is.EqualTo(_instrumentIds[1]));
            Assert.That(holdings.Values[3].InstrumentUid, Is.EqualTo(_instrumentIds[2]));
            Assert.That(holdings.Values[4].InstrumentUid, Is.EqualTo(_instrumentIds[3]));
            
            //    Validate the holdings
            Assert.That(holdings.Values[0].HoldingType, Is.EqualTo("B"));    //    B = Balance
            
            Assert.That(holdings.Values[1].HoldingType, Is.EqualTo("P"));
            Assert.That(holdings.Values[1].Units, Is.EqualTo(100.0));
            Assert.That(holdings.Values[1].Cost.Amount, Is.EqualTo(10100.0));
            
            Assert.That(holdings.Values[2].HoldingType, Is.EqualTo("P"));
            Assert.That(holdings.Values[2].Units, Is.EqualTo(200.0));
            Assert.That(holdings.Values[2].Cost.Amount, Is.EqualTo(20600.0));
            
            Assert.That(holdings.Values[3].HoldingType, Is.EqualTo("P"));
            Assert.That(holdings.Values[3].Units, Is.EqualTo(100.0));
            Assert.That(holdings.Values[3].Cost.Amount, Is.EqualTo(10300.0));
            
            Assert.That(holdings.Values[4].HoldingType, Is.EqualTo("P"));
            Assert.That(holdings.Values[4].Units, Is.EqualTo(100.0));
            Assert.That(holdings.Values[4].Cost.Amount, Is.EqualTo(10500.0));
        }
        
        [LusidFeature("F3")]
        [Test]
        public void Set_Target_Holdings()
        {
            const string currency = "GBP";
            
            var day1 = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            var day2 = new DateTimeOffset(2018, 1, 5, 0, 0, 0, TimeSpan.Zero);

            var portfolioCode = _testDataUtilities.CreateTransactionPortfolio(TestDataUtilities.TutorialScope);

            var instrument1 = _instrumentIds[0];
            var instrument2 = _instrumentIds[1];
            var instrument3 = _instrumentIds[2];

            var holdingAdjustmentsRequest = new List<AdjustHoldingRequest>
            {
                //    cash balance
                new AdjustHoldingRequest(
                        instrumentIdentifiers: new Dictionary<string, string> { [TestDataUtilities.LusidCashIdentifier] = currency},
                        taxLots: new List<TargetTaxLotRequest>
                        {
                            new TargetTaxLotRequest(units: 100000.0M)
                        }
                    ),
                
                //    instrument 1
                new AdjustHoldingRequest(
                        instrumentIdentifiers: new Dictionary<string, string> { [TestDataUtilities.LusidInstrumentIdentifier] = instrument1},
                        taxLots: new List<TargetTaxLotRequest>
                        {
                            new TargetTaxLotRequest(
                                units: 100.0M, 
                                price: 101.0M, 
                                cost: new CurrencyAndAmount(10100.0M, currency),
                                portfolioCost: 10100.0M,
                                purchaseDate: day1,
                                settlementDate: day1
                            )
                        }
                    ),
                
                //    instrument 2
                new AdjustHoldingRequest(
                    instrumentIdentifiers: new Dictionary<string, string> { [TestDataUtilities.LusidInstrumentIdentifier] = instrument2},
                    taxLots: new List<TargetTaxLotRequest>
                    {
                        new TargetTaxLotRequest(
                            units: 100.0M, 
                            price: 102.0M, 
                            cost: new CurrencyAndAmount(10200.0M, currency),
                            portfolioCost: 10200.0M,
                            purchaseDate: day1,
                            settlementDate: day1
                        )
                    }
                )
            };
            
            //    set the initial holdings on day 1
            _transactionPortfoliosApi.SetHoldings(TestDataUtilities.TutorialScope, portfolioCode, day1, holdingAdjustmentsRequest);
            
            //    add subsequent transactions on day 2
            _transactionPortfoliosApi.UpsertTransactions(TestDataUtilities.TutorialScope, portfolioCode,
                new List<TransactionRequest>
                {
                    _testDataUtilities.BuildTransactionRequest(instrument1, units: 100.0M, price: 104.0M, currency: currency, tradeDate: day2, transactionType: "Buy"),
                    _testDataUtilities.BuildTransactionRequest(instrument3, units: 100.0M, price: 103.0M, currency: currency, tradeDate: day2, transactionType: "Buy")
                });
            
            //    get the holdings for day 2
            var holdingsResult = _transactionPortfoliosApi.GetHoldings(TestDataUtilities.TutorialScope, portfolioCode, effectiveAt: day2);
            var holdings = holdingsResult.Values.OrderBy(h => h.InstrumentUid).ToList();
            
            //    cash balance + 3 holdings
            Assert.That(holdings, Has.Count.EqualTo(4));
            
            //  remaining cash balance which takes into account the purchase transactions on day 2
            
            // the call to GetHoldings returns the LUID not the identifier we created
            var currencyLuid = $"CCY_{currency}";
            
            Assert.That(holdings[0].InstrumentUid, Is.EqualTo(currencyLuid));
            Assert.That(holdings[0].Units, Is.EqualTo(79300.0));
            
            //  instrument1 - initial holding + transaction on day 2
            Assert.That(holdings[1].InstrumentUid, Is.EqualTo(instrument1));
            Assert.That(holdings[1].Units, Is.EqualTo(200.0));
            Assert.That(holdings[1].Cost.Amount, Is.EqualTo(20500.0));
            
            //  instrument2 - initial holding
            Assert.That(holdings[2].InstrumentUid, Is.EqualTo(instrument2));
            Assert.That(holdings[2].Units, Is.EqualTo(100.0));
            Assert.That(holdings[2].Cost.Amount, Is.EqualTo(10200.0));
            
            //  instrument3 - transaction on day 2
            Assert.That(holdings[3].InstrumentUid, Is.EqualTo(instrument3));
            Assert.That(holdings[3].Units, Is.EqualTo(100.0));
            Assert.That(holdings[3].Cost.Amount, Is.EqualTo(10300.0));

            // Get all the holding adjustments in the portfolio
            var holdingAdjustments = _transactionPortfoliosApi.ListHoldingsAdjustments(TestDataUtilities.TutorialScope, portfolioCode);

            // The list should contain one record containing the effective date of the holding adjustment
            Assert.That(holdingAdjustments.Values.Select(ha => ha.EffectiveAt), Is.EquivalentTo(new [] { day1 }));
        }
    }
}
