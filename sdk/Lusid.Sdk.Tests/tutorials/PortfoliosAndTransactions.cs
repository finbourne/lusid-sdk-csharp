using System;
using System.Collections.Generic;
using System.Linq;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Utilities;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Tutorials
{
    /// <summary>
    /// Set up to create a ILusidApiFactory which is used to make calls to the
    /// LUSID API.  A
    /// </summary>
    [TestFixture]
    public class PortfoliosAndTransactions
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
        public void Create_Transaction_Portfolio()
        {
            var uuid = Guid.NewGuid().ToString();
            
            //    Details of the new portfolio to be created, created here with the minimum set of mandatory fields 
            var request = new CreateTransactionPortfolioRequest(
                
                //    Unique portfolio code, portfolio codes must be unique across scopes
                code: $"id-{uuid}",
                
                //    Descriptive name for the portfolio
                displayName: $"Portfolio-{uuid}",                 
                
                baseCurrency: "GBP"
            );

            //    Create the portfolio in LUSID
            var portfolio = _apiFactory.Api<ITransactionPortfoliosApi>().CreatePortfolio(TutorialScope, request);

            //    Confirm that the portfolio was successfully created.  Any failures will result in
            //    a ApiException being thrown which contain the relevant response code and error message
            Assert.That(portfolio.Id.Code, Is.EqualTo(request.Code));
        }

        [Test]
        public void Add_Transactions_To_Portfolio()
        {
            //    Effective date of the trades. All dates/times must be supplied in UTC
            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);

            //    Create a portfolio
            var portfolioId = _testDataUtilities.CreateTransactionPortfolio(TutorialScope);

            //    Details of the transaction to be added       
            var transaction = new TransactionRequest(
                
                //    Unique transaction id
                transactionId: Guid.NewGuid().ToString(),
                
                //    Transaction type, configured during system setup
                type: "Buy",
                
                //    Instrument identifier for the trnasaction
                instrumentIdentifiers: new Dictionary<string, string>
                {
                    ["Instrument/default/LusidInstrumentId"] = _instrumentIds.First()
                },  
                
                transactionDate: effectiveDate.ToLUSIDDate(),
                settlementDate: effectiveDate.ToLUSIDDate(),
                units: 100,
                transactionPrice: new TransactionPrice(12.3, TransactionPrice.TypeEnum.Price),
                totalConsideration: new CurrencyAndAmount(1230, "GBP"),
                source: "Broker"
            );

            //    Add the transaction to the portfolio
            _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(TutorialScope, portfolioId, new List<TransactionRequest> {transaction});
            
            //    Retrieve the transaction
            var transactions = _apiFactory.Api<ITransactionPortfoliosApi>().GetTransactions(TutorialScope, portfolioId);                
            
            Assert.That(transactions.Values.Count, Is.EqualTo(1));
            Assert.That(transactions.Values[0].InstrumentUid, Is.EqualTo(transaction.InstrumentIdentifiers.First().Value));           
        }

        [Test]
        public void List_Portfolios()
        {
            //    This defines the scope that the portfolios will be retrieved from
            var scope = $"{TutorialScope}-{Guid.NewGuid().ToString()}";
            
            //    Set up some sample portfolios
            for (var i = 0; i < 10; i++)
            {
                _testDataUtilities.CreateTransactionPortfolio(scope);
            }
            
            //    Retrieve the list of portfolios from a given scope           
            var portfolios = _apiFactory.Api<IPortfoliosApi>().ListPortfoliosForScope(scope);
            
            Assert.That(portfolios.Count, Is.EqualTo(10));

        }

        [Test]
        public void List_Scopes()
        {
            //    Get the list of scopes across all entities
            var scopes = _apiFactory.Api<IScopesApi>().ListScopes();

            Assert.That(scopes.Count, Is.GreaterThan(0));
        }

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
            var portfolioId = _testDataUtilities.CreateTransactionPortfolio(TutorialScope);
            
            //    The list of transactions to add to LUSID
            var transactions = new List<TransactionRequest>();
            
            //    Add the starting cash position
            transactions.Add(_testDataUtilities.BuildCashFundsInTransactionRequest(100000, currency, dayT1));
            
            //    Add initial transactions on dayT1
            transactions.Add(_testDataUtilities.BuildTransactionRequest(_instrumentIds[0], 100.0, 101.0, currency, dayT1, "Buy"));
            transactions.Add(_testDataUtilities.BuildTransactionRequest(_instrumentIds[1], 100.0, 102.0, currency, dayT1, "Buy"));
            transactions.Add(_testDataUtilities.BuildTransactionRequest(_instrumentIds[2], 100.0, 103.0, currency, dayT1, "Buy"));
            
            //    On T+5, add a transaction in another instrument and another to increase the amount of instrument 1
            transactions.Add(_testDataUtilities.BuildTransactionRequest(_instrumentIds[1], 100.0, 104.0, currency, dayTPlus5, "Buy"));
            transactions.Add(_testDataUtilities.BuildTransactionRequest(_instrumentIds[3], 100.0, 105.0, currency, dayTPlus5, "Buy"));
            
            //    Upload the transactions to LUSID
            _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(TutorialScope, portfolioId, transactions);
            
            //    Get the portfolio holdings on T+10
            var holdings = _apiFactory.Api<ITransactionPortfoliosApi>().GetHoldings(TutorialScope, portfolioId, effectiveAt: dayTPlus10);
            
            //    Ensure we have 5 holdings: 1 cash position and a position in 4 instruments that aggregates the 5 transactions
            Assert.That(holdings.Count, Is.EqualTo(5));
            
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

    }
}