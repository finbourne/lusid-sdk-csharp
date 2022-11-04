using System;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Polly;
using Polly.Wrap;
using RestSharp;

namespace Lusid.Sdk.Utilities
{
    /// <summary>
    /// Class used to define API error retry rules for all API calls.
    /// </summary>
    public static class PollyApiRetryHandler
    {
        /// <summary>
        /// Number of max default retry attempts
        /// </summary>
        public const int DefaultNumberOfRetries = 2;

        private const int RateLimitRetryCount = 3;

        /// <summary>
        /// Get the Polly retry condition on which to retry.
        /// </summary>
        /// <param name="restResponse">Response object that comes from the API Client</param>
        /// <returns>The boolean of whether the Polly retry condition is satisfied</returns>
        public static bool GetPollyRetryCondition(IRestResponse restResponse)
        {
            // Retry on concurrency conflict failures
            bool concurrencyConflictCondition = restResponse.StatusCode == (HttpStatusCode)409;

            return concurrencyConflictCondition;
        }

        /// <summary>
        /// Get the Polly retry condition on which to retry.
        /// </summary>
        /// <param name="restResponse">Response object that comes from the API Client</param>
        /// <returns>The boolean of whether the Polly retry condition is satisfied</returns>
        public static bool GetPollyRateLimitRetryCondition(IRestResponse restResponse)
        {
            // Retry on rate limit hit:
            bool rateLimitHitCondition = restResponse.StatusCode == (HttpStatusCode)429;
            return rateLimitHitCondition;
        }

        private static void HandleRetryAction(DelegateResult<IRestResponse> result, int retryCount, Context context)
        {
        }

        #region Synchronous Retry Policies

        /// <summary>
        /// Retry policy with an action to return the failed response after retries have exceeded.
        /// Use .Wrap() method to combine this policy with your other custom policies
        /// </summary>
        public static readonly PolicyWrap<IRestResponse> DefaultRetryPolicyWithFallback =
            // Order of wraps matters. We must wrap the retry policy ON the fallback policy, not the other way around.
            DefaultFallbackPolicy.Wrap(DefaultRetryPolicy);

        /// <summary>
        /// Causes the actual API response to be returned after retries have been exceeded.
        /// It is necessary to use with OpenAPI, as without it a null result will be returned
        /// </summary>
        /// <returns>Fallback Policy (Synchronous)</returns>
        public static Policy<IRestResponse> DefaultFallbackPolicy =>
            Policy<IRestResponse>
                .Handle<SystemException>()
                .Fallback(
                    (outcome, ctx, ct) => outcome.Result,
                    (outcome, ctx) =>
                    {
                        // Add logging or other logic here 
                    });


        /// <summary>
        /// Define Polly retry policy for synchronous API calls.
        /// </summary>
        public static Policy<IRestResponse> DefaultRetryPolicy =>
            Policy
                .HandleResult<IRestResponse>(GetPollyRetryCondition)
                .Retry(retryCount: DefaultNumberOfRetries, onRetry: HandleRetryAction);

        /// <summary>
        /// Retry policy wrap that handles rate limit codes (409) as well as the default retry policy.
        /// Use .Wrap() method to combine this policy with your other custom policies.
        /// </summary>
        /// <returns> Policy Wraps (Synchronous)</returns>
        public static PolicyWrap<IRestResponse> DefaultRetryPolicyWithRateLimit =>
            // Order of wraps matters. We must wrap the retry policy ON the fallback policy, not the other way around.
            DefaultRetryPolicy.Wrap(RateLimitRetryPolicy);

        /// <summary>
        /// Defines policy for handling rate limit (429) http response codes.
        /// </summary>
        public static Policy<IRestResponse> RateLimitRetryPolicy => Policy
            .HandleResult<IRestResponse>(GetPollyRateLimitRetryCondition)
            .WaitAndRetry(RateLimitRetryCount, RateLimitSleepDurationProvider, OnRetry);

        private static void OnRetry(DelegateResult<IRestResponse> arg1, TimeSpan arg2, Context arg3)
        {
        }

        #endregion

        #region Async Retry Policies

        /// <summary>
        /// Retry policy with an action to return the failed response after retries have exceeded.
        /// Use .WrapAsync() method to combine this policy with your other custom policies
        /// </summary>
        public static readonly AsyncPolicyWrap<IRestResponse> DefaultRetryPolicyWithFallbackAsync =
            // Order of wraps matters. We must wrap the retry policy ON the fallback policy, not the other way around.
            DefaultFallbackPolicyAsync.WrapAsync(DefaultRetryPolicyAsync);

        /// <summary>
        /// Define Polly retry policy for asynchronous API calls.
        /// </summary>
        public static AsyncPolicy<IRestResponse> DefaultRetryPolicyAsync =>
            Policy
                .HandleResult<IRestResponse>(GetPollyRetryCondition)
                .RetryAsync(retryCount: DefaultNumberOfRetries, onRetry: HandleRetryAction);

        /// <summary>
        /// Defines async policy for handling rate limit (429) http response codes.
        /// </summary>
        public static AsyncPolicy<IRestResponse> AsyncRateLimitRetryPolicy
            => Policy.HandleResult<IRestResponse>(GetPollyRateLimitRetryCondition)
                .WaitAndRetryAsync(RateLimitRetryCount, RateLimitSleepDurationProvider, OnRetryAsync);

        private static Task OnRetryAsync(DelegateResult<IRestResponse> arg1, TimeSpan arg2, int arg3, Context arg4)
        {
            return Task.CompletedTask;
        }

        /// <summary>
        /// Causes the actual API response to be returned after retries have been exceeded.
        /// It is necessary to use with OpenAPI, as without it a null result will be returned
        /// </summary>
        /// <returns>Fallback Policy (Asynchronous)</returns>
        public static AsyncPolicy<IRestResponse> DefaultFallbackPolicyAsync =>
            Policy<IRestResponse>
                .Handle<SystemException>()
                .FallbackAsync(
                    (outcome, b, c) => Task.FromResult(outcome.Result),
                    (outcome, b) => Task.CompletedTask);

        /// <summary>
        /// Async retry policy wrap that handles rate limit codes (409) as well as the default retry policy.
        /// Use .WrapAsync() method to combine this policy with your other custom policies.
        /// </summary>
        /// <returns>Policy Wrap (Async)</returns>
        public static AsyncPolicyWrap<IRestResponse> AsyncDefaultRetryPolicyWithRateLimit =>
            // Order of wraps matters. We must wrap the retry policy ON the fallback policy, not the other way around.
            DefaultRetryPolicyAsync.WrapAsync(AsyncRateLimitRetryPolicy);

        #endregion

        private static TimeSpan RateLimitSleepDurationProvider(int attemptCount,
            DelegateResult<IRestResponse> restResponse, Context context)
        {
            var retryAfterHeader = restResponse?.Result?.Headers.SingleOrDefault(h => h.Name == "Retry-After");
            double secondsInterval = 0;
            if (retryAfterHeader != null)
            {
                var value = retryAfterHeader.Value?.ToString();
                double.TryParse(value, out secondsInterval);
            }

            if (secondsInterval == 0)
            {
                secondsInterval = Math.Pow(2, attemptCount);
            }

            return TimeSpan.FromSeconds(secondsInterval);
        }
    }
}