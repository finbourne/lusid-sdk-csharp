# Lusid.Sdk.Api.DerivedTransactionPortfoliosApi

All URIs are relative to *http://local-unit-test-server.lusid.com:61923*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDerivedPortfolio**](DerivedTransactionPortfoliosApi.md#createderivedportfolio) | **POST** /api/derivedtransactionportfolios/{scope} | [EARLY ACCESS] Create derived portfolio
[**DeleteDerivedPortfolioDetails**](DerivedTransactionPortfoliosApi.md#deletederivedportfoliodetails) | **DELETE** /api/derivedtransactionportfolios/{scope}/{code}/details | [EARLY ACCESS] Delete derived portfolio details



## CreateDerivedPortfolio

> Portfolio CreateDerivedPortfolio (string scope, CreateDerivedTransactionPortfolioRequest createDerivedTransactionPortfolioRequest = null)

[EARLY ACCESS] Create derived portfolio

Create a derived transaction portfolio from a parent transaction portfolio (which may itself be derived).

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateDerivedPortfolioExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://local-unit-test-server.lusid.com:61923";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DerivedTransactionPortfoliosApi(Configuration.Default);
            var scope = scope_example;  // string | The scope in which to create the derived transaction portfolio.
            var createDerivedTransactionPortfolioRequest = new CreateDerivedTransactionPortfolioRequest(); // CreateDerivedTransactionPortfolioRequest | The definition of the derived transaction portfolio. (optional) 

            try
            {
                // [EARLY ACCESS] Create derived portfolio
                Portfolio result = apiInstance.CreateDerivedPortfolio(scope, createDerivedTransactionPortfolioRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DerivedTransactionPortfoliosApi.CreateDerivedPortfolio: " + e.Message );
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
 **scope** | **string**| The scope in which to create the derived transaction portfolio. | 
 **createDerivedTransactionPortfolioRequest** | [**CreateDerivedTransactionPortfolioRequest**](CreateDerivedTransactionPortfolioRequest.md)| The definition of the derived transaction portfolio. | [optional] 

### Return type

[**Portfolio**](Portfolio.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
- **Accept**: text/plain, application/json, text/json

### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The created derived portfolio, with populated id |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteDerivedPortfolioDetails

> DeletedEntityResponse DeleteDerivedPortfolioDetails (string scope, string code, DateTimeOrCutLabel effectiveAt = null)

[EARLY ACCESS] Delete derived portfolio details

Delete all the portfolio details for a derived transaction portfolio.

### Example

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteDerivedPortfolioDetailsExample
    {
        public static void Main()
        {
            Configuration.Default.BasePath = "http://local-unit-test-server.lusid.com:61923";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DerivedTransactionPortfoliosApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the derived transaction portfolio.
            var code = code_example;  // string | The code of the derived transaction portfolio. Together with the scope this uniquely identifies              the derived transaction portfolio.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective date of the change. (optional) 

            try
            {
                // [EARLY ACCESS] Delete derived portfolio details
                DeletedEntityResponse result = apiInstance.DeleteDerivedPortfolioDetails(scope, code, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling DerivedTransactionPortfoliosApi.DeleteDerivedPortfolioDetails: " + e.Message );
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
 **scope** | **string**| The scope of the derived transaction portfolio. | 
 **code** | **string**| The code of the derived transaction portfolio. Together with the scope this uniquely identifies              the derived transaction portfolio. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective date of the change. | [optional] 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

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

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

