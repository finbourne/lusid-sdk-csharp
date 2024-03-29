# Lusid.Sdk.Api.InstrumentEventTypesApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransactionTemplate**](InstrumentEventTypesApi.md#createtransactiontemplate) | **POST** /api/instrumenteventtypes/{instrumentEventType}/transactiontemplates/{instrumentType}/{scope} | [EXPERIMENTAL] CreateTransactionTemplate: Create Transaction Template |
| [**DeleteTransactionTemplate**](InstrumentEventTypesApi.md#deletetransactiontemplate) | **DELETE** /api/instrumenteventtypes/{instrumentEventType}/transactiontemplates/{instrumentType}/{scope} | [EXPERIMENTAL] DeleteTransactionTemplate: Delete Transaction Template |
| [**GetTransactionTemplate**](InstrumentEventTypesApi.md#gettransactiontemplate) | **GET** /api/instrumenteventtypes/{instrumentEventType}/transactiontemplates/{instrumentType}/{scope} | [EXPERIMENTAL] GetTransactionTemplate: Get Transaction Template |
| [**GetTransactionTemplateSpecification**](InstrumentEventTypesApi.md#gettransactiontemplatespecification) | **GET** /api/instrumenteventtypes/{instrumentEventType}/transactiontemplatespecification | [EXPERIMENTAL] GetTransactionTemplateSpecification: Get Transaction Template Specification. |
| [**ListTransactionTemplateSpecifications**](InstrumentEventTypesApi.md#listtransactiontemplatespecifications) | **GET** /api/instrumenteventtypes/transactiontemplatespecifications | [EXPERIMENTAL] ListTransactionTemplateSpecifications: List Transaction Template Specifications. |
| [**ListTransactionTemplates**](InstrumentEventTypesApi.md#listtransactiontemplates) | **GET** /api/instrumenteventtypes/transactiontemplates | [EXPERIMENTAL] ListTransactionTemplates: List Transaction Templates |
| [**UpdateTransactionTemplate**](InstrumentEventTypesApi.md#updatetransactiontemplate) | **PUT** /api/instrumenteventtypes/{instrumentEventType}/transactiontemplates/{instrumentType}/{scope} | [EXPERIMENTAL] UpdateTransactionTemplate: Update Transaction Template |

<a id="createtransactiontemplate"></a>
# **CreateTransactionTemplate**
> TransactionTemplate CreateTransactionTemplate (string instrumentEventType, string instrumentType, string scope, TransactionTemplateRequest transactionTemplateRequest)

[EXPERIMENTAL] CreateTransactionTemplate: Create Transaction Template

Create a transaction template for a particular instrument event type in a scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateTransactionTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentEventTypesApi(config);
            var instrumentEventType = "instrumentEventType_example";  // string | The type of instrument events that the template is applied to.
            var instrumentType = "instrumentType_example";  // string | The instrument type of the transaction template. The combination of the instrument              event type, instrument type and scope uniquely identifies a transaction template
            var scope = "scope_example";  // string | The scope in which the template lies.
            var transactionTemplateRequest = new TransactionTemplateRequest(); // TransactionTemplateRequest | A request defining a new transaction template to be created.

            try
            {
                // [EXPERIMENTAL] CreateTransactionTemplate: Create Transaction Template
                TransactionTemplate result = apiInstance.CreateTransactionTemplate(instrumentEventType, instrumentType, scope, transactionTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentEventTypesApi.CreateTransactionTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTransactionTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateTransactionTemplate: Create Transaction Template
    ApiResponse<TransactionTemplate> response = apiInstance.CreateTransactionTemplateWithHttpInfo(instrumentEventType, instrumentType, scope, transactionTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentEventTypesApi.CreateTransactionTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instrumentEventType** | **string** | The type of instrument events that the template is applied to. |  |
| **instrumentType** | **string** | The instrument type of the transaction template. The combination of the instrument              event type, instrument type and scope uniquely identifies a transaction template |  |
| **scope** | **string** | The scope in which the template lies. |  |
| **transactionTemplateRequest** | [**TransactionTemplateRequest**](TransactionTemplateRequest.md) | A request defining a new transaction template to be created. |  |

### Return type

[**TransactionTemplate**](TransactionTemplate.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The response of the transaction template that was created. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetransactiontemplate"></a>
# **DeleteTransactionTemplate**
> DateTimeOffset DeleteTransactionTemplate (string instrumentEventType, string instrumentType, string scope)

[EXPERIMENTAL] DeleteTransactionTemplate: Delete Transaction Template

Delete a transaction template for a particular instrument event type in a scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteTransactionTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentEventTypesApi(config);
            var instrumentEventType = "instrumentEventType_example";  // string | The type of instrument events that the template is applied to.
            var instrumentType = "instrumentType_example";  // string | The instrument type of the transaction template. The combination of the instrument              event type, instrument type and scope uniquely identifies a transaction template
            var scope = "scope_example";  // string | The scope of the template.

            try
            {
                // [EXPERIMENTAL] DeleteTransactionTemplate: Delete Transaction Template
                DateTimeOffset result = apiInstance.DeleteTransactionTemplate(instrumentEventType, instrumentType, scope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentEventTypesApi.DeleteTransactionTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTransactionTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteTransactionTemplate: Delete Transaction Template
    ApiResponse<DateTimeOffset> response = apiInstance.DeleteTransactionTemplateWithHttpInfo(instrumentEventType, instrumentType, scope);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentEventTypesApi.DeleteTransactionTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instrumentEventType** | **string** | The type of instrument events that the template is applied to. |  |
| **instrumentType** | **string** | The instrument type of the transaction template. The combination of the instrument              event type, instrument type and scope uniquely identifies a transaction template |  |
| **scope** | **string** | The scope of the template. |  |

### Return type

**DateTimeOffset**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The AsAt Time the Template was deleted. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettransactiontemplate"></a>
# **GetTransactionTemplate**
> TransactionTemplate GetTransactionTemplate (string instrumentEventType, string instrumentType, string scope, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetTransactionTemplate: Get Transaction Template

Gets the Transaction Template that for the instrument event type within the scope specified.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetTransactionTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentEventTypesApi(config);
            var instrumentEventType = "instrumentEventType_example";  // string | The instrument event type of the transaction template
            var instrumentType = "instrumentType_example";  // string | The instrument type of the transaction template. The combination of the instrument              event type, instrument type and scope uniquely identifies a transaction template
            var scope = "scope_example";  // string | The scope in which the template lies. When not supplied the scope is 'default'.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The AsAt time of the requested Transaction Template (optional) 

            try
            {
                // [EXPERIMENTAL] GetTransactionTemplate: Get Transaction Template
                TransactionTemplate result = apiInstance.GetTransactionTemplate(instrumentEventType, instrumentType, scope, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentEventTypesApi.GetTransactionTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetTransactionTemplate: Get Transaction Template
    ApiResponse<TransactionTemplate> response = apiInstance.GetTransactionTemplateWithHttpInfo(instrumentEventType, instrumentType, scope, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentEventTypesApi.GetTransactionTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instrumentEventType** | **string** | The instrument event type of the transaction template |  |
| **instrumentType** | **string** | The instrument type of the transaction template. The combination of the instrument              event type, instrument type and scope uniquely identifies a transaction template |  |
| **scope** | **string** | The scope in which the template lies. When not supplied the scope is &#39;default&#39;. |  |
| **asAt** | **DateTimeOffset?** | The AsAt time of the requested Transaction Template | [optional]  |

### Return type

[**TransactionTemplate**](TransactionTemplate.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The transaction template. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettransactiontemplatespecification"></a>
# **GetTransactionTemplateSpecification**
> TransactionTemplateSpecification GetTransactionTemplateSpecification (string instrumentEventType)

[EXPERIMENTAL] GetTransactionTemplateSpecification: Get Transaction Template Specification.

Retrieve the transaction template specification for a particular event type.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetTransactionTemplateSpecificationExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentEventTypesApi(config);
            var instrumentEventType = "instrumentEventType_example";  // string | The requested instrument event type.

            try
            {
                // [EXPERIMENTAL] GetTransactionTemplateSpecification: Get Transaction Template Specification.
                TransactionTemplateSpecification result = apiInstance.GetTransactionTemplateSpecification(instrumentEventType);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentEventTypesApi.GetTransactionTemplateSpecification: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionTemplateSpecificationWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetTransactionTemplateSpecification: Get Transaction Template Specification.
    ApiResponse<TransactionTemplateSpecification> response = apiInstance.GetTransactionTemplateSpecificationWithHttpInfo(instrumentEventType);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentEventTypesApi.GetTransactionTemplateSpecificationWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instrumentEventType** | **string** | The requested instrument event type. |  |

### Return type

[**TransactionTemplateSpecification**](TransactionTemplateSpecification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested Transaction Template Specification. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtransactiontemplatespecifications"></a>
# **ListTransactionTemplateSpecifications**
> PagedResourceListOfTransactionTemplateSpecification ListTransactionTemplateSpecifications (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListTransactionTemplateSpecifications: List Transaction Template Specifications.

Retrieves all transaction template specifications.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListTransactionTemplateSpecificationsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentEventTypesApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | AsAt of the request (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Transaction Template Specifications from              a previous call to list Transaction Template Specifications.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt              fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\". (optional) 

            try
            {
                // [EXPERIMENTAL] ListTransactionTemplateSpecifications: List Transaction Template Specifications.
                PagedResourceListOfTransactionTemplateSpecification result = apiInstance.ListTransactionTemplateSpecifications(asAt, page, limit, filter, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentEventTypesApi.ListTransactionTemplateSpecifications: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransactionTemplateSpecificationsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListTransactionTemplateSpecifications: List Transaction Template Specifications.
    ApiResponse<PagedResourceListOfTransactionTemplateSpecification> response = apiInstance.ListTransactionTemplateSpecificationsWithHttpInfo(asAt, page, limit, filter, sortBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentEventTypesApi.ListTransactionTemplateSpecificationsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | AsAt of the request | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Transaction Template Specifications from              a previous call to list Transaction Template Specifications.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt              fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfTransactionTemplateSpecification**](PagedResourceListOfTransactionTemplateSpecification.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The Transaction Template Specifications. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtransactiontemplates"></a>
# **ListTransactionTemplates**
> PagedResourceListOfTransactionTemplate ListTransactionTemplates (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListTransactionTemplates: List Transaction Templates

Lists all Transaction Templates.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListTransactionTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentEventTypesApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The AsAt time at which to retrieve the Transaction Templates (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing Transaction Templates from a previous call to list Transaction Templates.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, limit, and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 

            try
            {
                // [EXPERIMENTAL] ListTransactionTemplates: List Transaction Templates
                PagedResourceListOfTransactionTemplate result = apiInstance.ListTransactionTemplates(asAt, page, limit, filter, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentEventTypesApi.ListTransactionTemplates: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTransactionTemplatesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListTransactionTemplates: List Transaction Templates
    ApiResponse<PagedResourceListOfTransactionTemplate> response = apiInstance.ListTransactionTemplatesWithHttpInfo(asAt, page, limit, filter, sortBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentEventTypesApi.ListTransactionTemplatesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The AsAt time at which to retrieve the Transaction Templates | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing Transaction Templates from a previous call to list Transaction Templates.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, limit, and asAt fields              must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |

### Return type

[**PagedResourceListOfTransactionTemplate**](PagedResourceListOfTransactionTemplate.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The transaction templates. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetransactiontemplate"></a>
# **UpdateTransactionTemplate**
> TransactionTemplate UpdateTransactionTemplate (string instrumentEventType, string instrumentType, string scope, TransactionTemplateRequest transactionTemplateRequest)

[EXPERIMENTAL] UpdateTransactionTemplate: Update Transaction Template

Update a transaction template for a particular instrument event type in a scope.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateTransactionTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new InstrumentEventTypesApi(config);
            var instrumentEventType = "instrumentEventType_example";  // string | The type of instrument events that the template is applied to.
            var instrumentType = "instrumentType_example";  // string | The instrument type of the transaction template. The combination of the instrument              event type, instrument type and scope uniquely identifies a transaction template
            var scope = "scope_example";  // string | The scope in which the template lies.
            var transactionTemplateRequest = new TransactionTemplateRequest(); // TransactionTemplateRequest | A request defining the updated values for the transaction template.

            try
            {
                // [EXPERIMENTAL] UpdateTransactionTemplate: Update Transaction Template
                TransactionTemplate result = apiInstance.UpdateTransactionTemplate(instrumentEventType, instrumentType, scope, transactionTemplateRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling InstrumentEventTypesApi.UpdateTransactionTemplate: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTransactionTemplateWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateTransactionTemplate: Update Transaction Template
    ApiResponse<TransactionTemplate> response = apiInstance.UpdateTransactionTemplateWithHttpInfo(instrumentEventType, instrumentType, scope, transactionTemplateRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling InstrumentEventTypesApi.UpdateTransactionTemplateWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **instrumentEventType** | **string** | The type of instrument events that the template is applied to. |  |
| **instrumentType** | **string** | The instrument type of the transaction template. The combination of the instrument              event type, instrument type and scope uniquely identifies a transaction template |  |
| **scope** | **string** | The scope in which the template lies. |  |
| **transactionTemplateRequest** | [**TransactionTemplateRequest**](TransactionTemplateRequest.md) | A request defining the updated values for the transaction template. |  |

### Return type

[**TransactionTemplate**](TransactionTemplate.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response of the transaction template that was updated. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

