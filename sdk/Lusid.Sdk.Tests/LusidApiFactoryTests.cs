using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;
using Lusid.Sdk.Tests.Utilities;
using Lusid.Sdk.Utilities;
using Newtonsoft.Json;
using NUnit.Framework;
using System.Net;

namespace Lusid.Sdk.Tests
{
    [TestFixture]
    public class LusidApiFactoryTests
    {
        private ILusidApiFactory _factory;
        private const string RequestIdRegexPattern = "[a-zA-Z0-9]{13}:[0-9a-fA-F]{8}";
        

        [OneTimeSetUp]
        public void SetUp()
        {
            _factory = TestLusidApiFactoryBuilder.CreateApiFactory("secrets.json");
        }

        [Test]
        public void Create_PortfoliosApi()
        {
            var api = _factory.Api<PortfoliosApi>();
            
            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<PortfoliosApi>());
        }
        
        [Test]
        public void Create_TransactionPortfoliosApi()
        {
            var api = _factory.Api<TransactionPortfoliosApi>();
            
            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<TransactionPortfoliosApi>());
        }

        class InvalidApi : IApiAccessor
        {
            public IReadableConfiguration Configuration { get; set; }
            public string GetBasePath()
            {
                throw new NotImplementedException();
            }

            public ExceptionFactory ExceptionFactory { get; set; }
        }
        
        [Test]
        public void Invalid_Requested_Api_Throws()
        {
            Assert.That(() => _factory.Api<InvalidApi>(), Throws.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Api_From_Interface()
        {
            var api = _factory.Api<ITransactionPortfoliosApi>();
            
            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<TransactionPortfoliosApi>());
        }

        [Test]
        public void Api_From_Implementation()
        {
            var api = _factory.Api<TransactionPortfoliosApi>();
            
            Assert.That(api, Is.Not.Null);
            Assert.That(api, Is.InstanceOf<TransactionPortfoliosApi>());
        }

        [Test]
        public void InvalidTokenUrl_ThrowsException()
        {
            ApiConfiguration apiConfig = new ApiConfiguration
            {
                TokenUrl = "xyz",
                ApiUrl = "http://abc" // api uri is checked first and must pass
            };

            Assert.That(
                () => new LusidApiFactory(apiConfig),
                Throws.InstanceOf<UriFormatException>().With.Message.EqualTo("Invalid Token Uri: xyz"));
        }

        [Test]
        public void InvalidApiUrl_ThrowsException()
        {
            ApiConfiguration apiConfig = new ApiConfiguration
            {
                TokenUrl = "http://finbourne.com",
                ApiUrl = "xyz"
            };

            Assert.That(
                () => new LusidApiFactory(apiConfig),
                Throws.InstanceOf<UriFormatException>().With.Message.EqualTo("Invalid LUSID Uri: xyz"));
        }

        [Test]
        public void NetworkConnectivityErrors_ThrowsException()
        {
            var apiConfig = ApiConfigurationBuilder.Build("secrets.json");
            apiConfig.ApiUrl = "https://localhost:56789/api"; // nothing should be listening on this, so we should get a "No connection could be made" error...

            var factory = new LusidApiFactory(apiConfig);
            var api = factory.Api<PortfoliosApi>();

            // Can't be more specific as we get different exceptions locally vs in the build pipeline
            var expectedMsg = "Internal SDK error occurred when calling GetPortfolio";
            
            Assert.That(
                () => api.GetPortfolioWithHttpInfo("someScope", "someCode"),
                Throws.InstanceOf<ApiException>()
                    .With.Message.Contains(expectedMsg));

            // Note: these non-"WithHttpInfo" methods just unwrap the `Data` property from the call above.
            // But these were the problematic ones, as they would previously just return a null value in this scenario.
            Assert.That(
                () => api.GetPortfolio("someScope", "someCode"),
                Throws.InstanceOf<ApiException>()
                    .With.Message.Contains(expectedMsg)); 
        }

        [Test]
        public void ApiResponse_CanExtract_RequestId()
        {
            var apiResponse = _factory.Api<ApplicationMetadataApi>().GetLusidVersionsWithHttpInfo();
            var requestId = apiResponse.GetRequestId();
            StringAssert.IsMatch(RequestIdRegexPattern, requestId);
        }
        
        [Test]
        public void ApiResponseMissingHeader_ReturnsNull_RequestId()
        {
            var apiResponse = _factory.Api<ApplicationMetadataApi>().GetLusidVersionsWithHttpInfo();
            // Remove header containing access token
            apiResponse.Headers.Remove(ApiResponseExtensions.RequestIdHeader);
            var requestId = apiResponse.GetRequestId();
            Assert.That(requestId, Is.Null);
        }
        
        [Test]
        public void ApiException_CanExtract_RequestId()
        {
            try
            {
                var _ = _factory.Api<PortfoliosApi>().GetPortfolio("doesnt", "exist");
            }
            catch (ApiException e)
            {
                var requestId = e.GetRequestId();
                StringAssert.IsMatch(RequestIdRegexPattern, requestId);
            } 
        }
        
        [Test]
        public void ApiException_WhenExceptionDoesNotContainRequestId_DoesNotThrow()
        {
            var exception = new ApiException(
                errorCode: 123,
                message: "Some Critical Exception",
                errorContent: JsonConvert.SerializeObject(new LusidProblemDetails(name: "CriticalException")));

            Assert.That(exception.GetRequestId(), Is.Null);
        }
        
        [Test]
        public void ApiException_WhenErrorContentIsNotAValidJson_DoesNotThrow()
        {
            const string errorContent = "<Some Invalid Json>";
            var exception = new ApiException(
                errorCode: 123,
                message: "Some Critical Exception",
                errorContent: errorContent);

            Assert.That(exception.GetRequestId(), Is.Null);
            Assert.That(exception.ProblemDetails(), Is.Null);
        }
        
        [Test]
        public void ApiExceptionMalformedInsightsUrl_ReturnsNull_RequestId()
        {
            try
            {
                var _ = _factory.Api<PortfoliosApi>().GetPortfolio("doesnt", "exist");
            }
            catch (ApiException e)
            {
                var problemDetails = e.ProblemDetails();
                
                // Remove the InsightsURL which contains the requestId
                problemDetails.Instance = "";
                
                var apiExceptionMalformed = new ApiException(
                    errorCode: e.ErrorCode,
                    message: e.Message,
                    errorContent: JsonConvert.SerializeObject(problemDetails));

                var requestId = apiExceptionMalformed.GetRequestId();
                Assert.That(requestId, Is.Null);
            } 
        }
        
        [Test]
        public void ApiException_Converts_To_ProblemDetails()
        {
            try
            {
                var _ = _factory.Api<PortfoliosApi>().GetPortfolio("doesnt", "exist");
            }
            catch (ApiException e)
            {
                //    ApiException.ErrorContent contains a JSON serialized ErrorResponse
                LusidProblemDetails errorResponse = e.ProblemDetails();
                
                Assert.That(errorResponse.Detail, Does.Match("Portfolio with id 'exist' in scope 'doesnt' effective.*not found"));
                Assert.That(errorResponse.Name, Is.EqualTo("PortfolioNotFound"));
            }            
        }
        
        [Test]
        public void ApiException_Converts_To_ValidationProblemDetails_AllowedRegex()
        {
            try
            {
                var _ = _factory.Api<PortfoliosApi>().GetPortfolio("@£$@£%", "@@@@@@");
            }
            catch (ApiException e)
            {
                Assert.That(e.IsValidationProblem, Is.True, "Response should indicate that there was a validation error with the request");
                
                //    An ApiException.ErrorContent thrown because of a request validation contains a JSON serialized LusidValidationProblemDetails
                if (e.TryGetValidationProblemDetails(out var errorResponse))
                {
                    //Should identify that there was a validation error with the code
                    Assert.That(errorResponse.Errors, Contains.Key("code"));
                    Assert.That(errorResponse.Errors["code"].Single(), Is.EqualTo("Values for the field code must be comprised of either alphanumeric characters, hyphens or underscores. For more information please consult the documentation."));
                    
                    //Should identify that there was a validation error with the scope
                    Assert.That(errorResponse.Errors, Contains.Key("scope"));
                    Assert.That(errorResponse.Errors["scope"].Single(), Is.EqualTo("Values for the field scope must be comprised of either alphanumeric characters, hyphens or underscores. For more information please consult the documentation."));
                
                    Assert.That(errorResponse.Detail, Does.Match("One or more elements of the request were invalid.*"));
                    Assert.That(errorResponse.Name, Is.EqualTo("InvalidRequestFailure"));
                }
                else
                {
                    Assert.Fail("The request should have failed due to a validation error, and the validation details should be returned");
                }
            }
        }
        
        [Test]
        public void ApiException_Converts_To_ValidationProblemDetails_MaxLength()
        {
            try
            {
                var testScope = new string('a', 100);
                var testCode = new string('b', 100);
                var _ = _factory.Api<PortfoliosApi>().GetPortfolio(testScope, testCode);
            }
            catch (ApiException e)
            {
                Assert.That(e.IsValidationProblem, Is.True, "Response should indicate that there was a validation error with the request");
                
                //    An ApiException.ErrorContent thrown because of a request validation contains a JSON serialized LusidValidationProblemDetails
                if (e.TryGetValidationProblemDetails(out var errorResponse))
                {
                    //Should identify that there was a validation error with the code
                    Assert.That(errorResponse.Errors, Contains.Key("code"));
                    Assert.That(errorResponse.Errors["code"].Single(), Is.EqualTo("Values for the field code must be non-zero in length and have no more than 64 characters. For more information please consult the documentation."));
                    
                    //Should identify that there was a validation error with the scope
                    Assert.That(errorResponse.Errors, Contains.Key("scope"));
                    Assert.That(errorResponse.Errors["scope"].Single(), Is.EqualTo("Values for the field scope must be non-zero in length and have no more than 64 characters. For more information please consult the documentation."));
                
                    Assert.That(errorResponse.Detail, Does.Match("One or more elements of the request were invalid.*"));
                    Assert.That(errorResponse.Name, Is.EqualTo("InvalidRequestFailure"));
                }
                else
                {
                    Assert.Fail("The request should have failed due to a validation error, and the validation details should be returned");
                }
            }
        }
        
        [Test]
        public void ApiException_Without_ErrorContent_Returns_Null()
        {
            var error = new ApiException();
            var errorResponse = error.ProblemDetails();
            
            Assert.That(errorResponse, Is.Null);
        }
        
        [Test]
        public void ApiException_Without_ErrorContent_Returns_NullRequestId()
        {
            var error = new ApiException();
            var errorResponse = error.GetRequestId();
            
            Assert.That(errorResponse, Is.Null);
        }
        
        [Test]
        public void ApiException_With_Empty_ErrorContent_Returns_Null()
        {
            var error = new ApiException();
            var errorResponse = error.ProblemDetails();
            
            Assert.That(errorResponse, Is.Null);
        }

        [TestCase(1, 10)]
        [TestCase(100, 25, Explicit = true)]
        public void Multi_Threaded_ApiFactory_Tasks(int quoteCount, int threadCount)
        {
            var config = TestLusidApiFactoryBuilder.CreateApiConfiguration("secrets.json");
            if (config.MissingSecretVariables)
            {
                Assert.Inconclusive();
            }

            var provider = new ClientCredentialsFlowTokenProvider(config);
            
            var date = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);

            var tasks = Enumerable.Range(0, threadCount).Select(x => Task.Run(() =>
            {
                var request = Enumerable.Range(0, quoteCount).Select(i => new UpsertQuoteRequest(
                    new QuoteId(
                        new QuoteSeriesId(
                            provider: "DataScope",
                            priceSource: $"Bank {x}",
                            instrumentId: "BBG000B9XRY4",
                            instrumentIdType: QuoteSeriesId.InstrumentIdTypeEnum.Figi,
                            quoteType: QuoteSeriesId.QuoteTypeEnum.Price,
                            field: "mid"),
                        effectiveAt: date.AddDays(i)),
                    metricValue: new MetricValue(
                        value: 199.23m,
                        unit: "USD"),
                    lineage: "InternalSystem")).ToDictionary(k => k.QuoteId.EffectiveAt.ToString(), v => v);
                
                var factory = LusidApiFactoryBuilder.Build(config.ApiUrl, provider);
                var result = factory.Api<IQuotesApi>().UpsertQuotes("mt-scope", request);
                Assert.That(result.Failed, Is.Empty);
            }));

            Task.WaitAll(tasks.ToArray());
        }

        [TestCase(1, 10)]
        [TestCase(100, 25, Explicit = true)]
        public void Multi_Threaded_ApiFactory_Tasks_With_PersonalAccessToken(int quoteCount, int threadCount)
        {
            var config = ApiConfigurationBuilder.Build(null);
            if (config.MissingPersonalAccessTokenVariables)
            {
                Assert.Inconclusive();
            }
            
            var provider = new PersonalAccessTokenProvider(config.PersonalAccessToken);

            var date = new DateTimeOffset(2018, 1, 1, 0, 0, 0, TimeSpan.Zero);

            var request = Enumerable.Range(0, quoteCount).Select(i => new UpsertQuoteRequest(
                new QuoteId(
                    new QuoteSeriesId(
                        provider: "DataScope",
                        priceSource: "BankA",
                        instrumentId: "BBG000B9XRY4",
                        instrumentIdType: QuoteSeriesId.InstrumentIdTypeEnum.Figi,
                        quoteType: QuoteSeriesId.QuoteTypeEnum.Price,
                        field: "mid"),
                    effectiveAt: date.AddDays(i)),
                metricValue: new MetricValue(
                    value: 199.23m,
                    unit: "USD"),
                lineage: "InternalSystem")).ToDictionary(k => k.QuoteId.EffectiveAt.ToString(), v => v);

            var tasks = Enumerable.Range(0, threadCount).Select(x => Task.Run(() =>
            {
                var factory = LusidApiFactoryBuilder.Build(config.ApiUrl, provider);
                var result = factory.Api<IQuotesApi>().UpsertQuotes("mt-scope", request);
                Assert.That(result.Failed, Is.Empty);
            }));

            Task.WaitAll(tasks.ToArray());
        }

        [Test, Explicit("Only an issue on .NET Core 2.2 on Linux / MacOS")]
        public void LinuxSocketLeakTest() // See DEV-7152
        {
            ApiConfiguration config = TestLusidApiFactoryBuilder.CreateApiConfiguration("secrets.json");
            var provider = new ClientCredentialsFlowTokenProvider(config);

            var api = BuildApi();
            api.CreatePortfolioGroup("sdktest", new CreatePortfolioGroupRequest("TestGroup", displayName: "TestGroup"));

            // This loop should eventually throw a SocketException: "Address already in use" once all the sockets have been exhausted
            for (int i = 0; i < 50_000; i++)
            {
                api = BuildApi();
                PortfolioGroup result = api.GetPortfolioGroup("sdktest", "TestGroup");
                Assert.That(result, Is.Not.Null);

                // Option 1: force dispose of ApiClient
                //api.Configuration.ApiClient.Dispose();

                // Option 2: force all finalizers to run
                if (i % 100 == 0)
                {
                    GC.Collect();
                    GC.WaitForPendingFinalizers();
                }
            }

            /*** Local Functions ***/
            IPortfolioGroupsApi BuildApi()
            {
                // An instance of HttpClient is created within LusidApiFactory.Configuration.ApiClient.RestClient
                // which wasn't being disposed
                ILusidApiFactory factory = LusidApiFactoryBuilder.Build(config.ApiUrl, provider);
                IPortfolioGroupsApi api = factory.Api<IPortfolioGroupsApi>();
                return api;
            }
        }
        
        [Test]
        public void ApiResponse_CanExtract_DateHeader()
        {
            var apiResponse = _factory.Api<ApplicationMetadataApi>().GetLusidVersionsWithHttpInfo();
            var date = apiResponse.GetRequestDateTime();
            Assert.IsNotNull(date);
        }
        
        [Test]
        public void ApiResponse_CanExtractAndParseAccurately_DateHeader()
        {
            var apiResponse = new ApiResponse<VersionSummaryDto>(
                statusCode: HttpStatusCode.OK,
                headers: new Multimap<string, string>()
                {
                    {"Date", "Tue, 09 Feb 2021 05:18:41 GMT"},
                },
                data: new VersionSummaryDto()
            );
            var date = apiResponse.GetRequestDateTime();
            Assert.That(date, Is.EqualTo(new DateTimeOffset(2021, 2, 9, 5, 18, 41, new TimeSpan())));
        }

        [Test]
        public void ApiResponseMissingHeader_ReturnsNull_DateHeader()
        {
            var apiResponse = _factory.Api<ApplicationMetadataApi>().GetLusidVersionsWithHttpInfo();
            // Remove header containing access token
            apiResponse.Headers.Remove(ApiResponseExtensions.DateHeader);
            var date = apiResponse.GetRequestDateTime();
            Assert.IsNull(date);
        }
        
        [Test]
        public void ApiResponseInvalidDateHeader_ReturnsNull_DateHeader()
        {
            var apiResponse = _factory.Api<ApplicationMetadataApi>().GetLusidVersionsWithHttpInfo();
            // Invalidate header containing access token
            apiResponse.Headers[ApiResponseExtensions.DateHeader] = new[] {"invalid"};
            var date = apiResponse.GetRequestDateTime();
            Assert.IsNull(date);
        }

        [Test]
        public void ExceptionFactoryIsOverriddenWithCustomImplementation()
        {
            var api = _factory.Api<ApplicationMetadataApi>();
            Assert.That(api.ExceptionFactory.GetInvocationList().Single().Method.Name, Is.EqualTo(nameof(LusidExceptionHandler.CustomExceptionFactory)));
        }

        [Test]
        public void ApiFactoryCanBuildApisWithDefaultHeaders()
        {
            // arrange
            var config = TestLusidApiFactoryBuilder.CreateApiConfiguration("secrets.json");
            var provider = new ClientCredentialsFlowTokenProvider(config);
            var defaultHeaders = new Dictionary<string, string>()
            {
                {"X-LUSID-Application", "TestApp"}
            };
            
            // act
            var factory = LusidApiFactoryBuilder.Build(config.ApiUrl, provider, defaultHeaders);
            var api = factory.Api<IPortfolioGroupsApi>();
            
            // assert
            Assert.AreEqual(defaultHeaders["X-LUSID-Application"], api.Configuration.DefaultHeaders["X-LUSID-Application"]);
        }

        [Test]
        public void ApiFactoryHasNoDefaultHeadersWhenNoneAreSpecified()
        {
            // arrange
            var config = TestLusidApiFactoryBuilder.CreateApiConfiguration("secrets.json");
            var provider = new ClientCredentialsFlowTokenProvider(config);

            // act
            var factory = LusidApiFactoryBuilder.Build(config.ApiUrl, provider);
            var api = factory.Api<IPortfolioGroupsApi>();
            
            // assert
            Assert.IsEmpty(api.Configuration.DefaultHeaders);
        }

        [Test]
        public void ApiFactoryWithTimeout()
        {
            int timeout = 10;
            int defaultTimeout = 100000;

            var factory = LusidApiFactoryBuilder.Build("secrets.json", timeout);
            var api = factory.Api<ScopesApi>();

            DateTime start = DateTime.Now;

            Assert.That(() => api.ListScopes(null), Throws.InstanceOf<ApiException>().With.Message.EqualTo("Internal SDK error occurred when calling ListScopes: The operation has timed out.").Or.Message.EqualTo("Internal SDK error occurred when calling ListScopes: The operation was canceled."));
            
            DateTime finish = DateTime.Now;
            TimeSpan elapsed = finish - start;

            Assert.That(elapsed.TotalMilliseconds, Is.LessThanOrEqualTo((long)defaultTimeout));
        }
    }
}
