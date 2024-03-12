# Lusid.Sdk.Api.FundsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateFund**](FundsApi.md#createfund) | **POST** /api/funds/{scope} | [EXPERIMENTAL] CreateFund: Create a Fund. |
| [**DeleteFund**](FundsApi.md#deletefund) | **DELETE** /api/funds/{scope}/{code} | [EXPERIMENTAL] DeleteFund: Delete a Fund. |
| [**GetFund**](FundsApi.md#getfund) | **GET** /api/funds/{scope}/{code} | [EXPERIMENTAL] GetFund: Get a Fund. |
| [**ListFunds**](FundsApi.md#listfunds) | **GET** /api/funds | [EXPERIMENTAL] ListFunds: List Funds. |
| [**UpsertFundProperties**](FundsApi.md#upsertfundproperties) | **POST** /api/funds/{scope}/{code}/properties/$upsert | [EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties |

<a id="createfund"></a>
# **CreateFund**
> Fund CreateFund (string scope, FundRequest fundRequest)

[EXPERIMENTAL] CreateFund: Create a Fund.

Create the given Fund.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateFundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var fundRequest = new FundRequest(); // FundRequest | The definition of the Fund.

            try
            {
                // [EXPERIMENTAL] CreateFund: Create a Fund.
                Fund result = apiInstance.CreateFund(scope, fundRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.CreateFund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateFund: Create a Fund.
    ApiResponse<Fund> response = apiInstance.CreateFundWithHttpInfo(scope, fundRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.CreateFundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **fundRequest** | [**FundRequest**](FundRequest.md) | The definition of the Fund. |  |

### Return type

[**Fund**](Fund.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Fund. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletefund"></a>
# **DeleteFund**
> DeletedEntityResponse DeleteFund (string scope, string code)

[EXPERIMENTAL] DeleteFund: Delete a Fund.

Delete the given Fund.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteFundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund to be deleted.
            var code = "code_example";  // string | The code of the Fund to be deleted. Together with the scope this uniquely identifies the Fund.

            try
            {
                // [EXPERIMENTAL] DeleteFund: Delete a Fund.
                DeletedEntityResponse result = apiInstance.DeleteFund(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.DeleteFund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteFund: Delete a Fund.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteFundWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.DeleteFundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund to be deleted. |  |
| **code** | **string** | The code of the Fund to be deleted. Together with the scope this uniquely identifies the Fund. |  |

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
| **200** | The datetime that the Fund was deleted |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getfund"></a>
# **GetFund**
> Fund GetFund (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetFund: Get a Fund.

Retrieve the definition of a particular Fund.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetFundExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund.
            var code = "code_example";  // string | The code of the Fund. Together with the scope this uniquely identifies the Fund.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the Fund properties. Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Fund definition. Defaults to returning the latest version of the Fund definition if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Fund' domain to decorate onto the Fund.              These must take the format {domain}/{scope}/{code}, for example 'Fund/Manager/Id'. If no properties are specified, then no properties will be returned. (optional) 

            try
            {
                // [EXPERIMENTAL] GetFund: Get a Fund.
                Fund result = apiInstance.GetFund(scope, code, effectiveAt, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.GetFund: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetFundWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetFund: Get a Fund.
    ApiResponse<Fund> response = apiInstance.GetFundWithHttpInfo(scope, code, effectiveAt, asAt, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.GetFundWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund. |  |
| **code** | **string** | The code of the Fund. Together with the scope this uniquely identifies the Fund. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the Fund properties. Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Fund definition. Defaults to returning the latest version of the Fund definition if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Fund&#39; domain to decorate onto the Fund.              These must take the format {domain}/{scope}/{code}, for example &#39;Fund/Manager/Id&#39;. If no properties are specified, then no properties will be returned. | [optional]  |

### Return type

[**Fund**](Fund.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Fund definition. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listfunds"></a>
# **ListFunds**
> PagedResourceListOfFund ListFunds (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListFunds: List Funds.

List all the Funds matching particular criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListFundsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to list the TimeVariant properties for the Funds. Defaults to the current LUSID              system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Funds. Defaults to returning the latest version of each Fund if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Funds; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For example, to filter on the Fund type, specify \"id.Code eq 'Fund1'\". For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the 'Fund' domain to decorate onto each Fund.              These must take the format {domain}/{scope}/{code}, for example 'Fund/Manager/Id'. (optional) 

            try
            {
                // [EXPERIMENTAL] ListFunds: List Funds.
                PagedResourceListOfFund result = apiInstance.ListFunds(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.ListFunds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListFundsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListFunds: List Funds.
    ApiResponse<PagedResourceListOfFund> response = apiInstance.ListFundsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.ListFundsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to list the TimeVariant properties for the Funds. Defaults to the current LUSID              system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Funds. Defaults to returning the latest version of each Fund if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Funds; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For example, to filter on the Fund type, specify \&quot;id.Code eq &#39;Fund1&#39;\&quot;. For more information about filtering              results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the &#39;Fund&#39; domain to decorate onto each Fund.              These must take the format {domain}/{scope}/{code}, for example &#39;Fund/Manager/Id&#39;. | [optional]  |

### Return type

[**PagedResourceListOfFund**](PagedResourceListOfFund.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Funds. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertfundproperties"></a>
# **UpsertFundProperties**
> FundProperties UpsertFundProperties (string scope, string code, Dictionary<string, Property>? requestBody = null)

[EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties

Update or insert one or more properties onto a single Fund. A property will be updated if it  already exists and inserted if it does not. All properties must be of the domain 'Fund'.                Upserting a property that exists for an Fund, with a null value, will delete the instance of the property for that group.                Properties have an <i>effectiveFrom</i> datetime for which the property is valid, and an <i>effectiveUntil</i>  datetime until which the property is valid. Not supplying an <i>effectiveUntil</i> datetime results in the property being  valid indefinitely, or until the next <i>effectiveFrom</i> datetime of the property.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertFundPropertiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new FundsApi(config);
            var scope = "scope_example";  // string | The scope of the Fund to update or insert the properties onto.
            var code = "code_example";  // string | The code of the Fund to update or insert the properties onto. Together with the scope this uniquely identifies the Fund.
            var requestBody = new Dictionary<string, Property>?(); // Dictionary<string, Property>? | The properties to be updated or inserted onto the Fund. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \"Fund/Manager/Id\". (optional) 

            try
            {
                // [EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties
                FundProperties result = apiInstance.UpsertFundProperties(scope, code, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling FundsApi.UpsertFundProperties: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertFundPropertiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertFundProperties: Upsert Fund properties
    ApiResponse<FundProperties> response = apiInstance.UpsertFundPropertiesWithHttpInfo(scope, code, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling FundsApi.UpsertFundPropertiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the Fund to update or insert the properties onto. |  |
| **code** | **string** | The code of the Fund to update or insert the properties onto. Together with the scope this uniquely identifies the Fund. |  |
| **requestBody** | [**Dictionary&lt;string, Property&gt;?**](Property.md) | The properties to be updated or inserted onto the Fund. Each property in               the request must be keyed by its unique property key. This has the format {domain}/{scope}/{code} e.g. \&quot;Fund/Manager/Id\&quot;. | [optional]  |

### Return type

[**FundProperties**](FundProperties.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The updated or inserted properties |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

