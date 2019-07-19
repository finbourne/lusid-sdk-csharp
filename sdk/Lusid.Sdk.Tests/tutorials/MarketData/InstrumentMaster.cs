using System.Collections.Generic;
using System.Linq;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Utilities;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Tutorials.MarketData
{
    [TestFixture]
    public class InstrumentMaster
    {
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
            var factory = LusidApiFactoryBuilder.Build("secrets.json");
            _instrumentsApi = factory.Api<IInstrumentsApi>();

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
    }
}