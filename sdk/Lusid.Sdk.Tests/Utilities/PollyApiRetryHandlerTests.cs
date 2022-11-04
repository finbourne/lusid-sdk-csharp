using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;
using Lusid.Sdk.Utilities;
using NUnit.Framework;
using Polly;
using RestSharp;

namespace Lusid.Sdk.Tests.Utilities
{
    [TestFixture]
    // This tests suite changes any unexpected behaviour with the retry mechanism in case of default template changes or SDK upgrades
    // For further Polly functionality reference, check out this page: https://github.com/App-vNext/Polly
    public class PollyApiRetryHandlerTests
    {
        private LusidApiFactory _apiFactory;
        private readonly Policy<IRestResponse> _initialRetryPolicy = RetryConfiguration.RetryPolicy;
        private HttpListener _httpListener;
        private const string ListenerUriPrefix = "http://localhost:4444/";
        private const int RetryAfterResponseCode = (int)HttpStatusCode.TooManyRequests;
        private const int StatusCodeResponseDefaultRetry = (int)HttpStatusCode.Conflict;
        private int _apiCallCount;

        private readonly Portfolio _testPortfolioResponse = new Portfolio(
            "test",
            id: new ResourceId("test", "test"),
            displayName: "test",
            created: DateTimeOffset.Now,
            description: "test",
            type: Portfolio.TypeEnum.Transaction);
            

        [SetUp]
        public void SetUp()
        {
            _apiCallCount = 0;
            
            _httpListener = new HttpListener();
            _httpListener.Prefixes.Add(ListenerUriPrefix);

            var testApiConfig = TestLusidApiFactoryBuilder.CreateApiConfiguration("secrets.json");
            testApiConfig.ApiUrl = ListenerUriPrefix;

            _apiFactory = new LusidApiFactory(testApiConfig);

            _httpListener.Start();
        }
        
        #region Sync tests
        
        [Test]
        public void CallGetPortfoliosApi_WhenHttpStatusIs400AndRetryConditionIsNotSatisfied_ThrowsApiExceptionWithoutRetry()
        {
            // It should not retry on codes such as 400 by default, unless specified
            const int expectedStatusCode = 400;
            const int expectedNumberOfApiCalls = 1;
            const string someError = "SomeError...";
            // Add the next response returned by api
            AddMockHttpResponseToQueue(
                _httpListener, statusCode: 
                expectedStatusCode, 
                responseContent: someError);
            
            RetryConfiguration.RetryPolicy = PollyApiRetryHandler.DefaultRetryPolicyWithFallback;
        
            var exception = Assert.Throws<ApiException>(
                () => _apiFactory.Api<IPortfoliosApi>().GetPortfolio("any", "any")
            );

            Assert.That(exception.ErrorContent, Is.EqualTo(someError));
            Assert.That(exception.ErrorCode, Is.EqualTo(expectedStatusCode));
            // Api was called just once, no retries
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
        }

        [Test]
        public void CallGetPortfoliosApi_WhenHttpStatusIs200AndRetryConditionIsNotSatisfied_NoPollyRetryIsTriggered()
        {
            // It should do nothing when response code is 200
            const int expectedStatusCode = 200;
            const int expectedNumberOfApiCalls = 1;
            // Add the next response returned by api
            AddMockHttpResponseToQueue(
                _httpListener, 
                expectedStatusCode, 
                responseContent: _testPortfolioResponse.ToJson());
                
            RetryConfiguration.RetryPolicy = PollyApiRetryHandler.DefaultRetryPolicyWithFallback;
            
            var sdkResponse = _apiFactory.Api<IPortfoliosApi>().GetPortfolio("any", "any");
            
            // Api call should be just called once
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
            Assert.That(sdkResponse, Is.EqualTo(_testPortfolioResponse));
        }

