using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Lusid.Sdk.Api;
using Lusid.Sdk.Model;
using Lusid.Sdk.Tests.Utilities;
using Lusid.Sdk.Utilities;
using NUnit.Framework;

namespace Lusid.Sdk.Tests.Tutorials.Ibor
{
    [TestFixture]
    public class CutLabels
    {
        // Might need more imports?
        private ILusidApiFactory _apiFactory;
        private ITransactionPortfoliosApi _transactionPortfoliosApi;
        private TestDataUtilities _testDataUtilities;
        private TestDataUtilities.TestDataUtilitiesTests _testDataUtilitiesTests;
        private InstrumentLoader _instrumentLoader;
        private IList<string> _instrumentIds;
        private ICutLabelDefinitionsApi _cutLabels;

        //    This defines the scope that entities will be created in
        private const string TutorialScope = "Testdemo";
        
        [OneTimeSetUp]
        public void SetUp()
        {
            _apiFactory = LusidApiFactoryBuilder.Build("secrets.json");
            _transactionPortfoliosApi = _apiFactory.Api<ITransactionPortfoliosApi>();

            _instrumentLoader = new InstrumentLoader(_apiFactory);
            _instrumentIds = _instrumentLoader.LoadInstruments();

            _testDataUtilities = new TestDataUtilities(_apiFactory.Api<ITransactionPortfoliosApi>());
            _testDataUtilitiesTests = new TestDataUtilities.TestDataUtilitiesTests();

            _cutLabels = _apiFactory.Api<ICutLabelDefinitionsApi>();

        }

