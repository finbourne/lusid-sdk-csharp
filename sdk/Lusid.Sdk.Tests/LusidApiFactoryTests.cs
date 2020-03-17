using System;
using System.Linq;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;
using Lusid.Sdk.Utilities;
using NUnit.Framework;

namespace Lusid.Sdk.Tests
{
    [TestFixture]
    public class LusidApiFactoryTests
    {
        private ILusidApiFactory _factory = new LusidApiFactory(new Configuration());

        [OneTimeSetUp]
        public void SetUp()
        {
            _factory = LusidApiFactoryBuilder.Build("secrets.json");
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
            public Configuration Configuration { get; set; }
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
                TokenUrl = "xyz"
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
                
                Assert.That(errorResponse.Detail, Does.Match("Portfolio with id exist in scope doesnt effective.*does not exist"));
                Assert.That(errorResponse.Name, Is.EqualTo("PortfolioNotFound"));
            }            
        }
        
        [Test]
        public void ApiException_Converts_To_ValidationProblemDetails()
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
                    Assert.That(errorResponse.Errors["code"].Single(), Is.EqualTo("Values for this field must be non-zero in length and be comprised of either alphanumeric characters, hyphens or underscores. For more information please consult the LUSID documentation."));
                    
                    //Should identify that there was a validation error with the scope
                    Assert.That(errorResponse.Errors, Contains.Key("scope"));
                    Assert.That(errorResponse.Errors["scope"].Single(), Is.EqualTo("Values for this field must be non-zero in length and be comprised of either alphanumeric characters, hyphens or underscores. For more information please consult the LUSID documentation."));
                
                    Assert.That(errorResponse.Detail, Does.Match("One or more of the bits of input data provided were not valid.*"));
                    Assert.That(errorResponse.Name, Is.EqualTo("InvalidParameterValue"));
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
        public void ApiException_With_Empty_ErrorContent_Returns_Null()
        {
            var error = new ApiException();
            var errorResponse = error.ProblemDetails();
            
            Assert.That(errorResponse, Is.Null);
        }

        [Test, Explicit("Only an issue on .NET Core 2.2 on Linux / MacOS")]
        public void LinuxSocketLeakTest() // See DEV-7152
        {
            ApiConfiguration config = null; // config = ApiConfigurationBuilder.Build("secrets.json"); // ApiConfigurationBuilder is in Preview SDK only atm
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
    }
}