        [Test]
        [TestCase(409)] // Concurrency
        public void CallGetPortfoliosApi_WhenApiResponseStatusCodeSatisfiesRetryCriteria_ExceedsPollyRetriesAndThrows(int returnedStatusCode)
        {
            const int expectedNumberOfRetries = PollyApiRetryHandler.DefaultNumberOfRetries;
            const int expectedNumberOfApiCalls = expectedNumberOfRetries + 1;
            const string returnedErrorMessage = "Some error response";
            for (var i = 0; i < expectedNumberOfApiCalls; i++)
            {
                // Every response fails
                AddMockHttpResponseToQueue(_httpListener, returnedStatusCode, returnedErrorMessage);
            }
 
            RetryConfiguration.RetryPolicy = PollyApiRetryHandler.DefaultRetryPolicyWithFallback;

            // Calling GetPortfolio or any other API triggers the flow that triggers polly
            var exception = Assert.Throws<ApiException>(
                () => _apiFactory.Api<IPortfoliosApi>().GetPortfolio("any", "any")
            );

            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
            Assert.That(exception.ErrorContent, Is.EqualTo(returnedErrorMessage));
            Assert.That(exception.ErrorCode, Is.EqualTo(returnedStatusCode));
        }

        [Test]
        [TestCase(409)] // Concurrency conflict failure
        public void CallGetPortfoliosApi_WhenExceedsPollyRetries_NoFallbackPolicyDefined_DoesNotThrow_ReturnsEmptyResponse(int returnedStatusCode)
        {
            const int expectedNumberOfRetries = PollyApiRetryHandler.DefaultNumberOfRetries;
            const int expectedNumberOfApiCalls = expectedNumberOfRetries + 1;
            for (var i = 0; i < expectedNumberOfApiCalls; i++)
            {
                // Every response fails
                AddMockHttpResponseToQueue(_httpListener, statusCode: returnedStatusCode, responseContent: "Error that was thrown");
            }
            RetryConfiguration.RetryPolicy = PollyApiRetryHandler.DefaultRetryPolicy; // No fallback
            
            // Calling GetPortfolio or any other API triggers the flow that triggers polly
            var response = _apiFactory.Api<IPortfoliosApi>().GetPortfolio("any", "any");

            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
            Assert.That(response, Is.Null);
        }

        [Test]
        [TestCase(409)] // Concurrency conflict failure
        public void CallGetPortfoliosApi_PollyRetryConditionIsSatisfied_RetriesUntilSuccess_DoesNotThrow(int returnedStatusCode)
        {
            const int expectedNumberOfRetries = PollyApiRetryHandler.DefaultNumberOfRetries;
            const int expectedNumberOfApiCalls = 1 + expectedNumberOfRetries;
            // First Response is a failing code
            AddMockHttpResponseToQueue(_httpListener, statusCode: returnedStatusCode, responseContent: "some err");
            // Second response is the first retry. It fails again
            AddMockHttpResponseToQueue(_httpListener, statusCode: returnedStatusCode, responseContent: "some err");
            // Third response is the second retry. Returns 200 before retries are exceeded, and does not throw
            AddMockHttpResponseToQueue(_httpListener, statusCode: 200, responseContent: _testPortfolioResponse.ToJson());
            RetryConfiguration.RetryPolicy = PollyApiRetryHandler.DefaultRetryPolicyWithFallback;

            // Calling GetPortfolio or any other API triggers the flow that triggers polly
            var sdkResponse = _apiFactory.Api<IPortfoliosApi>().GetPortfolio("any", "any");

            Assert.That(sdkResponse, Is.EqualTo(_testPortfolioResponse));
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
        }

        // Example of how an exponential backoff can be used with Polly
        [Test]
        public void CallGetPortfoliosApi_WhenApiResponseStatusCodeSatisfiesRetryCriteria_PollyRetryWithBackoffIsTriggered()
        {
            const int returnedStatusCode = 409;
            const int expectedNumberOfRetries = PollyApiRetryHandler.DefaultNumberOfRetries;
            const int expectedNumberOfApiCalls = expectedNumberOfRetries + 1;
            for (var i = 0; i < expectedNumberOfApiCalls; i++)
            {
                AddMockHttpResponseToQueue(_httpListener, returnedStatusCode, responseContent: _testPortfolioResponse.ToJson());
            }
            var retryCount = 0;
            // Polly retry policy with a backoff example
            RetryConfiguration.RetryPolicy = Policy
                .HandleResult<IRestResponse>(apiResponse =>
                    apiResponse.StatusCode == (HttpStatusCode) returnedStatusCode)
                .WaitAndRetry(expectedNumberOfRetries,
                    sleepDurationProvider: retryAttempt => 0.1 * TimeSpan.FromSeconds(Math.Pow(2, retryAttempt)),
                    onRetry: (restResponseResult, timeSpan, context) =>
                    {
                        // Add logic to be executed before each retry, such as logging
                        retryCount++;
                    });

            // Calling GetPortfolio or any other API triggers the flow that triggers polly
            var sdkResponse = _apiFactory.Api<IPortfoliosApi>().GetPortfolio("any", "any");

            Assert.That(retryCount, Is.EqualTo(expectedNumberOfRetries));
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
            // Policies with no fallback will return null
            Assert.That(sdkResponse, Is.Null);
        }
        
