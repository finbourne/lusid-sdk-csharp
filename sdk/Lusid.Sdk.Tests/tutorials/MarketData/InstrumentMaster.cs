using System;
using System.Collections.Generic;
using System.Linq;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;
using Lusid.Sdk.Tests.Utilities;
using Lusid.Sdk.Utilities;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Tutorials.MarketData
{
    [TestFixture]
    public class InstrumentMaster
    {
        private ILusidApiFactory _apiFactory;
        private IInstrumentsApi _instrumentsApi;
        
        private const string FigiScheme = "Figi";
        private const string CustomInternalScheme = "ClientInternal";
        private const string IsinScheme = "Isin";
        private const string SedolScheme = "Sedol";
        
        private const string IsinPropertyKey = "Instrument/default/Isin";
        private const string SedolPropertyKey = "Instrument/default/Sedol";
        private const string FigiPropertyKey = "Instrument/default/Figi";
            
        [OneTimeSetUp]
        public void SetUp()
        {
            _apiFactory = LusidApiFactoryBuilder.Build("secrets.json");
            _instrumentsApi = _apiFactory.Api<IInstrumentsApi>();

            EnsurePropertyDefinition("CustomSector");
            SeedInstrumentMaster();
        }

        private void SeedInstrumentMaster()
        {
            var upsertInstrumentsResponse = _instrumentsApi.UpsertInstruments(new Dictionary<string, InstrumentDefinition>
            {
                ["correlationId1"] = new InstrumentDefinition(
                    name: "VODAFONE GROUP PLC", 
                    
                    /*
                        Instruments are created with a set of identifiers
                        each under a different scheme
                     */
                    identifiers: new Dictionary<string, InstrumentIdValue>
                    {
                        [FigiScheme] = new InstrumentIdValue("BBG000C6K6G9"),
                        [CustomInternalScheme] = new InstrumentIdValue("INTERNAL_ID_1"),
                        [IsinScheme] = new InstrumentIdValue("GB00BH4HKS39"),
                        [SedolScheme] = new InstrumentIdValue("BH4HKS3")
                    }
                 ),
                
                ["correlationId2"] = new InstrumentDefinition(
                    name: "BARCLAYS PLC", 
                    
                    /*
                        Instruments are created with a set of identifiers
                        each under a different scheme
                     */
                    identifiers: new Dictionary<string, InstrumentIdValue>
                    {
                        [FigiScheme] = new InstrumentIdValue("BBG000C04D57"),
                        [CustomInternalScheme] = new InstrumentIdValue("INTERNAL_ID_2"),
                        [IsinScheme] = new InstrumentIdValue("GB0031348658"),
                        [SedolScheme] = new InstrumentIdValue("3134865")
                    }
                ),
                
                ["correlationId3"] = new InstrumentDefinition(
                    name: "NATIONAL GRID PLC", 
                    
                    /*
                        Instruments are created with a set of identifiers
                        each under a different scheme
                     */
                    identifiers: new Dictionary<string, InstrumentIdValue>
                    {
                        [FigiScheme] = new InstrumentIdValue("BBG000FV67Q4"),
                        [CustomInternalScheme] = new InstrumentIdValue("INTERNAL_ID_3"),
                        [IsinScheme] = new InstrumentIdValue("GB00BDR05C01"),
                        [SedolScheme] = new InstrumentIdValue("BDR05C0")
                    }
                ),
                
                ["correlationId4"] = new InstrumentDefinition(
                    name: "SAINSBURY (J) PLC", 
                    
                    /*
                        Instruments are created with a set of identifiers
                        each under a different scheme
                     */
                    identifiers: new Dictionary<string, InstrumentIdValue>
                    {
                        [FigiScheme] = new InstrumentIdValue("BBG000BF0KW3"),
                        [CustomInternalScheme] = new InstrumentIdValue("INTERNAL_ID_4"),
                        [IsinScheme] = new InstrumentIdValue("GB00B019KW72"),
                        [SedolScheme] = new InstrumentIdValue("B019KW7")
                    }
                ),
                
                ["correlationId5"] = new InstrumentDefinition(
                    name: "TAYLOR WIMPEY PLC", 
                    
                    /*
                        Instruments are created with a set of identifiers
                        each under a different scheme
                     */
                    identifiers: new Dictionary<string, InstrumentIdValue>
                    {
                        [FigiScheme] = new InstrumentIdValue("BBG000BF4KL1"),
                        [CustomInternalScheme] = new InstrumentIdValue("INTERNAL_ID_5"),
                        [IsinScheme] = new InstrumentIdValue("GB0008782301"),
                        [SedolScheme] = new InstrumentIdValue("0878230")
                    }
                )
            });
            
            Assert.That(upsertInstrumentsResponse.Values, Has.Count.EqualTo(5));
        }        

        [Test]
        public void Lookup_Instrument_By_Unique_Id()
        {
            /*
                Look up an instrument that already exists in the instrument master by a
                unique id, in this case an OpenFigi, and also return a list of aliases
            */

            var lookedUpInstruments = _instrumentsApi.GetInstruments(
                FigiScheme, 
                new List<string> {"BBG000C6K6G9"},
                instrumentPropertyKeys: new List<string> {IsinPropertyKey, SedolPropertyKey});
            
            Assert.That(lookedUpInstruments.Values, Contains.Key("BBG000C6K6G9"));

            var instrument = lookedUpInstruments.Values["BBG000C6K6G9"];
            
            Assert.That(instrument.Name, Is.EqualTo("VODAFONE GROUP PLC"));

            var identifiers = instrument.Properties.OrderBy(i => i.Key).ToList();
            
            Assert.That(identifiers[0].Key, Is.EqualTo(IsinPropertyKey));
            Assert.That(identifiers[0].Value.LabelValue, Is.EqualTo("GB00BH4HKS39"));
            Assert.That(identifiers[1].Key, Is.EqualTo(SedolPropertyKey));
            Assert.That(identifiers[1].Value.LabelValue, Is.EqualTo("BH4HKS3"));
        }
        
        private void EnsurePropertyDefinition(string code)
        {
            var propertyApi = _apiFactory.Api<IPropertyDefinitionsApi>();
                
            try
            {
                propertyApi.GetPropertyDefinition("Instrument", TestDataUtilities.TutorialScope, code);
            }
            catch (ApiException)
            {
                //    Property definition doesn't exist (returns 404), so create one
                //    Details of the property to be created
                var propertyDefinition = new CreatePropertyDefinitionRequest(
                    domain: CreatePropertyDefinitionRequest.DomainEnum.Instrument,
                    scope: TestDataUtilities.TutorialScope,
                    lifeTime: CreatePropertyDefinitionRequest.LifeTimeEnum.Perpetual,
                    code: code,
                    valueRequired: false,
                    displayName: code,
                    dataTypeId: new ResourceId("system", "string")
                );

                //    Create the property
                propertyApi.CreatePropertyDefinition(propertyDefinition);
            }
        }

        [Test]
        public void List_Available_Identifiers()
        {
            //    Get the list of identifier schemes
            ResourceListOfInstrumentIdTypeDescriptor identifiers = _instrumentsApi.GetInstrumentIdentifiers();

            //    Schemes are returned as descriptors containing the name, property key and uniqueness constraint
            foreach (InstrumentIdTypeDescriptor scheme in identifiers.Values)
            {
                Console.WriteLine($"name: {scheme.IdName}\nproperty key: {scheme.PropertyKeyValue}\nis unique: {scheme.IsUniqueIdentifier}\n");
            }
        }

        [Test]
        public void List_All_Instruments()
        {
            const int pageSize = 5;
            
            //    List the instruments restricting, the number that are returned
            var instruments = _instrumentsApi.ListInstruments(limit: pageSize);
            
            Assert.That(instruments.Values.Count(), Is.LessThanOrEqualTo(pageSize));
        }

        [Test]
        public void List_Instruments_By_Identifier_Type()
        {
            var figis = new List<string>
            {
                "BBG00M1BQWX0", "BBG00D1PBRL9", "BBG00BW1V2M4"
            };
            
            //    Get a set of instruments querying by FIGIs
            var instruments = _instrumentsApi.GetInstruments(identifierType: "Figi", identifiers: figis);

            foreach (var figi in figis)
            {
                Assert.That(instruments.Values, Contains.Key(figi));
            }
        }

        [Test]
        public void Edit_Instrument_Property()
        {
            //    Create the property value
            var propertyValue = new PropertyValue(labelValue: "Telecoms");
            var propertyKey = $"Instrument/{TestDataUtilities.TutorialScope}/CustomSector";
            
            //    Get the LusidInstrumentId (LUID)
            var instrument = _instrumentsApi.GetInstrument("Figi", "BBG00M1BQWX0");

            //    Add it to the instrument
            _instrumentsApi.UpsertInstrumentsProperties(new List<UpsertInstrumentPropertyRequest>
            {
                new UpsertInstrumentPropertyRequest(
                    lusidInstrumentId: instrument.LusidInstrumentId,
                    properties: new List<Property>
                    {
                        new Property(propertyKey, propertyValue)
                    }
                )
            });
            
            //    Get the instrument with value
            instrument = _instrumentsApi.GetInstrument(
                identifierType: "LusidInstrumentId",
                identifier: instrument.LusidInstrumentId,
                instrumentPropertyKeys: new List<string> { propertyKey }
            );

            Assert.That(
                instrument.Properties.FirstOrDefault(p => p.Key == propertyKey && p.Value.LabelValue.Equals("Telecoms")),
                Is.Not.Null, $"Cannot find property {propertyKey} with value {propertyValue.LabelValue}");
        }

        [Test]
        public void Create_Custom_Instrument()
        {
            //    Create a definition for the instrument
            var swapDefinition = new InstrumentDefinition(
                name: "10mm 5Y Fixed",
                
                //  The set of identifiers used for identifying the instrument
                //  e.g. for uploading transactions
                identifiers: new Dictionary<string, InstrumentIdValue>
                {
                    ["ClientInternal"] = new InstrumentIdValue(value: "SW-1")
                },
                
                //  The details for valuing the instrument
                definition: new InstrumentEconomicDefinition(
                    
                    //  Identifies which valuation engine to use
                    instrumentFormat: "CustomFormat",
                    content: "<customFormat>upload in custom xml or JSON format</customFormat>"
                ));
            
            //    create the swap
            var createSwapResponse = _instrumentsApi.UpsertInstruments(new Dictionary<string, InstrumentDefinition>
            {
                ["correlationId"] = swapDefinition
            });
            
            Assert.That(createSwapResponse.Failed, Is.Empty);
        }

    }
}