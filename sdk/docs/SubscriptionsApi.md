# Lusid.Sdk.Api.SubscriptionsApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeleteSubscription**](SubscriptionsApi.md#deletesubscription) | **DELETE** /api/subscriptions/holdings/{scope}/{code} | [EARLY ACCESS] DeleteSubscription: Delete a Subscription, assuming that it is present. |
| [**GetSubscription**](SubscriptionsApi.md#getsubscription) | **GET** /api/subscriptions/holdings/{scope}/{code} | [EARLY ACCESS] GetSubscription: Get Subscription |
| [**ListSubscriptions**](SubscriptionsApi.md#listsubscriptions) | **GET** /api/subscriptions/holdings/{scope} | [EARLY ACCESS] ListSubscriptions: List the set of Subscription definitions |
| [**UpsertSubscription**](SubscriptionsApi.md#upsertsubscription) | **POST** /api/subscriptions/holdings | [EARLY ACCESS] UpsertSubscription: Upsert a Subscription. This creates or updates the subscription definition in LUSID. |

<a id="deletesubscription"></a>
# **DeleteSubscription**
> AnnulSingleStructuredDataResponse DeleteSubscription (string scope, string code)

[EARLY ACCESS] DeleteSubscription: Delete a Subscription, assuming that it is present.

Delete the specified Subscription definition from a single scope.                The response will return either detail of the deleted item, or an explanation (failure) as to why this did not succeed.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SubscriptionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SubscriptionsApi>();
            var scope = "scope_example";  // string | The scope of the Subscription to delete.
            var code = "code_example";  // string | The Subscription to delete.

            try
            {
                // uncomment the below to set overrides at the request level
                // AnnulSingleStructuredDataResponse result = apiInstance.DeleteSubscription(scope, code, opts: opts);

                // [EARLY ACCESS] DeleteSubscription: Delete a Subscription, assuming that it is present.
                AnnulSingleStructuredDataResponse result = apiInstance.DeleteSubscription(scope, code);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SubscriptionsApi.DeleteSubscription: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] DeleteSubscription: Delete a Subscription, assuming that it is present.
    ApiResponse<AnnulSingleStructuredDataResponse> response = apiInstance.DeleteSubscriptionWithHttpInfo(scope, code);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SubscriptionsApi.DeleteSubscriptionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Subscription to delete. |  |
| **code** | **string** | The Subscription to delete. |  |

### Return type

[**AnnulSingleStructuredDataResponse**](AnnulSingleStructuredDataResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The AsAt of deletion or failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="getsubscription"></a>
# **GetSubscription**
> GetSubscriptionResponse GetSubscription (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetSubscription: Get Subscription

Get a Subscription definition from a single scope.                The response will return either the subscription that has been stored, or a failure explaining why the request was unsuccessful.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SubscriptionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SubscriptionsApi>();
            var scope = "scope_example";  // string | The scope of the Subscription to retrieve.
            var code = "code_example";  // string | The code of the Subscription to retrieve.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Subscription. Defaults to return the latest version if not specified. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // GetSubscriptionResponse result = apiInstance.GetSubscription(scope, code, asAt, opts: opts);

                // [EARLY ACCESS] GetSubscription: Get Subscription
                GetSubscriptionResponse result = apiInstance.GetSubscription(scope, code, asAt);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SubscriptionsApi.GetSubscription: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetSubscription: Get Subscription
    ApiResponse<GetSubscriptionResponse> response = apiInstance.GetSubscriptionWithHttpInfo(scope, code, asAt);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SubscriptionsApi.GetSubscriptionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Subscription to retrieve. |  |
| **code** | **string** | The code of the Subscription to retrieve. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Subscription. Defaults to return the latest version if not specified. | [optional]  |

### Return type

[**GetSubscriptionResponse**](GetSubscriptionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved Subscription or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="listsubscriptions"></a>
# **ListSubscriptions**
> PagedResourceListOfGetSubscriptionResponse ListSubscriptions (string scope, DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null)

[EARLY ACCESS] ListSubscriptions: List the set of Subscription definitions

List the set of subscription definitions at the specified date/time and scope.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SubscriptionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SubscriptionsApi>();
            var scope = "scope_example";  // string | The scope to list subscriptions for.
            var asAt = DateTimeOffset.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the subscriptions. Defaults to latest if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. (optional) 
            var limit = 56;  // int? | Maximum number of results to return. Defaults to 100. (optional) 
            var page = "page_example";  // string? | Pagination token from a previous result to fetch the next page. (optional) 

            try
            {
                // uncomment the below to set overrides at the request level
                // PagedResourceListOfGetSubscriptionResponse result = apiInstance.ListSubscriptions(scope, asAt, filter, limit, page, opts: opts);

                // [EARLY ACCESS] ListSubscriptions: List the set of Subscription definitions
                PagedResourceListOfGetSubscriptionResponse result = apiInstance.ListSubscriptions(scope, asAt, filter, limit, page);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SubscriptionsApi.ListSubscriptions: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListSubscriptionsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListSubscriptions: List the set of Subscription definitions
    ApiResponse<PagedResourceListOfGetSubscriptionResponse> response = apiInstance.ListSubscriptionsWithHttpInfo(scope, asAt, filter, limit, page);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SubscriptionsApi.ListSubscriptionsWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope to list subscriptions for. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the subscriptions. Defaults to latest if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. | [optional]  |
| **limit** | **int?** | Maximum number of results to return. Defaults to 100. | [optional]  |
| **page** | **string?** | Pagination token from a previous result to fetch the next page. | [optional]  |

### Return type

[**PagedResourceListOfGetSubscriptionResponse**](PagedResourceListOfGetSubscriptionResponse.md)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested subscriptions |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

<a id="upsertsubscription"></a>
# **UpsertSubscription**
> UpsertSingleStructuredDataResponse UpsertSubscription (UpsertSubscriptionRequest upsertSubscriptionRequest)

[EARLY ACCESS] UpsertSubscription: Upsert a Subscription. This creates or updates the subscription definition in LUSID.

Update or insert one Subscription definition. An item will be updated if it already exists  and inserted if it does not.                The referenced portfolio (and timeline, when supplied) must exist and be readable by the caller.                The response will return the successfully updated or inserted subscription or failure message if unsuccessful.

### Example
```csharp
using System.Collections.Generic;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Extensions;
using Lusid.Sdk.Model;
using Newtonsoft.Json;

namespace Examples
{
    public static class Program
    {
        public static void Main()
        {
            var secretsFilename = "secrets.json";
            var path = Path.Combine(Directory.GetCurrentDirectory(), secretsFilename);
            // Replace with the relevant values
            File.WriteAllText(
                path, 
                @"{
                    ""api"": {
                        ""tokenUrl"": ""<your-token-url>"",
                        ""lusidUrl"": ""https://<your-domain>.lusid.com/api"",
                        ""username"": ""<your-username>"",
                        ""password"": ""<your-password>"",
                        ""clientId"": ""<your-client-id>"",
                        ""clientSecret"": ""<your-client-secret>""
                    }
                }");

            // uncomment the below to use configuration overrides
            // var opts = new ConfigurationOptions();
            // opts.TimeoutMs = 30_000;

            // uncomment the below to use an api factory with overrides
            // var apiInstance = ApiFactoryBuilder.Build(secretsFilename, opts: opts).Api<SubscriptionsApi>();

            var apiInstance = ApiFactoryBuilder.Build(secretsFilename).Api<SubscriptionsApi>();
            var upsertSubscriptionRequest = new UpsertSubscriptionRequest(); // UpsertSubscriptionRequest | The Subscription to update or insert

            try
            {
                // uncomment the below to set overrides at the request level
                // UpsertSingleStructuredDataResponse result = apiInstance.UpsertSubscription(upsertSubscriptionRequest, opts: opts);

                // [EARLY ACCESS] UpsertSubscription: Upsert a Subscription. This creates or updates the subscription definition in LUSID.
                UpsertSingleStructuredDataResponse result = apiInstance.UpsertSubscription(upsertSubscriptionRequest);
                Console.WriteLine(JsonConvert.SerializeObject(result, Formatting.Indented));
            }
            catch (ApiException e)
            {
                Console.WriteLine("Exception when calling SubscriptionsApi.UpsertSubscription: " + e.Message);
                Console.WriteLine("Status Code: " + e.ErrorCode);
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertSubscriptionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertSubscription: Upsert a Subscription. This creates or updates the subscription definition in LUSID.
    ApiResponse<UpsertSingleStructuredDataResponse> response = apiInstance.UpsertSubscriptionWithHttpInfo(upsertSubscriptionRequest);
    Console.WriteLine("Status Code: " + response.StatusCode);
    Console.WriteLine("Response Headers: " + JsonConvert.SerializeObject(response.Headers, Formatting.Indented));
    Console.WriteLine("Response Body: " + JsonConvert.SerializeObject(response.Data, Formatting.Indented));
}
catch (ApiException e)
{
    Console.WriteLine("Exception when calling SubscriptionsApi.UpsertSubscriptionWithHttpInfo: " + e.Message);
    Console.WriteLine("Status Code: " + e.ErrorCode);
    Console.WriteLine(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **upsertSubscriptionRequest** | [**UpsertSubscriptionRequest**](UpsertSubscriptionRequest.md) | The Subscription to update or insert |  |

### Return type

[**UpsertSingleStructuredDataResponse**](UpsertSingleStructuredDataResponse.md)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully updated or inserted item or any failure |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[Back to top](#) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to Model list](../README.md#documentation-for-models) &#8226; [Back to README](../README.md)