        [Test]
        [Explicit("This test only works on Windows as when running on a Linux Docker image. " +
                  "Linux seems to handle aborted connections differently, resulting always in a 200 status rather than 0.")]
        public void CallGetPortfoliosApi_WhenApiResponseStatusCodeSatisfiesRetryCriteria_ConnectivityIssuesNoRetry_Throws()
        {
            const int expectedNumberOfApiCalls = 3;
            for (var i = 0; i < expectedNumberOfApiCalls; i++)
            {
                _httpListener.BeginGetContext(result =>
                {
                    _apiCallCount++;
                    var listener = (HttpListener) result.AsyncState;
                    // Call EndGetContext to complete the asynchronous operation.
                    var context = listener.EndGetContext(result);

                    // Obtain a response object.
                    var response = context.Response;

                    // Abort the response. This returns 0 status code when running on windows.
                    // Dotnet does not allow specifying a return status code 0, so this is a workaround on windows.
                    response.Abort();
                }, _httpListener);
            }
            
            RetryConfiguration.RetryPolicy = PollyApiRetryHandler.DefaultFallbackPolicy.Wrap(
                Policy
                    .HandleResult<IRestResponse>(response => response.StatusCode == 0)
                    .Retry(retryCount: 2, onRetry: (response, count, ctx) => {})
                );

            var exception = Assert.Throws<ApiException>(
                () => _apiFactory.Api<IPortfoliosApi>().GetPortfolio("any", "any"));

            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
            Assert.That(exception.ErrorCode, Is.EqualTo(0));
            Assert.That(exception.ErrorContent, Contains.Substring("Internal SDK error occurred when calling GetPortfolio: An error occurred while sending the request"));

        }

        [Test]
        public void UsePolicyWrap_WhenCallingGetPortfolio_BothPoliciesAreUsed()
        {
            const int statusCodeResponse1 = 498;
            const int statusCodeResponse2 = 499;
            const int expectedNumberOfApiCalls = 4;
            // First Response
            AddMockHttpResponseToQueue(_httpListener, statusCode: statusCodeResponse1, responseContent: "");
            // Second Response - same, triggers another retry
            AddMockHttpResponseToQueue(_httpListener, statusCode: statusCodeResponse1, responseContent: "");
            // Third response - First policy retries stop, second policy retries kick in
            AddMockHttpResponseToQueue(_httpListener, statusCode: statusCodeResponse2, responseContent: "");
            // Fourth response - No more retries as response is a success
            AddMockHttpResponseToQueue(_httpListener, statusCode: 200, responseContent: _testPortfolioResponse.ToJson());
            var policy1TriggerCount = 0;
            var policy2TriggerCount = 0;
            var policy1 = Policy
                .HandleResult<IRestResponse>(apiResponse => apiResponse.StatusCode == (HttpStatusCode) statusCodeResponse1)
                .Retry(retryCount: 3, onRetry: (result, i) => policy1TriggerCount++);
            var policy2 = Policy
                .HandleResult<IRestResponse>(apiResponse => apiResponse.StatusCode == (HttpStatusCode) statusCodeResponse2)
                .Retry(retryCount: 3, onRetry: (result, i) => policy2TriggerCount++);
            RetryConfiguration.RetryPolicy = policy1.Wrap(policy2);

            // Calling GetPortfolio or any other API triggers the flow that triggers polly
            var sdkResponse = _apiFactory.Api<IPortfoliosApi>().GetPortfolio("any", "any");

            Assert.That(policy1TriggerCount, Is.EqualTo(2));
            Assert.That(policy2TriggerCount, Is.EqualTo(1));
            Assert.That(sdkResponse, Is.EqualTo(_testPortfolioResponse));
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
        }

