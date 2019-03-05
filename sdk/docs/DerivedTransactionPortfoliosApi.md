# Lusid.Sdk.Api.DerivedTransactionPortfoliosApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDerivedPortfolio**](DerivedTransactionPortfoliosApi.md#createderivedportfolio) | **POST** /api/derivedtransactionportfolios/{scope} | Create derived transaction portfolio
[**DeleteDerivedPortfolioDetails**](DerivedTransactionPortfoliosApi.md#deletederivedportfoliodetails) | **DELETE** /api/derivedtransactionportfolios/{scope}/{code}/details | Delete portfolio details


<a name="createderivedportfolio"></a>
# **CreateDerivedPortfolio**
> Portfolio CreateDerivedPortfolio (string scope, CreateDerivedTransactionPortfolioRequest portfolio = null)

Create derived transaction portfolio

Creates a transaction portfolio that derives from an existing transaction portfolio. In a derived portfolio, parts of the portfolio can either be specific to this portfolio, or can be inherited from a \"parent\". Different parts of the portfolio (e.g. transactions or properties) are combined in different ways. The portfolio details are either overridden in entirety, or not at all. The same is true for properties. Transactions on a derived portfolio are merged with its parent portfolio's transactions. If the parent portfolio is itself a derived portfolio, transactions from that parent are also merged (and that parent's portfolio's, if it is also a derived portfolio, and so on).

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateDerivedPortfolioExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DerivedTransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope into which to create the new derived portfolio
            var portfolio = new CreateDerivedTransactionPortfolioRequest(); // CreateDerivedTransactionPortfolioRequest | The root object of the new derived portfolio, containing a populated reference portfolio id and reference scope (optional) 

            try
            {
                // Create derived transaction portfolio
                Portfolio result = apiInstance.CreateDerivedPortfolio(scope, portfolio);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DerivedTransactionPortfoliosApi.CreateDerivedPortfolio: " + e.Message );
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

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletederivedportfoliodetails"></a>
# **DeleteDerivedPortfolioDetails**
> DeletedEntityResponse DeleteDerivedPortfolioDetails (string scope, string code, DateTimeOffset? effectiveAt = null)

Delete portfolio details

Deletes the portfolio details for the specified derived transaction portfolio

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteDerivedPortfolioDetailsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DerivedTransactionPortfoliosApi();
            var scope = scope_example;  // string | The scope of the portfolio
            var code = code_example;  // string | The code of the portfolio
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The effective date of the change (optional) 

            try
            {
                // Delete portfolio details
                DeletedEntityResponse result = apiInstance.DeleteDerivedPortfolioDetails(scope, code, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling DerivedTransactionPortfoliosApi.DeleteDerivedPortfolioDetails: " + e.Message );
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
 **effectiveAt** | **DateTimeOffset?**| The effective date of the change | [optional] 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

