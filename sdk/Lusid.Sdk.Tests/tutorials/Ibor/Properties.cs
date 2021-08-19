using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Tests.Utilities;
using Lusid.Sdk.Utilities;
using LusidFeatures;
using static Lusid.Sdk.Utilities.PropertyExtensions;

namespace Lusid.Sdk.Tests.Tutorials.Ibor
{
    /// <summary>
    /// Set up to create a ILusidApiFactory which is used to make calls to the
    /// LUSID API.
    /// </summary>
    [TestFixture]
    public class Properties
    {
        private ILusidApiFactory _apiFactory;

        [OneTimeSetUp]
        public void SetUp()
        {
            _apiFactory = LusidApiFactoryBuilder.Build("secrets.json");
        }
        
        [LusidFeature("F14")]
        [Test]
        public void Create_Portfolio_With_Label_Property()
        {
            var uuid = Guid.NewGuid().ToString();
            var labelPropertyName = $"fund-style-{uuid}";
            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            
            //    Details of the property to be created
            var labelPropertyDefinition = new CreatePropertyDefinitionRequest(
                
                //    The domain the property is to be applied to
                domain: CreatePropertyDefinitionRequest.DomainEnum.Portfolio,
                
                //    The scope the property will be created in
                scope: TestDataUtilities.TutorialScope,
                
                //    When the property value is set it will be valid forever and cannot be changed.
                //    Properties whose values can change over time should be created with LifeTimeEnum.TIMEVARIANT
                lifeTime: CreatePropertyDefinitionRequest.LifeTimeEnum.Perpetual,
                
                code: labelPropertyName,
                valueRequired: false,
                displayName: "Fund Style",
                dataTypeId: new ResourceId("system", "string")
            );

            //    Create the property definition
            var labelPropertyDefinitionResult = _apiFactory.Api<IPropertyDefinitionsApi>().CreatePropertyDefinition(labelPropertyDefinition);
            
            //    Create the property values
            var labelPropertyValueRequest = new PropertyValue(labelValue: "Active");
            
            //    Details of the new portfolio to be created, created here with the minimum set of mandatory fields 
            var createPortfolioRequest = new CreateTransactionPortfolioRequest(
                code: $"id-{uuid}",
                displayName: $"Portfolio-{uuid}",
                baseCurrency: "GBP",
                created: effectiveDate,
                
                //    Set the property value when creating the portfolio
                properties: new Dictionary<string, Property>
                {
                    [labelPropertyDefinitionResult.Key] =
                        new Property(
                            labelPropertyDefinitionResult.Key,
                            labelPropertyValueRequest)
                }
            );

            //    Create the portfolio
            var portfolioResult = _apiFactory.Api<ITransactionPortfoliosApi>().CreatePortfolio(TestDataUtilities.TutorialScope, createPortfolioRequest);
            
            Assert.That(portfolioResult.Id.Code, Is.EqualTo(createPortfolioRequest.Code));

            var portfolioProperties = _apiFactory.Api<IPortfoliosApi>().GetPortfolioProperties(TestDataUtilities.TutorialScope, portfolioResult.Id.Code).Properties;

            Assert.That(portfolioProperties.Keys, Is.EquivalentTo(new [] { labelPropertyDefinitionResult.Key }));

            var labelProperty = portfolioProperties[labelPropertyDefinitionResult.Key];
            Assert.That(labelProperty.Value.LabelValue, Is.EqualTo(labelPropertyValueRequest.LabelValue));
        }
        
