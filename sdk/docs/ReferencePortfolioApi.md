# Lusid.Sdk.Api.ReferencePortfolioApi

All URIs are relative to *http://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateReferencePortfolio**](ReferencePortfolioApi.md#createreferenceportfolio) | **POST** /api/referenceportfolios/{scope} | Create reference portfolio
[**GetReferencePortfolioConstituents**](ReferencePortfolioApi.md#getreferenceportfolioconstituents) | **GET** /api/referenceportfolios/{scope}/{code}/constituents | Get constituents
[**ListConstituentsAdjustments**](ReferencePortfolioApi.md#listconstituentsadjustments) | **GET** /api/referenceportfolios/{scope}/{code}/constituentsadjustments | Gets constituents adjustments in an interval of effective time.
[**UpsertReferencePortfolioConstituents**](ReferencePortfolioApi.md#upsertreferenceportfolioconstituents) | **POST** /api/referenceportfolios/{scope}/{code}/constituents | Add constituents



## CreateReferencePortfolio

> Portfolio CreateReferencePortfolio (string scope, CreateReferencePortfolioRequest referencePortfolio = null)

Create reference portfolio

Create a new reference portfolio.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateReferencePortfolioExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReferencePortfolioApi();
            var scope = scope_example;  // string | The intended scope of the portfolio
            var referencePortfolio = new CreateReferencePortfolioRequest(); // CreateReferencePortfolioRequest | The portfolio creation request object (optional) 

            try
            {
                // Create reference portfolio
                Portfolio result = apiInstance.CreateReferencePortfolio(scope, referencePortfolio);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReferencePortfolioApi.CreateReferencePortfolio: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The intended scope of the portfolio | 
 **referencePortfolio** | [**CreateReferencePortfolioRequest**](CreateReferencePortfolioRequest.md)| The portfolio creation request object | [optional] 

### Return type

[**Portfolio**](Portfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetReferencePortfolioConstituents

> GetReferencePortfolioConstituentsResponse GetReferencePortfolioConstituents (string scope, string code, string effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, List<string> instrumentPropertyKeys = null)

Get constituents

Get all the constituents in the specified reference portfolio

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetReferencePortfolioConstituentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReferencePortfolioApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = effectiveAt_example;  // string | Optional. The effective date of the constituents to retrieve (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many (optional) 
            var instrumentPropertyKeys = new List<string>(); // List<string> | Optional. The Properties of the constituents (optional) 

            try
            {
                // Get constituents
                GetReferencePortfolioConstituentsResponse result = apiInstance.GetReferencePortfolioConstituents(scope, code, effectiveAt, asAt, sortBy, start, limit, instrumentPropertyKeys);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReferencePortfolioApi.GetReferencePortfolioConstituents: " + e.Message );
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
 **effectiveAt** | **string**| Optional. The effective date of the constituents to retrieve | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many | [optional] 
 **instrumentPropertyKeys** | [**List&lt;string&gt;**](string.md)| Optional. The Properties of the constituents | [optional] 

### Return type

[**GetReferencePortfolioConstituentsResponse**](GetReferencePortfolioConstituentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListConstituentsAdjustments

> ResourceListOfConstituentsAdjustmentHeader ListConstituentsAdjustments (string scope, string code, string fromEffectiveAt = null, string toEffectiveAt = null, DateTimeOffset? asAtTime = null)

Gets constituents adjustments in an interval of effective time.

Specify a time period in which you'd like to see the list of times that adjustments where made to this portfolio

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListConstituentsAdjustmentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReferencePortfolioApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | Code for the portfolio
            var fromEffectiveAt = fromEffectiveAt_example;  // string | Events between this time (inclusive) and the toEffectiveAt are returned. (optional) 
            var toEffectiveAt = toEffectiveAt_example;  // string | Events between this time (inclusive) and the fromEffectiveAt are returned. (optional) 
            var asAtTime = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The as-at time for which the result is valid. (optional) 

            try
            {
                // Gets constituents adjustments in an interval of effective time.
                ResourceListOfConstituentsAdjustmentHeader result = apiInstance.ListConstituentsAdjustments(scope, code, fromEffectiveAt, toEffectiveAt, asAtTime);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReferencePortfolioApi.ListConstituentsAdjustments: " + e.Message );
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
 **fromEffectiveAt** | **string**| Events between this time (inclusive) and the toEffectiveAt are returned. | [optional] 
 **toEffectiveAt** | **string**| Events between this time (inclusive) and the fromEffectiveAt are returned. | [optional] 
 **asAtTime** | **DateTimeOffset?**| The as-at time for which the result is valid. | [optional] 

### Return type

[**ResourceListOfConstituentsAdjustmentHeader**](ResourceListOfConstituentsAdjustmentHeader.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## UpsertReferencePortfolioConstituents

> UpsertReferencePortfolioConstituentsResponse UpsertReferencePortfolioConstituents (string scope, string code, UpsertReferencePortfolioConstituentsRequest constituents = null)

Add constituents

Add constituents to the specified reference portfolio.

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertReferencePortfolioConstituentsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ReferencePortfolioApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var constituents = new UpsertReferencePortfolioConstituentsRequest(); // UpsertReferencePortfolioConstituentsRequest | The constituents to upload to the portfolio (optional) 

            try
            {
                // Add constituents
                UpsertReferencePortfolioConstituentsResponse result = apiInstance.UpsertReferencePortfolioConstituents(scope, code, constituents);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ReferencePortfolioApi.UpsertReferencePortfolioConstituents: " + e.Message );
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
 **constituents** | [**UpsertReferencePortfolioConstituentsRequest**](UpsertReferencePortfolioConstituentsRequest.md)| The constituents to upload to the portfolio | [optional] 

### Return type

[**UpsertReferencePortfolioConstituentsResponse**](UpsertReferencePortfolioConstituentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

