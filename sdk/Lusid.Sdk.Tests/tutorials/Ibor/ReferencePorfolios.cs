using System;
using System.Collections.Generic;
using System.Linq;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Tests.Utilities;
using Lusid.Sdk.Utilities;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Tutorials.Ibor
{

    [TestFixture]
    public class ReferencePortfolioTests
    {
        private ILusidApiFactory _apiFactory;
        private IList<string> _instrumentIds;

        //  This defines the scope that entities will be created in the test
        private readonly string PorfolioCode = $"MyPort-{Guid.NewGuid().ToString()}";
        const string TutorialScope = "Testdemo1";

        [OneTimeSetUp]
        public void SetUp()
        {
            //  Initialise the API factory
            _apiFactory = LusidApiFactoryBuilder.Build("secrets.json");

            // Load default instruments which will be used in the tests
            var instrumentsLoader = new InstrumentLoader(_apiFactory);
            _instrumentIds = instrumentsLoader.LoadInstruments().OrderBy(x => x).ToList();
        }

        [Test]
        public void CreateReferencePortfolio()
        {
            //  Create date for the portfolio
            var createDate = new DateTimeOffset(2000, 1, 1, 0, 0, 0, TimeSpan.Zero);

            //  Details of the new reference portfolio to be created
            var request = new CreateReferencePortfolioRequest(

                //  Unique portfolio code, portfolio codes must be unique across scopes
                code: PorfolioCode,

                //  Descriptive name for the portfolio
                displayName: $"Portfolio-{PorfolioCode}",

                //  Create date for the below. We can only upsert constituents after this date.
                created: createDate

            );

            //  Create the reference portfolio in LUSID
            var ReferencePortfolio = _apiFactory.Api<IReferencePortfolioApi>().CreateReferencePortfolio(TutorialScope, request);

            //  Confirm that the portfolio was successfully created.  Any failures will result in
            //  a ApiException being thrown which contain the relevant response code and error message
            Assert.That(ReferencePortfolio.Id.Code, Is.EqualTo(request.Code));
        }

        [Test]
        public void SetConstituents()
        {
            // Declare some instruments which we loaded earlier
            var instrument1 = _instrumentIds[0];
            var instrument2 = _instrumentIds[1];
            var instrument3 = _instrumentIds[2];

            // Set date for the constituents, the date from which the constituents are valid
            var date = new DateTimeOffset(2020, 1, 1, 0, 0, 0, TimeSpan.Zero);

            // Weighting type
            var weighting = UpsertReferencePortfolioConstituentsRequest.WeightTypeEnum.Static;

            // Create the request to upsert constituents
            var upsertConstituentsRequest = new UpsertReferencePortfolioConstituentsRequest(

                effectiveFrom: date,
                weightType: weighting,
                constituents: new List<ReferencePortfolioConstituentRequest>
                {

                    new ReferencePortfolioConstituentRequest(
                        instrumentIdentifiers: new Dictionary<string, string> { [TestDataUtilities.LusidCashIdentifier] = "GBP"},
                        weight: 10,
                        currency: "GBP"
                    ),

                    new ReferencePortfolioConstituentRequest(
                        instrumentIdentifiers: new Dictionary<string, string> {[TestDataUtilities.LusidInstrumentIdentifier] = instrument1},
                        weight: 20,
                        currency: "GBP"
                    ),
                     new ReferencePortfolioConstituentRequest(
                        instrumentIdentifiers: new Dictionary<string, string> {[TestDataUtilities.LusidInstrumentIdentifier] = instrument2},
                        weight: 30,
                        currency: "GBP"
                    ),

                     new ReferencePortfolioConstituentRequest(
                        instrumentIdentifiers: new Dictionary<string, string> {[TestDataUtilities.LusidInstrumentIdentifier] = instrument3},
                        weight: 40,
                        currency: "GBP"
                    ),
                }
            );
            // Upsert the constituents into LUSID
            var setConstituents = _apiFactory.Api<IReferencePortfolioApi>().UpsertReferencePortfolioConstituents(TutorialScope, PorfolioCode, upsertConstituentsRequest);

            var constituentHoldings = _apiFactory.Api<IReferencePortfolioApi>().GetReferencePortfolioConstituents(TutorialScope, PorfolioCode, date);

            // Check the count of holdings
            Assert.That(constituentHoldings.Constituents.Count(), Is.EqualTo(4));

            // Check the instruments on the holdings
            constituentHoldings.Constituents.Sort((h1, h2) => String.Compare(h1.InstrumentUid, h2.InstrumentUid, StringComparison.Ordinal));
            Assert.That(constituentHoldings.Constituents[1].InstrumentUid, Is.EqualTo(_instrumentIds[0]));
            Assert.That(constituentHoldings.Constituents[2].InstrumentUid, Is.EqualTo(_instrumentIds[1]));
            Assert.That(constituentHoldings.Constituents[3].InstrumentUid, Is.EqualTo(_instrumentIds[2]));

            //  Validate the holding weights
            Assert.That(constituentHoldings.Constituents[0].Weight, Is.EqualTo(10));
            Assert.That(constituentHoldings.Constituents[1].Weight, Is.EqualTo(20));
            Assert.That(constituentHoldings.Constituents[2].Weight, Is.EqualTo(30));
            Assert.That(constituentHoldings.Constituents[3].Weight, Is.EqualTo(40));
        }
    }
}
