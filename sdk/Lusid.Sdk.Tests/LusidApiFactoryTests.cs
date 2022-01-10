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
        private ILusidApiFactory _factory = new LusidApiFactory(new Configuration());
        private const string RequestIdRegexPattern = "[a-zA-Z0-9]{13}:[0-9a-fA-F]{8}";
        

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
        public void ApiException_Without_ErrorContent_Returns_NullRequestId()
        {
            var error = new ApiException();
            var errorResponse = error.GetRequestId();

            Assert.That(errorResponse, Is.Null);
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
    }
}