        [Test]
        public void Test_Cut_Labels()
        {
            string GetGuid()
            {
                return Guid.NewGuid().ToString().Substring(0, 4);
            }

            // define function to format cut labels
            string CutLabelFormatter(DateTimeOffset date, DateTimeOrCutLabel cut_label_code)
            {
                return date.ToString("yyyy-MM-dd") + "N" + cut_label_code;
            }

            // Create cut labels
            // Create dictionary to keep track of cut labels
            IDictionary<string, string> code = new Dictionary<string, string>();

            void CreateCutLabel(
                int hours,
                int minutes,
                string displayName,
                string description,
                string timeZone,
                IDictionary<string, string> codeDict)
            {
                // Create time for the cut label
                CutLocalTime time = new CutLocalTime(hours, minutes);

                // Define parameters of cut label in a request
                var request = new CreateCutLabelDefinitionRequest(
                    displayName + "-" + GetGuid(),
                    displayName,
                    description,
                    time,
                    timeZone);

                // Add codes of our cut labels to our dictionary
                codeDict.Add(request.DisplayName, request.Code);

                // Send request to LUSID to create cut label
                var result = _cutLabels.CreateCutLabelDefinition(request);

                Assert.That(result.DisplayName, Is.EqualTo(displayName), "Display name has changed when attempting to create cut label.");
                Assert.That(result.Description, Is.EqualTo(description), "Description has changed when attempting to create cut label.");
                Assert.That(result.CutLocalTime, Is.EqualTo(time), "Local Time has changed when attempting to create cut label.");
                Assert.That(result.TimeZone, Is.EqualTo(timeZone), "Timezone has changed when attempting to create cut label.");
            }

            // Create cut labels for different time zones
            CreateCutLabel(9, 0, "LondonOpen", "London Opening Time, 9am in UK", "GB", code);
            CreateCutLabel(17, 0, "LondonClose", "London Closing Time, 5pm in UK", "GB", code);
            CreateCutLabel(9, 0, "SingaporeOpen", "", "Singapore", code);
            CreateCutLabel(17, 0, "SingaporeClose", "", "Singapore", code);
            CreateCutLabel(9, 0, "NYOpen", "", "America/New_York", code);
            CreateCutLabel(17, 0, "NYClose", "", "America/New_York", code);

            
            // Create portfolio
            var portfolioCode = _testDataUtilities.CreateTransactionPortfolio(TutorialScope);


            // Get instrument identifiers
            var instrument1 = _instrumentIds[0];
            var instrument2 = _instrumentIds[1];
            var instrument3 = _instrumentIds[2];

            const string currency = "GBP";

            // set a currency LUID, as the call to GetHoldings returns the LUID not the identifier we are about to create
            var currencyLuid = $"CCY_{currency}";

            // Set initial holdings for each instrument from LondonOpen 5 days ago
            var initialHoldingsCutLabel =
                CutLabelFormatter(DateTimeOffset.Now.Subtract(TimeSpan.FromDays(5)), code["LondonOpen"]);
            var initialHoldings = new List<AdjustHoldingRequest> { 
                _testDataUtilities.BuildCashFundsInAdjustHoldingsRequest(100000.0, currency),
                _testDataUtilities.BuildAdjustHoldingsRequest(
                    instrument1,
                    100.0,
                    101.0,
                    currency),
                _testDataUtilities.BuildAdjustHoldingsRequest(
                    instrument2,
                    100.0,
                    102.0,
                    currency),
                _testDataUtilities.BuildAdjustHoldingsRequest(
                    instrument3,
                    100.0,
                    99.0,
                    currency)
            };
            // add initial holdings to our portfolio from LondonOpen 5 days ago
            _transactionPortfoliosApi.SetHoldings(
                TutorialScope,
                portfolioCode,
                initialHoldingsCutLabel,
                initialHoldings);

            // Check initial holdings
            // get initial holdings at LondonOpen today, before transactions occur
            var getHoldingsCutLabel = CutLabelFormatter(DateTimeOffset.UtcNow, code["LondonOpen"]); // changed to utcnow instead of now, or use new DateTimeOffset(y, m d)
            var holdings = _transactionPortfoliosApi.GetHoldings(
                TutorialScope,
                portfolioCode,
                effectiveAt: getHoldingsCutLabel);
            // check that holdings are as expected before transactions occur for each instrument
            holdings.Values.Sort((h1, h2) => String.Compare(h1.InstrumentUid, h2.InstrumentUid, StringComparison.Ordinal));
            Assert.That(holdings.Values.Count, Is.EqualTo(4));
            _testDataUtilitiesTests.AssertCashHoldings(
                holdings,
                0,
                currencyLuid,
                100000.0);
            _testDataUtilitiesTests.AssertHoldings(
                holdings,
                1,
                instrument1,
                100.0,
                10100.0);
            _testDataUtilitiesTests.AssertHoldings(
                holdings,
                2,
                instrument2,
                100.0,
                10200.0);
            _testDataUtilitiesTests.AssertHoldings(
                holdings,
                3,
                instrument3,
                100.0,
                9900.0);


            // Add transactions at different times in different time zones during the day with cut labels
            var transaction1CutLabel = CutLabelFormatter(DateTimeOffset.Now, code["LondonOpen"]);
            var transaction2CutLabel = CutLabelFormatter(DateTimeOffset.Now, code["SingaporeClose"]);
            var transaction3CutLabel = CutLabelFormatter(DateTimeOffset.Now, code["NYOpen"]);
            var transaction4CutLabel = CutLabelFormatter(DateTimeOffset.Now, code["NYClose"]);
            var transactions = new List<TransactionRequest>
            {
                _testDataUtilities.BuildTransactionRequest(
                    instrument1,
                    100.0,
                    100.0,
                    currency,
                    transaction1CutLabel,
                    "Buy"),
                _testDataUtilities.BuildTransactionRequest(
                    instrument2,
                    100.0,
                    100.0,
                    currency,
                    transaction2CutLabel,
                    "Buy"),
                _testDataUtilities.BuildTransactionRequest(
                    instrument3,
                    100.0,
                    100.0,
                    currency,
                    transaction3CutLabel,
                    "Buy"),
                _testDataUtilities.BuildTransactionRequest(
                    instrument1,
                    100.0,
                    100.0,
                    currency,
                    transaction4CutLabel,
                    "Buy"),
            };
            // Add transactions to the portfolio
            _transactionPortfoliosApi.UpsertTransactions(
                TutorialScope,
                portfolioCode,
                transactions);

            // Retrieve holdings at LondonClose today (5pm local time)
            // This will mean that the 4th transaction will not be included, demonstrating how cut labels work across time zones
            getHoldingsCutLabel = CutLabelFormatter(DateTimeOffset.Now, code["LondonClose"]);
            holdings = _transactionPortfoliosApi.GetHoldings(
                TutorialScope,
                portfolioCode,
                effectiveAt: getHoldingsCutLabel);

            // check that holdings are as expected after transactions for each instrument
            holdings.Values.Sort((h1, h2) => String.Compare(h1.InstrumentUid, h2.InstrumentUid, StringComparison.Ordinal));
            Assert.That(holdings.Values.Count, Is.EqualTo(4));
            _testDataUtilitiesTests.AssertCashHoldings(
                holdings,
                0,
                currencyLuid,
                70000.0);
            _testDataUtilitiesTests.AssertHoldings(
                holdings,
                1,
                instrument1,
                200.0,
                20100.0);
            _testDataUtilitiesTests.AssertHoldings(
                holdings,
                2,
                instrument2,
                200.0,
                20200.0);
            _testDataUtilitiesTests.AssertHoldings(
                holdings,
                3,
                instrument3,
                200.0,
                19900.0);
        }
    }
}