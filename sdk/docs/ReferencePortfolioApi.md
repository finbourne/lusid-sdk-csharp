# Lusid.Sdk.Api.ReferencePortfolioApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateReferencePortfolio**](ReferencePortfolioApi.md#createreferenceportfolio) | **POST** /api/referenceportfolios/{scope} | Create reference portfolio
[**GetReferencePortfolioConstituents**](ReferencePortfolioApi.md#getreferenceportfolioconstituents) | **GET** /api/referenceportfolios/{scope}/{code}/constituents | Get constituents
[**ListConstituentsAdjustments**](ReferencePortfolioApi.md#listconstituentsadjustments) | **GET** /api/referenceportfolios/{scope}/{code}/constituentsadjustments | List constituents adjustments
[**UpsertReferencePortfolioConstituents**](ReferencePortfolioApi.md#upsertreferenceportfolioconstituents) | **POST** /api/referenceportfolios/{scope}/{code}/constituents | Add constituents


<a name="createreferenceportfolio"></a>
# **CreateReferencePortfolio**
> Portfolio CreateReferencePortfolio (string scope, CreateReferencePortfolioRequest referencePortfolio)

Create reference portfolio

Create a new reference portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateReferencePortfolioExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReferencePortfolioApi(Configuration.Default);
            var scope = scope_example;  // string | The intended scope of the portfolio
            var referencePortfolio = new CreateReferencePortfolioRequest(); // CreateReferencePortfolioRequest | The portfolio creation request object

            try
            {
                // Create reference portfolio
                Portfolio result = apiInstance.CreateReferencePortfolio(scope, referencePortfolio);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferencePortfolioApi.CreateReferencePortfolio: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The intended scope of the portfolio | 
 **referencePortfolio** | [**CreateReferencePortfolioRequest**](CreateReferencePortfolioRequest.md)| The portfolio creation request object | 

### Return type

[**Portfolio**](Portfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created reference portfolio, with populated id |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreferenceportfolioconstituents"></a>
# **GetReferencePortfolioConstituents**
> GetReferencePortfolioConstituentsResponse GetReferencePortfolioConstituents (string scope, string code, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null, List<string> propertyKeys = null)

Get constituents

Get constituents from the specified reference portfolio at an effective time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetReferencePortfolioConstituentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReferencePortfolioApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the reference portfolio.
            var code = code_example;  // string | The code of the reference portfolio. Together with the scope this uniquely identifies              the reference portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective date of the constituents to retrieve. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve constituents. Defaults to return the latest version              of each constituent if not specified. (optional) 
            var propertyKeys = new List<string>(); // List<string> | A list of property keys from the \"Instrument\" or \"ReferenceHolding\" domain to decorate onto              the constituents. These take the format {domain}/{scope}/{code} e.g. \"Instrument/system/Name\" or              \"ReferenceHolding/strategy/quantsignal\". Defaults to return all available instrument and reference holding properties if not specified. (optional) 

            try
            {
                // Get constituents
                GetReferencePortfolioConstituentsResponse result = apiInstance.GetReferencePortfolioConstituents(scope, code, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferencePortfolioApi.GetReferencePortfolioConstituents: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the reference portfolio. | 
 **code** | **string**| The code of the reference portfolio. Together with the scope this uniquely identifies              the reference portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective date of the constituents to retrieve. Defaults to the current LUSID system datetime if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve constituents. Defaults to return the latest version              of each constituent if not specified. | [optional] 
 **propertyKeys** | [**List&lt;string&gt;**](string.md)| A list of property keys from the \&quot;Instrument\&quot; or \&quot;ReferenceHolding\&quot; domain to decorate onto              the constituents. These take the format {domain}/{scope}/{code} e.g. \&quot;Instrument/system/Name\&quot; or              \&quot;ReferenceHolding/strategy/quantsignal\&quot;. Defaults to return all available instrument and reference holding properties if not specified. | [optional] 

### Return type

[**GetReferencePortfolioConstituentsResponse**](GetReferencePortfolioConstituentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested reference portfolio constituents |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listconstituentsadjustments"></a>
# **ListConstituentsAdjustments**
> ResourceListOfConstituentsAdjustmentHeader ListConstituentsAdjustments (string scope, string code, DateTimeOrCutLabel fromEffectiveAt, DateTimeOrCutLabel toEffectiveAt, DateTimeOffset? asAtTime = null)

List constituents adjustments

List the constituent adjustments made to the specified reference portfolio over a specified interval of effective time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListConstituentsAdjustmentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReferencePortfolioApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | Code for the portfolio
            var fromEffectiveAt = fromEffectiveAt_example;  // DateTimeOrCutLabel | Events between this time (inclusive) and the toEffectiveAt are returned.
            var toEffectiveAt = toEffectiveAt_example;  // DateTimeOrCutLabel | Events between this time (inclusive) and the fromEffectiveAt are returned.
            var asAtTime = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The as-at time for which the result is valid. (optional) 

            try
            {
                // List constituents adjustments
                ResourceListOfConstituentsAdjustmentHeader result = apiInstance.ListConstituentsAdjustments(scope, code, fromEffectiveAt, toEffectiveAt, asAtTime);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferencePortfolioApi.ListConstituentsAdjustments: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| Code for the portfolio | 
 **fromEffectiveAt** | **DateTimeOrCutLabel**| Events between this time (inclusive) and the toEffectiveAt are returned. | 
 **toEffectiveAt** | **DateTimeOrCutLabel**| Events between this time (inclusive) and the fromEffectiveAt are returned. | 
 **asAtTime** | **DateTimeOffset?**| The as-at time for which the result is valid. | [optional] 

### Return type

[**ResourceListOfConstituentsAdjustmentHeader**](ResourceListOfConstituentsAdjustmentHeader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertreferenceportfolioconstituents"></a>
# **UpsertReferencePortfolioConstituents**
> UpsertReferencePortfolioConstituentsResponse UpsertReferencePortfolioConstituents (string scope, string code, UpsertReferencePortfolioConstituentsRequest constituents)

Add constituents

Add constituents to the specified reference portfolio.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertReferencePortfolioConstituentsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReferencePortfolioApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var constituents = new UpsertReferencePortfolioConstituentsRequest(); // UpsertReferencePortfolioConstituentsRequest | The constituents to upload to the portfolio

            try
            {
                // Add constituents
                UpsertReferencePortfolioConstituentsResponse result = apiInstance.UpsertReferencePortfolioConstituents(scope, code, constituents);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ReferencePortfolioApi.UpsertReferencePortfolioConstituents: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| The code of the portfolio | 
 **constituents** | [**UpsertReferencePortfolioConstituentsRequest**](UpsertReferencePortfolioConstituentsRequest.md)| The constituents to upload to the portfolio | 

### Return type

[**UpsertReferencePortfolioConstituentsResponse**](UpsertReferencePortfolioConstituentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

