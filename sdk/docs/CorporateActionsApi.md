# Lusid.Sdk.Api.CorporateActionsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**BatchUpsertCorporateActions**](CorporateActionsApi.md#batchupsertcorporateactions) | **POST** /api/corporateactions/{scope}/{code} | Upsert corporate actions
[**GetCorporateActions**](CorporateActionsApi.md#getcorporateactions) | **GET** /api/corporateactions/{scope}/{code} | Get corporate actions


<a name="batchupsertcorporateactions"></a>
# **BatchUpsertCorporateActions**
> UpsertCorporateActionsResponse BatchUpsertCorporateActions (string scope, string code, List<CreateCorporateAction> actions = null)

Upsert corporate actions

Attempt to create/update one or more corporate action in a specified corporate action source. Failed actions will be identified in the body of the response.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class BatchUpsertCorporateActionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionsApi();
            var scope = scope_example;  // string | The scope of corporate action source
            var code = code_example;  // string | The code of the corporate action source
            var actions = new List<CreateCorporateAction>(); // List<CreateCorporateAction> | The corporate action definitions (optional) 

            try
            {
                // Upsert corporate actions
                UpsertCorporateActionsResponse result = apiInstance.BatchUpsertCorporateActions(scope, code, actions);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporateActionsApi.BatchUpsertCorporateActions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of corporate action source | 
 **code** | **string**| The code of the corporate action source | 
 **actions** | [**List&lt;CreateCorporateAction&gt;**](CreateCorporateAction.md)| The corporate action definitions | [optional] 

### Return type

[**UpsertCorporateActionsResponse**](UpsertCorporateActionsResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcorporateactions"></a>
# **GetCorporateActions**
> ResourceListOfCorporateAction GetCorporateActions (string scope, string code, DateTimeOffset? effectiveAt = null, DateTimeOffset? asAt = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

Get corporate actions

Gets corporate actions from a specific corporate action source

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetCorporateActionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new CorporateActionsApi();
            var scope = scope_example;  // string | The scope of the corporate action source
            var code = code_example;  // string | The code of the corporate action source
            var effectiveAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The effective date of the data (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The AsAt date of the data (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // Get corporate actions
                ResourceListOfCorporateAction result = apiInstance.GetCorporateActions(scope, code, effectiveAt, asAt, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling CorporateActionsApi.GetCorporateActions: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the corporate action source | 
 **code** | **string**| The code of the corporate action source | 
 **effectiveAt** | **DateTimeOffset?**| Optional. The effective date of the data | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The AsAt date of the data | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ResourceListOfCorporateAction**](ResourceListOfCorporateAction.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