        [LusidFeature("F15")]
        [Test]
        public void Create_Portfolio_With_Metric_Property()
        {
            var uuid = Guid.NewGuid().ToString();
            var metricPropertyName = $"fund-nav-{uuid}";
            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            
            //    Details of the property to be created
            var metricPropertyDefinition = new CreatePropertyDefinitionRequest(
                
                //    The domain the property is to be applied to
                domain: CreatePropertyDefinitionRequest.DomainEnum.Portfolio,
                
                //    The scope the property will be created in
                scope: TestDataUtilities.TutorialScope,
                
                //    When the property value is set it will be valid forever and cannot be changed.
                //    Properties whose values can change over time should be created with LifeTimeEnum.TIMEVARIANT
                lifeTime: CreatePropertyDefinitionRequest.LifeTimeEnum.Perpetual,
                
                code: metricPropertyName,
                valueRequired: false,
                displayName: "Fund NAV",
                dataTypeId: new ResourceId("system", "currencyAndAmount")
            );
            
            //    Create the property definitions
            var metricPropertyDefinitionResult = _apiFactory.Api<IPropertyDefinitionsApi>().CreatePropertyDefinition(metricPropertyDefinition);
            
            //    Create the property values
            var metricPropertyValueRequest = new PropertyValue(metricValue: new MetricValue(1100000, "GBP"));
            
            //    Details of the new portfolio to be created, created here with the minimum set of mandatory fields 
            var createPortfolioRequest = new CreateTransactionPortfolioRequest(
                code: $"id-{uuid}",
                displayName: $"Portfolio-{uuid}",
                baseCurrency: "GBP",
                created: effectiveDate,
                
                //    Set the property value when creating the portfolio
                properties: new Dictionary<string, Property>
                {
                    [metricPropertyDefinitionResult.Key] = 
                        new Property(
                            metricPropertyDefinitionResult.Key, 
                            metricPropertyValueRequest)
                }
            );

            //    Create the portfolio
            var portfolioResult = _apiFactory.Api<ITransactionPortfoliosApi>().CreatePortfolio(TestDataUtilities.TutorialScope, createPortfolioRequest);
            
            Assert.That(portfolioResult.Id.Code, Is.EqualTo(createPortfolioRequest.Code));

            var portfolioProperties = _apiFactory.Api<IPortfoliosApi>().GetPortfolioProperties(TestDataUtilities.TutorialScope, portfolioResult.Id.Code).Properties;

            Assert.That(portfolioProperties.Keys, Is.EquivalentTo(new [] { metricPropertyDefinitionResult.Key}));

            // metricProperty.Value is just the value from the metric property, metricProperty.Unit is the units
            var metricProperty = portfolioProperties[metricPropertyDefinitionResult.Key];
            Assert.That(metricProperty.Value.MetricValue.Value, Is.EqualTo(metricPropertyValueRequest.MetricValue.Value));
            Assert.That(metricProperty.Value.MetricValue.Unit, Is.EqualTo(metricPropertyValueRequest.MetricValue.Unit));
        }
        
        [LusidFeature("F35")]
        [Test]
        public void Create_Portfolio_With_MultiValue_Property()
        {
            var uuid = Guid.NewGuid().ToString();
            var propertyName = $"managers-{uuid}";
            var effectiveDate = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);
            
            //    Details of the property to be created
            var multiValuePropertyDefinition = new CreatePropertyDefinitionRequest(
                
                //    The domain the property is to be applied to
                domain: CreatePropertyDefinitionRequest.DomainEnum.Portfolio,
                
                //    The scope the property will be created in
                scope: TestDataUtilities.TutorialScope,
                
                //    When the property value is set it will be valid forever and cannot be changed.
                //    Properties whose values can change over time should be created with LifeTimeEnum.TIMEVARIANT
                lifeTime: CreatePropertyDefinitionRequest.LifeTimeEnum.Perpetual,
                
                // Multi-value properties have constraint style "Collection"
                constraintStyle: "Collection",
                
                code: propertyName,
                valueRequired: false,
                displayName: "Managers",
                dataTypeId: new ResourceId("system", "string")
            );
            
            //    Create the property definitions
            var propertyDefinitionResult = _apiFactory.Api<IPropertyDefinitionsApi>().CreatePropertyDefinition(multiValuePropertyDefinition);
            
            //    Create the property values
            var propertyValue = CreateLabelSet("PortfolioManager1","PortfolioManager2");
            
            //    Details of the new portfolio to be created, created here with the minimum set of mandatory fields 
            var createPortfolioRequest = new CreateTransactionPortfolioRequest(
                code: $"id-{uuid}",
                displayName: $"Portfolio-{uuid}",
                baseCurrency: "GBP",
                created: effectiveDate
            );

            //    Create the portfolio
            var portfolioResult = _apiFactory.Api<ITransactionPortfoliosApi>().CreatePortfolio(TestDataUtilities.TutorialScope, createPortfolioRequest);
            
            Assert.That(portfolioResult.Id.Code, Is.EqualTo(createPortfolioRequest.Code));
            
            var propertiesUpsertResult = _apiFactory.Api<IPortfoliosApi>().UpsertPortfolioProperties(
                TestDataUtilities.TutorialScope,
                portfolioResult.Id.Code,
                new Dictionary<string, Property>
                {
                    [propertyDefinitionResult.Key] = 
                        new Property(
                            propertyDefinitionResult.Key, 
                            propertyValue)
                }
            );
            Assert.That(propertiesUpsertResult.Properties.Values.Single().Value.LabelValueSet, Is.EqualTo(propertyValue.LabelValueSet).Using(LabelValueSetEquality));

            var portfolioProperties = _apiFactory.Api<IPortfoliosApi>().GetPortfolioProperties(TestDataUtilities.TutorialScope, portfolioResult.Id.Code).Properties;

            Assert.That(portfolioProperties.Keys, Is.EquivalentTo(new [] { propertyDefinitionResult.Key}));

            var returnedProperty = portfolioProperties[propertyDefinitionResult.Key];
            Assert.That(returnedProperty.Value, Is.EqualTo(propertyValue).Using(PropertyValueEquality));
        }
    }
}
