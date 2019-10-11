# Lusid.Sdk.Api.DerivedTransactionPortfoliosApi

All URIs are relative to *http://localhost/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDerivedPortfolio**](DerivedTransactionPortfoliosApi.md#createderivedportfolio) | **POST** /api/derivedtransactionportfolios/{scope} | [EARLY ACCESS] Create derived transaction portfolio
[**DeleteDerivedPortfolioDetails**](DerivedTransactionPortfoliosApi.md#deletederivedportfoliodetails) | **DELETE** /api/derivedtransactionportfolios/{scope}/{code}/details | [EARLY ACCESS] Delete portfolio details



## CreateDerivedPortfolio

> Portfolio CreateDerivedPortfolio (string scope, CreateDerivedTransactionPortfolioRequest portfolio = null)

[EARLY ACCESS] Create derived transaction portfolio

Creates a transaction portfolio that derives from an existing transaction portfolio. In a derived portfolio, parts of the portfolio can either be specific to this portfolio, or can be inherited from a \"parent\". Different parts of the portfolio (e.g. transactions or properties) are combined in different ways. The portfolio details are either overridden in entirety, or not at all. The same is true for properties. Transactions on a derived portfolio are merged with its parent portfolio's transactions. If the parent portfolio is itself a derived portfolio, transactions from that parent are also merged (and that parent's portfolio's, if it is also a derived portfolio, and so on).

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
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DerivedTransactionPortfoliosApi(Configuration.Default);
            var scope = scope_example;  // string | The scope into which to create the new derived portfolio
            var portfolio = new CreateDerivedTransactionPortfolioRequest(); // CreateDerivedTransactionPortfolioRequest | The root object of the new derived portfolio, containing a populated reference portfolio id and reference scope (optional) 

            try
            {
                // [EARLY ACCESS] Create derived transaction portfolio
                Portfolio result = apiInstance.CreateDerivedPortfolio(scope, portfolio);
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
 **scope** | **string**| The scope into which to create the new derived portfolio | 
 **portfolio** | [**CreateDerivedTransactionPortfolioRequest**](CreateDerivedTransactionPortfolioRequest.md)| The root object of the new derived portfolio, containing a populated reference portfolio id and reference scope | [optional] 

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
| **201** | The created derived portfolio, with populated id |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## DeleteDerivedPortfolioDetails

> DeletedEntityResponse DeleteDerivedPortfolioDetails (string scope, string code, DateTimeOrCutLabel effectiveAt = null)

[EARLY ACCESS] Delete portfolio details

Deletes the portfolio details for the specified derived transaction portfolio

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
            Configuration.Default.BasePath = "http://localhost/api";
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DerivedTransactionPortfoliosApi(Configuration.Default);
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective date of the change (optional) 

            try
            {
                // [EARLY ACCESS] Delete portfolio details
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
 **scope** | **string**| The scope of the portfolio | 
 **code** | **string**| The code of the portfolio | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective date of the change | [optional] 

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