        // Default timeout config is 100000 seconds (1min40s)
        [Test]
        public void CallGetPortfoliosApi_WhenRequestTimeExceedsTimeoutConfigured_NoRetryIsTriggeredOnClientTimeout_Throws()
        {
            var timeoutAfterMillis = GlobalConfiguration.Instance.Timeout;
            const int returnedStatusCode = 200; // Doesn't matter what code is on timeout, will always return 0
            const int expectedNumberOfApiCalls = 1;
            // First call will cause a timeout, no retries
            AddMockHttpResponseToQueue(
                _httpListener, 
                returnedStatusCode, 
                responseContent: _testPortfolioResponse.ToJson(), 
                timeoutAfterMillis + 10);
            RetryConfiguration.RetryPolicy = PollyApiRetryHandler.DefaultRetryPolicyWithFallback;

            // Calling GetPortfolio or any other API triggers the flow that triggers polly
            
            var exception = Assert.Throws<ApiException>(
                () => _apiFactory.Api<IPortfoliosApi>().GetPortfolio("any", "any"));

            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
            // Notice that Sync throws different error message than async
            Assert.That(exception.ErrorContent, Contains.Substring("The operation has timed out"));
            Assert.That(exception.ErrorCode, Is.EqualTo(0));

        }
        
        [Test]
        public void CreateLusidFactory_WhenRetryPolicyIsNull_AssignsDefaultRetryPolicy()
        {
            RetryConfiguration.RetryPolicy = null;

            var newFactory = new LusidApiFactory(new Configuration());

            Assert.That(RetryConfiguration.RetryPolicy, Is.Not.Null);
            Assert.That(RetryConfiguration.RetryPolicy, Is.EqualTo(PollyApiRetryHandler.DefaultRetryPolicyWithFallback));
        }

        [Test]
        public void CreateLusidFactory_WhenRetryPolicyIsAlreadyAssigned_ExistingRetryPolicyIsUsed()
        {
            var testPolicy = Policy.HandleResult<IRestResponse>(response => true).Retry();

            RetryConfiguration.RetryPolicy = testPolicy;
            var newFactory = new LusidApiFactory(new Configuration());

            Assert.That(RetryConfiguration.RetryPolicy, Is.EqualTo(testPolicy));
        }
        
