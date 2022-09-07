using System;
using System.Collections.Generic;
using System.Linq;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Utilities;
using NUnit.Framework;

namespace Lusid.Sdk.Tests
{
    public class InstrumentLoader
    {
        private readonly ILusidApiFactory _apiFactory;

        public InstrumentLoader(ILusidApiFactory apiFactory)
        {
            _apiFactory = apiFactory ?? throw new ArgumentNullException(nameof(apiFactory));
        }

        public IList<string> LoadInstruments()
        {
            var instruments = new List<(string Figi, string Name)>
            {
                (Figi: "BBG000C6K6G9", Name: "VODAFONE GROUP PLC"),
                (Figi: "BBG000C04D57", Name: "BARCLAYS PLC"),
                (Figi: "BBG000FV67Q4", Name: "NATIONAL GRID PLC"),
                (Figi: "BBG000BF0KW3", Name: "SAINSBURY (J) PLC"),
                (Figi: "BBG000BF4KL1", Name: "TAYLOR WIMPEY PLC")
            };            

            var upsertResponse = _apiFactory.Api<IInstrumentsApi>().UpsertInstruments(instruments.ToDictionary(
                k => k.Figi,
                v => new InstrumentDefinition(
                    name: v.Name,
                    identifiers: new Dictionary<string, InstrumentIdValue> {["Figi"] = new InstrumentIdValue(v.Figi) }
                )
            ));
            
            Assert.That(upsertResponse.Failed.Count, Is.EqualTo(0));
            
            var ids = _apiFactory.Api<IInstrumentsApi>().GetInstruments("Figi", instruments.Select(i => i.Figi).ToList());

            return ids.Values.Select(x => x.Value.LusidInstrumentId).OrderBy(i => i).ToList();
        }

        public void DeleteInstruments()
        {
            var instruments = new List<string>
            {
                "BBG000C6K6G9",
                "BBG000C04D57",
                 "BBG000FV67Q4",
                "BBG000BF0KW3",
                "BBG000BF4KL1",
            };

            foreach (var instrument in instruments)
            {
                _apiFactory.Api<IInstrumentsApi>().DeleteInstrument("Figi", instrument);
            }
        }
    }
}