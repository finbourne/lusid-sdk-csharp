# Lusid.Sdk.Api.ReferencePortfolioApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateReferencePortfolio**](ReferencePortfolioApi.md#createreferenceportfolio) | **POST** /api/referenceportfolios/{scope} | Create reference portfolio
[**GetReferencePortfolioConstituents**](ReferencePortfolioApi.md#getreferenceportfolioconstituents) | **GET** /api/referenceportfolios/{scope}/{code}/{effectiveAt}/constituents | Get constituents
[**UpsertReferencePortfolioConstituents**](ReferencePortfolioApi.md#upsertreferenceportfolioconstituents) | **POST** /api/referenceportfolios/{scope}/{code}/constituents | Add constituents


<a name="createreferenceportfolio"></a>
# **CreateReferencePortfolio**
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

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getreferenceportfolioconstituents"></a>
# **GetReferencePortfolioConstituents**
> GetReferencePortfolioConstituentsResponse GetReferencePortfolioConstituents (string scope, string code, DateTimeOffset? effectiveAt, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null)

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
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective date of the constituents to retrieve
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many (optional) 

            try
            {
                // Get constituents
                GetReferencePortfolioConstituentsResponse result = apiInstance.GetReferencePortfolioConstituents(scope, code, effectiveAt, asAt, sortBy, start, limit);
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
 **effectiveAt** | **DateTimeOffset?**| The effective date of the constituents to retrieve | 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many | [optional] 

### Return type

[**GetReferencePortfolioConstituentsResponse**](GetReferencePortfolioConstituentsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertreferenceportfolioconstituents"></a>
# **UpsertReferencePortfolioConstituents**
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

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