        [Test]
        public void UsePolicyWrap_WhenCallingApiMethodHitsRateLimit_BothDefaultAndRateLimitPoliciesAreUsed()
        {
            const int expectedNumberOfApiCalls = 6; // 3 failures for rate limit and 2 for the default one followed by success.
            
            // First Response
            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "", 
                0, new Dictionary<HttpResponseHeader, string>() {[HttpResponseHeader.RetryAfter] = "1"});
            // Second Response - same, triggers another retry
            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "", 
                0, new Dictionary<HttpResponseHeader, string>() {[HttpResponseHeader.RetryAfter] = "1"});
            
            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "", 
                0, new Dictionary<HttpResponseHeader, string>() {[HttpResponseHeader.RetryAfter] = "1"});

            AddMockHttpResponseToQueue(_httpListener, statusCode: StatusCodeResponseDefaultRetry, responseContent: "");
            
            AddMockHttpResponseToQueue(_httpListener, statusCode: StatusCodeResponseDefaultRetry, responseContent: "");

            AddMockHttpResponseToQueue(_httpListener, statusCode: 200, responseContent: _testPortfolioResponse.ToJson());
          
            RetryConfiguration.RetryPolicy = PollyApiRetryHandler.DefaultRetryPolicyWithRateLimit;
            
            // Calling the API triggers the flow that triggers polly
            var sdkResponse = _apiFactory.Api<IPortfoliosApi>().GetPortfolio("any","any");
            
            Assert.That(sdkResponse, Is.EqualTo(_testPortfolioResponse));
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
        }

        [Test]
        public void UseRateLimitPolicyWithRetryAfter_WhenCallingApiMethodHitsRateLimit_RetryAfterIsHonored()
        {
            const int retryAfterResponseCode = (int)HttpStatusCode.TooManyRequests;
            const int expectedNumberOfApiCalls = 4; // 1 initial call, 2 failed retries and one success

            // First Response
            AddMockHttpResponseToQueue(_httpListener, statusCode: retryAfterResponseCode, responseContent: "", 
                0, new Dictionary<HttpResponseHeader, string>() { [HttpResponseHeader.RetryAfter] = "5" });
            // Second Response - same, triggers another retry
            AddMockHttpResponseToQueue(_httpListener, statusCode: retryAfterResponseCode, responseContent: "", 
                0, new Dictionary<HttpResponseHeader, string>() { [HttpResponseHeader.RetryAfter] = "7" });
            
            AddMockHttpResponseToQueue(_httpListener, statusCode: retryAfterResponseCode, responseContent: "", 
                0, new Dictionary<HttpResponseHeader, string>() { [HttpResponseHeader.RetryAfter] = "9" });
            // 4 time lucky:
            AddMockHttpResponseToQueue(_httpListener, statusCode: 200, responseContent: _testPortfolioResponse.ToJson());

            RetryConfiguration.RetryPolicy = PollyApiRetryHandler.RateLimitRetryPolicy;
            var sw = Stopwatch.StartNew();
            // Calling the API triggers the flow that triggers polly
            var sdkResponse = _apiFactory.Api<IPortfoliosApi>().GetPortfolio("any","any");
            sw.Stop();
            Assert.That(sw.ElapsedMilliseconds, Is.GreaterThanOrEqualTo(1000*(5+7+9))); // retry after was respected
            Assert.That(sdkResponse, Is.EqualTo(_testPortfolioResponse));
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
        }
        
        [Test]
        public void UseRateLimitPolicyNoRetryAfter_WhenCallingApiMethodHitsRateLimit_RetryUsesExponentialBackoff()
        {
            const int retryAfterResponseCode = 429;
            const int expectedNumberOfApiCalls = 4; // 1 initial call + 3 retries 
            
            // First Response
            AddMockHttpResponseToQueue(_httpListener, statusCode: retryAfterResponseCode, "");
            // Second Response - same, triggers another retry
            AddMockHttpResponseToQueue(_httpListener, statusCode: retryAfterResponseCode, responseContent: "");
            // Third Response - same, triggers another retry
            AddMockHttpResponseToQueue(_httpListener, statusCode: retryAfterResponseCode, responseContent: "");

            AddMockHttpResponseToQueue(_httpListener, statusCode: retryAfterResponseCode, responseContent: "");

            
            RetryConfiguration.RetryPolicy = PollyApiRetryHandler.RateLimitRetryPolicy;
            var sw = Stopwatch.StartNew();
            // Calling the API triggers the flow that triggers polly
            var sdkResponse = _apiFactory.Api<IPortfoliosApi>().GetPortfolio("any","any");
            sw.Stop();
            Assert.That(sw.ElapsedMilliseconds, Is.GreaterThanOrEqualTo(1000*(2+4+8))); // exponential backoff
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
        }
        #endregion
        
        #region Async tests
        
        [Test]
        public async Task CallGetPortfoliosApiAsync_WhenHttpStatusIs200AndRetryConditionIsNotSatisfied_NoPollyRetryIsTriggered()
        {
            // It should do nothing when response code is 200
            const int expectedStatusCode = 200;
            const int expectedNumberOfApiCalls = 1;
            // Add the next response returned by api
            AddMockHttpResponseToQueue(
                _httpListener, 
                expectedStatusCode, 
                responseContent: _testPortfolioResponse.ToJson());
                
            RetryConfiguration.AsyncRetryPolicy = PollyApiRetryHandler.DefaultRetryPolicyWithFallbackAsync;

            var sdkResponse = await _apiFactory.Api<IPortfoliosApi>().GetPortfolioAsync("any", "any");
            
            // Api call should be just called once
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
            Assert.That(sdkResponse, Is.EqualTo(_testPortfolioResponse));
        }
        
        [Test]
        [TestCase(409)] // Concurrency conflict failure
        public async Task CallGetPortfoliosApiAsync_PollyRetryConditionIsSatisfied_RetriesUntilSuccess_DoesNotThrow(int returnedStatusCode)
        {
            const int expectedNumberOfRetries = 2;
            const int expectedNumberOfApiCalls = 1 + expectedNumberOfRetries;
            // First Response is a failing code
            AddMockHttpResponseToQueue(_httpListener, statusCode: returnedStatusCode, responseContent: "some err");
            // Second response is the first retry. It fails again
            AddMockHttpResponseToQueue(_httpListener, statusCode: returnedStatusCode, responseContent: "some err");
            // Third response is the second retry. Returns 200 before retries are exceeded, and does not throw
            AddMockHttpResponseToQueue(_httpListener, statusCode: 200, responseContent: _testPortfolioResponse.ToJson());
            RetryConfiguration.RetryPolicy = PollyApiRetryHandler.DefaultRetryPolicyWithFallback;

            // Calling GetPortfolio or any other API triggers the flow that triggers polly
            var sdkResponse = await _apiFactory.Api<IPortfoliosApi>().GetPortfolioAsync("any", "any");

            Assert.That(sdkResponse, Is.EqualTo(_testPortfolioResponse));
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
        }
        
        [Test]
        [TestCase(409)] // Concurrency conflict failure
        public void CallGetPortfoliosApiAsync_AsyncPollyIsTriggered_ThrowsWithExceededCallsFallbackPolicy(int returnedStatusCode)
        {
            const int expectedNumberOfRetries = 2;
            const int expectedNumberOfApiCalls = expectedNumberOfRetries + 1;
            const string expectedErrorResponse = "Some error";
            for (var i = 0; i < expectedNumberOfApiCalls; i++)
            {
                AddMockHttpResponseToQueue(_httpListener,  returnedStatusCode, expectedErrorResponse);
            }
            RetryConfiguration.AsyncRetryPolicy = PollyApiRetryHandler.DefaultRetryPolicyWithFallbackAsync;

            // Calling GetPortfolio or any other API triggers the flow that triggers polly
            var exception = Assert.ThrowsAsync<ApiException>(
                 () => _apiFactory.Api<IPortfoliosApi>().GetPortfolioAsync("any", "any")
                );

            Assert.That(exception.Message, Is.EqualTo($"Error calling GetPortfolio: {expectedErrorResponse}"));
            Assert.That(exception.ErrorCode, Is.EqualTo(returnedStatusCode));
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
        }
        
        [Test]
        [TestCase(409)] // Concurrency conflict failure
        public async Task CallGetPortfoliosApiAsync_AsyncPollyIsTriggered_NoFallbackPolicy_ReturnsNullResponseOnRetriesExceeded(int returnedStatusCode)
        {
            const int expectedNumberOfRetries = 2;
            const int expectedNumberOfApiCalls = expectedNumberOfRetries + 1;
            const string expectedErrorResponse = "Some error";
            for (var i = 0; i < expectedNumberOfApiCalls; i++)
            {
                AddMockHttpResponseToQueue(_httpListener,  returnedStatusCode, expectedErrorResponse);
            }
            RetryConfiguration.AsyncRetryPolicy = PollyApiRetryHandler.DefaultRetryPolicyAsync; // No fallback

            // Calling GetPortfolio or any other API triggers the flow that triggers polly
            var response = await _apiFactory.Api<IPortfoliosApi>().GetPortfolioAsync("any", "any");
            
            // Policies with no fallback return null
            Assert.That(response, Is.Null);
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
        }
        
        [Test]
        [Explicit("This test only works on Windows as when running on a Linux Docker image. " +
                  "Linux seems to handle aborted connections differently, resulting always in a 200 status rather than 0.")]
        public void CallGetPortfoliosApiAsync_WhenApiResponseStatusCodeSatisfiesRetryCriteria_ConnectivityIssuesNoRetry_Throws()
        {
            const int expectedNumberOfApiCalls = 3;
            for (var i = 0; i < expectedNumberOfApiCalls; i++)
            {
                _httpListener.BeginGetContext(result =>
                {
                    _apiCallCount++;
                    var listener = (HttpListener) result.AsyncState;
                    // Call EndGetContext to complete the asynchronous operation.
                    var context = listener.EndGetContext(result);

                    // Obtain a response object.
                    var response = context.Response;

                    // Abort the response. This returns 0 status code when running on windows.
                    // Dotnet does not allow specifying a return status code 0, so this is a workaround on windows.
                    response.Abort();
                }, _httpListener);
            }
            
            RetryConfiguration.AsyncRetryPolicy = PollyApiRetryHandler.DefaultFallbackPolicyAsync.WrapAsync(
                Policy
                    .HandleResult<IRestResponse>(response => response.StatusCode == 0)
                    .RetryAsync(retryCount: 2, onRetry: (response, count, ctx) => {})
            );


            // Calling GetPortfolio or any other API triggers the flow that triggers polly
            var exception = Assert.ThrowsAsync<ApiException>(
                () =>  _apiFactory.Api<IPortfoliosApi>().GetPortfolioAsync("any", "any"));

            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
            Assert.That(exception.ErrorCode, Is.EqualTo(0));
            Assert.That(exception.ErrorContent, Contains.Substring(
                "An error occurred while sending the request. " +
                "Unable to read data from the transport connection: " +
                "An existing connection was forcibly closed by the remote host"));
        }
        
        // Default timeout config is 100000 seconds (1min40s)
        [Test]
        public void CallGetPortfoliosApiAsync_WhenRequestTimeExceedsTimeoutConfigured_NoRetryIsTriggeredOnClientTimeout_Throws()
        {
            var timeoutAfterMillis = GlobalConfiguration.Instance.Timeout;
            const int returnedStatusCode = 200; // Doesn't matter what code is on timeout, will always return 0
            const int expectedNumberOfApiCalls = 1;
            // Call will cause a timeout and no retry
            AddMockHttpResponseToQueue(_httpListener, returnedStatusCode, responseContent: "", timeoutAfterMillis + 10);
            RetryConfiguration.AsyncRetryPolicy = PollyApiRetryHandler.DefaultRetryPolicyWithFallbackAsync;

            var exception = Assert.ThrowsAsync<ApiException>(
                () => _apiFactory.Api<IPortfoliosApi>().GetPortfolioAsync("any", "any"));

            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
            // Notice that Async throws different error message than Sync
            // However the error message sometimes changes on different environments for async for unknown reasons
            Assert.That(exception.ErrorContent, Contains.Substring("The request timed-out").Or.Contains("The operation has timed out"));
            Assert.That(exception.ErrorCode, Is.EqualTo(0));
        }
        
        [Test]
        public void CreateLusidFactory_WhenRetryPolicyIsNull_AssignsDefaultAsyncRetryPolicy()
        {
            RetryConfiguration.AsyncRetryPolicy = null;

            var newFactory = new LusidApiFactory(new Configuration());

            Assert.That(
                RetryConfiguration.AsyncRetryPolicy, 
                Is.EqualTo(PollyApiRetryHandler.DefaultRetryPolicyWithFallbackAsync));
        }

        [Test]
        public void CreateLusidFactory_WhenRetryPolicyIsAlreadyAssigned_ExistingAsyncRetryPolicyIsUsed()
        {
            var testPolicy = Policy.HandleResult<IRestResponse>(response => true).RetryAsync();

            RetryConfiguration.AsyncRetryPolicy = testPolicy;
            var newFactory = new LusidApiFactory(new Configuration());

            Assert.That(RetryConfiguration.AsyncRetryPolicy, Is.EqualTo(testPolicy));
        }
        
          [Test]
        public async Task UsePolicyWrapAsync_WhenCallingApiMethodHitsRateLimit_BothDefaultAndRateLimitPoliciesAreUsed()
        {
            const int expectedNumberOfApiCalls = 6; // 3 failures for rate limit and 2 for the default one followed by success.
            
            // First Response
            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "", 
                0, new Dictionary<HttpResponseHeader, string>() { [HttpResponseHeader.RetryAfter] = "1" });
            // Second Response - same, triggers another retry
            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "", 
                0, new Dictionary<HttpResponseHeader, string>() { [HttpResponseHeader.RetryAfter] = "1" });
            
            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "", 
                0, new Dictionary<HttpResponseHeader, string>() { [HttpResponseHeader.RetryAfter] = "1" });

            AddMockHttpResponseToQueue(_httpListener, statusCode: StatusCodeResponseDefaultRetry, responseContent: "");
            
            AddMockHttpResponseToQueue(_httpListener, StatusCodeResponseDefaultRetry, responseContent: "");

            AddMockHttpResponseToQueue(_httpListener, statusCode: 200, responseContent: _testPortfolioResponse.ToJson());
          
            RetryConfiguration.AsyncRetryPolicy = PollyApiRetryHandler.AsyncDefaultRetryPolicyWithRateLimit;
            
            // Calling API triggers the flow that triggers polly
            var sdkResponse = await _apiFactory.Api<IPortfoliosApi>().GetPortfolioAsync("any","any");
            
            Assert.That(sdkResponse, Is.EqualTo(_testPortfolioResponse));
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
        }

        [Test]
        public async Task UseRateLimitPolicyWithRetryAfterAsync_WhenCallingApiMethodHitsRateLimit_RetryAfterIsHonored()
        {
            const int expectedNumberOfApiCalls = 4; // 1 initial call, 2 failed retries and one success
            
            // First Response
            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "", 
                0, new Dictionary<HttpResponseHeader, string>() { [HttpResponseHeader.RetryAfter] = "5" });
            // Second Response - same, triggers another retry
            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "", 
                0, new Dictionary<HttpResponseHeader, string>() { [HttpResponseHeader.RetryAfter] = "7" });
            
            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "", 
                0, new Dictionary<HttpResponseHeader, string>() { [HttpResponseHeader.RetryAfter] = "9" });
            // 4 time lucky:
            AddMockHttpResponseToQueue(_httpListener, statusCode: 200, responseContent: _testPortfolioResponse.ToJson());

            RetryConfiguration.AsyncRetryPolicy = PollyApiRetryHandler.AsyncRateLimitRetryPolicy;
            var sw = Stopwatch.StartNew();
            // Calling API triggers the flow that triggers polly
            var sdkResponse = await _apiFactory.Api<IPortfoliosApi>().GetPortfolioAsync("any","any");
            sw.Stop();
            Assert.That(sw.ElapsedMilliseconds, Is.GreaterThanOrEqualTo(1000*(5+7+9))); // retry after was respected
            Assert.That(sdkResponse, Is.EqualTo(_testPortfolioResponse));
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
        }
        
        [Test]
        public async Task UseRateLimitPolicyNoRetryAfterAsync_WhenCallingApiMethodHitsRateLimit_RetryUsesExponentialBackoff()
        {
            const int expectedNumberOfApiCalls = 4; // 1 initial call + 3 retries 
            
            // First Response
            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "");
            // Second Response - same, triggers another retry
            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "");
            // Third Response - same, triggers another retry
            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "");

            AddMockHttpResponseToQueue(_httpListener, statusCode: RetryAfterResponseCode, responseContent: "");

            
            RetryConfiguration.AsyncRetryPolicy = PollyApiRetryHandler.AsyncRateLimitRetryPolicy;
            var sw = Stopwatch.StartNew();
            // Calling API triggers the flow that triggers polly
            var sdkResponse = await _apiFactory.Api<IPortfoliosApi>().GetPortfolioAsync("any","any");
            sw.Stop();
            Assert.That(sw.ElapsedMilliseconds, Is.GreaterThanOrEqualTo(1000*(2+4+8))); // exponential backoff
            Assert.That(_apiCallCount, Is.EqualTo(expectedNumberOfApiCalls));
        }
        #endregion

        [TearDown]
        public void TearDown()
        {
            // Make sure Polly is reset to what it was initially
            RetryConfiguration.RetryPolicy = _initialRetryPolicy;
            // Request is processed at this point and can be closed
            _httpListener.Close();
            _apiCallCount = 0;
        }

       private static void GetHttpResponseHandler(IAsyncResult result, int statusCode, string responseContent,
            int timeToRespond = 0, Dictionary<HttpResponseHeader, string> headerValues = null)
        {
            var listener = (HttpListener)result.AsyncState;
            // Call EndGetContext to complete the asynchronous operation.
            if (listener != null)
            {
                var context = listener.EndGetContext(result);

                // Obtain a response object.
                var response = context.Response;

                // Construct a response.
                var buffer = System.Text.Encoding.UTF8.GetBytes(responseContent);

                // Get a response stream and write the response to it.
                response.ContentLength64 = buffer.Length;
                response.StatusCode = statusCode;
                // We're assuming all responses are JSONS, no XMLs
                response.ContentType = "application/json; charset=utf-8";
                if (headerValues != null)
                {
                    foreach (var keyValuePair in headerValues)
                    {
                        response.Headers.Add(keyValuePair.Key, keyValuePair.Value);        
                    }
                }

                var output = response.OutputStream;

                // Simulate time taken for the response. Potentially simulate a timeout.
                Thread.Sleep(timeToRespond);

                output.Write(buffer, 0, buffer.Length);
                // You must close the output stream.
                output.Close();
            }
        }
        private void AddMockHttpResponseToQueue(HttpListener httpListener, int statusCode,
            string responseContent, int timeToRespondMillis = 0,  Dictionary<HttpResponseHeader, string> headerValues = null)
        {
            httpListener.BeginGetContext(
                result =>
                {
                    _apiCallCount++;
                    GetHttpResponseHandler(result, statusCode, responseContent, timeToRespondMillis, headerValues);
                },
                httpListener);
        }
    }
}