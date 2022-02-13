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
    /// <summary>
    /// Set up to create a ILusidApiFactory which is used to make calls to the
    /// LUSID API.  A
    /// </summary>
    [TestFixture]
    public class Portfolios
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
        
        [LusidFeature("F1-4")]
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
        
        [LusidFeature("F1-1")]
        [Test]
        public void Create_Transaction_Portfolio_With_Property()
        {
            var uuid = Guid.NewGuid().ToString();
            var propertyName = $"fund-style-{uuid}";
            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            
            //    Details of the property to be created
            var propertyDefinition = new CreatePropertyDefinitionRequest(
                
                //    The domain the property is to be applied to
                domain: CreatePropertyDefinitionRequest.DomainEnum.Portfolio,
                
                //    The scope the property will be created in
                scope: TestDataUtilities.TutorialScope,
                
                //    When the property value is set it will be valid forever and cannot be changed.
                //    Properties whose values can change over time should be created with LifeTimeEnum.TIMEVARIANT
                lifeTime: CreatePropertyDefinitionRequest.LifeTimeEnum.Perpetual,
                
                code: propertyName,
                valueRequired: false,
                displayName: "Fund Style",
                dataTypeId: new ResourceId("system", "string")
            );
            
            //    Create the property definition
            var propertyDefinitionResult = _apiFactory.Api<IPropertyDefinitionsApi>().CreatePropertyDefinition(propertyDefinition);
            
            //    Create the property value
            var propertyValue = new PropertyValue(labelValue: "Active");
            
            //    Details of the new portfolio to be created, created here with the minimum set of mandatory fields 
            var createPortfolioRequest = new CreateTransactionPortfolioRequest(
                code: $"id-{uuid}",
                displayName: $"Portfolio-{uuid}",
                baseCurrency: "GBP",
                created: effectiveDate,
                
                //    Set the property value when creating the portfolio
                properties: new Dictionary<string, Property>
                {
                    [propertyDefinitionResult.Key] = new Property(
                        propertyDefinitionResult.Key,
                        propertyValue)
                }
            );

            //    Create the portfolio
            var portfolioResult = _apiFactory.Api<ITransactionPortfoliosApi>().CreatePortfolio(TestDataUtilities.TutorialScope, createPortfolioRequest);
            
            Assert.That(portfolioResult.Id.Code, Is.EqualTo(createPortfolioRequest.Code));

            var portfolioProperties = _apiFactory.Api<IPortfoliosApi>().GetPortfolioProperties(TestDataUtilities.TutorialScope, portfolioResult.Id.Code);

            Assert.That(portfolioProperties.Properties, Has.Count.EqualTo(1));
            Assert.That(portfolioProperties.Properties[propertyDefinitionResult.Key].Value.LabelValue, Is.EqualTo("Active"));
        }
        
        [LusidFeature("F13-8")]
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
                
                transactionDate: effectiveDate,
                settlementDate: effectiveDate,
                units: 100,
                transactionPrice: new TransactionPrice(12.3M, TransactionPrice.TypeEnum.Price),
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
        
        [LusidFeature("F13-4")]
        [Test]
        public void Add_Transactions_To_Portfolio_With_Property()
        {
            var uuid = Guid.NewGuid().ToString();
            var propertyName = $"fund-style-{uuid}";
            var labelValue = "A Trader";

            //    Effective date of the trades. All dates/times must be supplied in UTC
            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            
            //    Details of the property to be created
            var propertyDefinition = new CreatePropertyDefinitionRequest(
                
                //    The domain the property is to be applied to
                domain: CreatePropertyDefinitionRequest.DomainEnum.Transaction,
                
                //    The scope the property will be created in
                scope: TestDataUtilities.TutorialScope,
                
                //    When the property value is set it will be valid forever and cannot be changed.
                //    Properties whose values can change over time should be created with LifeTimeEnum.TIMEVARIANT
                lifeTime: CreatePropertyDefinitionRequest.LifeTimeEnum.Perpetual,
                
                code: propertyName,
                valueRequired: false,
                displayName: "Trader Id",
                dataTypeId: new ResourceId("system", "string")
            );
            
            //    Create the property definition
            var propertyDefinitionResult = _apiFactory.Api<IPropertyDefinitionsApi>().CreatePropertyDefinition(propertyDefinition);
            
            //    Create the property value
            var propertyValue = new PerpetualProperty(propertyDefinitionResult.Key, new PropertyValue(labelValue));

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
                
                //    The properties to be added to the transaction
                properties: new Dictionary<string, PerpetualProperty>
                {
                    [propertyDefinitionResult.Key] = propertyValue
                },
                
                transactionDate: effectiveDate,
                settlementDate: effectiveDate,
                units: 100,
                transactionPrice: new TransactionPrice(12.3M, TransactionPrice.TypeEnum.Price),
                totalConsideration: new CurrencyAndAmount(1230, "GBP"),
                source: "Custodian"
            );

            //    Add the transaction to the portfolio
            _apiFactory.Api<ITransactionPortfoliosApi>().UpsertTransactions(TutorialScope, portfolioId, new List<TransactionRequest> {transaction});
            
            //    Retrieve the transaction
            var transactions = _apiFactory.Api<ITransactionPortfoliosApi>().GetTransactions(TutorialScope, portfolioId);                
            
            Assert.That(transactions.Values.Count, Is.EqualTo(1));
            Assert.That(transactions.Values[0].InstrumentUid, Is.EqualTo(transaction.InstrumentIdentifiers.First().Value));
            Assert.That(transactions.Values[0].Properties[propertyDefinitionResult.Key].Value.LabelValue, Is.EqualTo(labelValue));
        }
        
        [LusidFeature("F2-4")]
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
            
            Assert.That(portfolios.Values.Count(), Is.EqualTo(10));

        }
        
        [LusidFeature("F19-1")]
        [Test]
        public void List_Scopes()
        {
            //    Get the list of scopes across all entities
            var scopes = _apiFactory.Api<IScopesApi>().ListScopes();

            Assert.That(scopes.Values.Count(), Is.GreaterThan(0));
        }

    }
}
