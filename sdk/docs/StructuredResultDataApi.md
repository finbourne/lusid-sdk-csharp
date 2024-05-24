# Lusid.Sdk.Api.StructuredResultDataApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateDataMap**](StructuredResultDataApi.md#createdatamap) | **POST** /api/unitresults/datamap/{scope} | CreateDataMap: Create data map |
| [**DeleteStructuredResultData**](StructuredResultDataApi.md#deletestructuredresultdata) | **POST** /api/unitresults/{scope}/$delete | [EXPERIMENTAL] DeleteStructuredResultData: Delete structured result data |
| [**GetAddressKeyDefinitionsForDocument**](StructuredResultDataApi.md#getaddresskeydefinitionsfordocument) | **GET** /api/unitresults/virtualdocument/{scope}/{code}/{source}/{resultType}/addresskeydefinitions | [EARLY ACCESS] GetAddressKeyDefinitionsForDocument: Get AddressKeyDefinitions for a virtual document. |
| [**GetDataMap**](StructuredResultDataApi.md#getdatamap) | **POST** /api/unitresults/datamap/{scope}/$get | [EXPERIMENTAL] GetDataMap: Get data map |
| [**GetStructuredResultData**](StructuredResultDataApi.md#getstructuredresultdata) | **POST** /api/unitresults/{scope}/$get | GetStructuredResultData: Get structured result data |
| [**GetVirtualDocument**](StructuredResultDataApi.md#getvirtualdocument) | **POST** /api/unitresults/virtualdocument/{scope}/$get | [EXPERIMENTAL] GetVirtualDocument: Get Virtual Documents |
| [**GetVirtualDocumentRows**](StructuredResultDataApi.md#getvirtualdocumentrows) | **GET** /api/unitresults/virtualdocument/{scope}/{code}/{source}/{resultType} | [EARLY ACCESS] GetVirtualDocumentRows: Get Virtual Document Rows |
| [**UpsertResultValue**](StructuredResultDataApi.md#upsertresultvalue) | **POST** /api/unitresults/resultvalue/{scope} | [EXPERIMENTAL] UpsertResultValue: Upsert result value |
| [**UpsertStructuredResultData**](StructuredResultDataApi.md#upsertstructuredresultdata) | **POST** /api/unitresults/{scope} | UpsertStructuredResultData: Upsert structured result data |

<a id="createdatamap"></a>
# **CreateDataMap**
> UpsertStructuredDataResponse CreateDataMap (string scope, Dictionary<string, CreateDataMapRequest> requestBody)

CreateDataMap: Create data map

Create or update one or more structured result store address definition data maps in a particular scope. Note these are immutable and cannot be changed once created.                In the request, each data map must be keyed by a unique correlation ID. This ID is ephemeral and not stored by LUSID.  It serves only to easily identify each data map object in the response.                The response returns both the collection of successfully created or updated data maps, as well as those that failed.  For each failure, a reason is provided.                It is important to check the failed set for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateDataMapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredResultDataApi(config);
            var scope = "scope_example";  // string | The scope in which to create or update data maps.
            var requestBody = new Dictionary<string, CreateDataMapRequest>(); // Dictionary<string, CreateDataMapRequest> | Individual data map creation requests.

            try
            {
                // CreateDataMap: Create data map
                UpsertStructuredDataResponse result = apiInstance.CreateDataMap(scope, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredResultDataApi.CreateDataMap: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateDataMapWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // CreateDataMap: Create data map
    ApiResponse<UpsertStructuredDataResponse> response = apiInstance.CreateDataMapWithHttpInfo(scope, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StructuredResultDataApi.CreateDataMapWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope in which to create or update data maps. |  |
| **requestBody** | [**Dictionary&lt;string, CreateDataMapRequest&gt;**](CreateDataMapRequest.md) | Individual data map creation requests. |  |

### Return type

[**UpsertStructuredDataResponse**](UpsertStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully created or updated data maps along with any failures. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletestructuredresultdata"></a>
# **DeleteStructuredResultData**
> AnnulStructuredDataResponse DeleteStructuredResultData (string scope, Dictionary<string, StructuredResultDataId> requestBody)

[EXPERIMENTAL] DeleteStructuredResultData: Delete structured result data

Delete one or more structured result data items from a particular scope. Each item is identified by a unique ID which includes  information about its type as well as the exact effective datetime (to the microsecond) at which it entered the system (became valid).                In the request, each data item must be keyed by a unique correlation ID. This ID is ephemeral and not stored by LUSID.  It serves only to easily identify each data item in the response.                The response returns both the collection of successfully deleted data items, as well as those that failed.  For each failure, a reason is provided.                It is important to check the failed set for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteStructuredResultDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredResultDataApi(config);
            var scope = "scope_example";  // string | The scope from which to delete data items.
            var requestBody = new Dictionary<string, StructuredResultDataId>(); // Dictionary<string, StructuredResultDataId> | The data IDs to delete, each keyed by a unique, ephemeral correlation ID.

            try
            {
                // [EXPERIMENTAL] DeleteStructuredResultData: Delete structured result data
                AnnulStructuredDataResponse result = apiInstance.DeleteStructuredResultData(scope, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredResultDataApi.DeleteStructuredResultData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteStructuredResultDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteStructuredResultData: Delete structured result data
    ApiResponse<AnnulStructuredDataResponse> response = apiInstance.DeleteStructuredResultDataWithHttpInfo(scope, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StructuredResultDataApi.DeleteStructuredResultDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope from which to delete data items. |  |
| **requestBody** | [**Dictionary&lt;string, StructuredResultDataId&gt;**](StructuredResultDataId.md) | The data IDs to delete, each keyed by a unique, ephemeral correlation ID. |  |

### Return type

[**AnnulStructuredDataResponse**](AnnulStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully deleted data items along with any failures. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getaddresskeydefinitionsfordocument"></a>
# **GetAddressKeyDefinitionsForDocument**
> ResourceListOfAddressKeyDefinition GetAddressKeyDefinitionsForDocument (string scope, string code, string source, string resultType, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetAddressKeyDefinitionsForDocument: Get AddressKeyDefinitions for a virtual document.

For a given virtual document retrieve all the address key definitions that are in use.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAddressKeyDefinitionsForDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredResultDataApi(config);
            var scope = "scope_example";  // string | The scope of the document for which address key definitions are retrieved.
            var code = "code_example";  // string | The code of the document for which address key definitions are retrieved.
            var source = "source_example";  // string | The source of the document for which address key definitions are retrieved.
            var resultType = "resultType_example";  // string | The result type of the document for which address key definitions are retrieved.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime to query the document for which the address key definitions are retrieved.              Defaults to querying the latest version if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime to query the document for which the address key definitions are retrieved.              Defaults to querying the latest version if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] GetAddressKeyDefinitionsForDocument: Get AddressKeyDefinitions for a virtual document.
                ResourceListOfAddressKeyDefinition result = apiInstance.GetAddressKeyDefinitionsForDocument(scope, code, source, resultType, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredResultDataApi.GetAddressKeyDefinitionsForDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAddressKeyDefinitionsForDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetAddressKeyDefinitionsForDocument: Get AddressKeyDefinitions for a virtual document.
    ApiResponse<ResourceListOfAddressKeyDefinition> response = apiInstance.GetAddressKeyDefinitionsForDocumentWithHttpInfo(scope, code, source, resultType, effectiveAt, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StructuredResultDataApi.GetAddressKeyDefinitionsForDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the document for which address key definitions are retrieved. |  |
| **code** | **string** | The code of the document for which address key definitions are retrieved. |  |
| **source** | **string** | The source of the document for which address key definitions are retrieved. |  |
| **resultType** | **string** | The result type of the document for which address key definitions are retrieved. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime to query the document for which the address key definitions are retrieved.              Defaults to querying the latest version if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime to query the document for which the address key definitions are retrieved.              Defaults to querying the latest version if not specified. | [optional]  |

### Return type

[**ResourceListOfAddressKeyDefinition**](ResourceListOfAddressKeyDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of address key definitions. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getdatamap"></a>
# **GetDataMap**
> GetDataMapResponse GetDataMap (string scope, Dictionary<string, DataMapKey> requestBody)

[EXPERIMENTAL] GetDataMap: Get data map

Retrieve one or more structured result store address definition data maps from a particular scope.                Each data map can be identified by its invariant key, which can be thought of as a permanent URL.  For each ID, LUSID returns the most recently matched item.                In the request, each data map must be keyed by a unique correlation ID. This ID is ephemeral and not stored by LUSID.  It serves only to easily identify each data map in the response.                The response returns three collections. The first contains successfully retrieved data maps. The second contains those with a  valid identifier but that could not be found. The third contains those that failed because LUSID could not construct a valid identifier from the request.                For the IDs that failed to resolve or could not be found, a reason is provided.                It is important to check the failed sets for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetDataMapExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredResultDataApi(config);
            var scope = "scope_example";  // string | The scope from which to retrieve data maps.
            var requestBody = new Dictionary<string, DataMapKey>(); // Dictionary<string, DataMapKey> | The data map keys to look up, each keyed by a unique, ephemeral correlation ID.

            try
            {
                // [EXPERIMENTAL] GetDataMap: Get data map
                GetDataMapResponse result = apiInstance.GetDataMap(scope, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredResultDataApi.GetDataMap: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetDataMapWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetDataMap: Get data map
    ApiResponse<GetDataMapResponse> response = apiInstance.GetDataMapWithHttpInfo(scope, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StructuredResultDataApi.GetDataMapWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope from which to retrieve data maps. |  |
| **requestBody** | [**Dictionary&lt;string, DataMapKey&gt;**](DataMapKey.md) | The data map keys to look up, each keyed by a unique, ephemeral correlation ID. |  |

### Return type

[**GetDataMapResponse**](GetDataMapResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved data maps along with any failures. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getstructuredresultdata"></a>
# **GetStructuredResultData**
> GetStructuredResultDataResponse GetStructuredResultData (string scope, Dictionary<string, StructuredResultDataId> requestBody, DateTimeOffset? asAt = null, string? maxAge = null)

GetStructuredResultData: Get structured result data

Retrieve one or more structured result data items from a particular scope.                Each item can be identified by its time invariant structured result data identifier. For each ID, LUSID  returns the most recently matched item with respect to the provided (or default) effective datetime.                 An optional maximum age range window can be specified to control how far back to look from the specified  effective datetime. LUSID returns the most recent item within this window.                In the request, each data item must be keyed by a unique correlation ID. This ID is ephemeral and not stored by LUSID.  It serves only to easily identify each data item in the response.    The response returns three collections. The first contains successfully retrieved data items. The second contains those with a  valid identifier but that could not be found. The third contains those that failed because LUSID could not construct a valid identifier from the request.    For the IDs that failed to resolve or could not be found, a reason is provided.                It is important to check the failed sets for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetStructuredResultDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredResultDataApi(config);
            var scope = "scope_example";  // string | The scope from which to retrieve data items.
            var requestBody = new Dictionary<string, StructuredResultDataId>(); // Dictionary<string, StructuredResultDataId> | The time invariant set of structured data identifiers to retrieve, keyed by a unique, ephemeral correlation ID.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the structured result data. Defaults to returning the latest version if not specified. (optional) 
            var maxAge = "maxAge_example";  // string? | The duration of the look-back window in ISO8601 time interval format, for example 'P1Y2M3DT4H30M' (1 year, 2 months, 3 days, 4 hours and 30 minutes).               This is subtracted from the provided effectiveAt datetime to generate a effective datetime window inside which a data item must exist to be retrieved. (optional) 

            try
            {
                // GetStructuredResultData: Get structured result data
                GetStructuredResultDataResponse result = apiInstance.GetStructuredResultData(scope, requestBody, asAt, maxAge);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredResultDataApi.GetStructuredResultData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetStructuredResultDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // GetStructuredResultData: Get structured result data
    ApiResponse<GetStructuredResultDataResponse> response = apiInstance.GetStructuredResultDataWithHttpInfo(scope, requestBody, asAt, maxAge);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StructuredResultDataApi.GetStructuredResultDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope from which to retrieve data items. |  |
| **requestBody** | [**Dictionary&lt;string, StructuredResultDataId&gt;**](StructuredResultDataId.md) | The time invariant set of structured data identifiers to retrieve, keyed by a unique, ephemeral correlation ID. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the structured result data. Defaults to returning the latest version if not specified. | [optional]  |
| **maxAge** | **string?** | The duration of the look-back window in ISO8601 time interval format, for example &#39;P1Y2M3DT4H30M&#39; (1 year, 2 months, 3 days, 4 hours and 30 minutes).               This is subtracted from the provided effectiveAt datetime to generate a effective datetime window inside which a data item must exist to be retrieved. | [optional]  |

### Return type

[**GetStructuredResultDataResponse**](GetStructuredResultDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved data items along with any failures. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getvirtualdocument"></a>
# **GetVirtualDocument**
> GetVirtualDocumentResponse GetVirtualDocument (string scope, Dictionary<string, StructuredResultDataId> requestBody, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetVirtualDocument: Get Virtual Documents

Retrieve one or more virtual documents from a particular scope.                Each item can be identified by its time invariant structured result data identifier. For each ID, LUSID  returns the most recently matched item with respect to the provided effective datetime.                In the request, each data item must be keyed by a unique correlation ID. This ID is ephemeral and not stored by LUSID.  It serves only to easily identify each data item in the response.                The response returns two collections. The first contains successfully retrieved data items. The second contains those with a  valid identifier but that could not be found, or those that failed because LUSID could not construct a valid identifier from the request.                For the IDs that failed to resolve or could not be found, a reason is provided.                It is important to check the failed sets for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetVirtualDocumentExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredResultDataApi(config);
            var scope = "scope_example";  // string | The scope in which to construct the virtual documents.
            var requestBody = new Dictionary<string, StructuredResultDataId>(); // Dictionary<string, StructuredResultDataId> | The time invariant set of structured data identifiers to retrieve, keyed by a unique, ephemeral correlation ID.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the structured result data. Defaults to returning the latest version if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetVirtualDocument: Get Virtual Documents
                GetVirtualDocumentResponse result = apiInstance.GetVirtualDocument(scope, requestBody, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredResultDataApi.GetVirtualDocument: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVirtualDocumentWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetVirtualDocument: Get Virtual Documents
    ApiResponse<GetVirtualDocumentResponse> response = apiInstance.GetVirtualDocumentWithHttpInfo(scope, requestBody, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StructuredResultDataApi.GetVirtualDocumentWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope in which to construct the virtual documents. |  |
| **requestBody** | [**Dictionary&lt;string, StructuredResultDataId&gt;**](StructuredResultDataId.md) | The time invariant set of structured data identifiers to retrieve, keyed by a unique, ephemeral correlation ID. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the structured result data. Defaults to returning the latest version if not specified. | [optional]  |

### Return type

[**GetVirtualDocumentResponse**](GetVirtualDocumentResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved virtual documents along with any failures. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getvirtualdocumentrows"></a>
# **GetVirtualDocumentRows**
> PagedResourceListOfVirtualRow GetVirtualDocumentRows (string scope, string code, string source, string resultType, DateTimeOrCutLabel effectiveAt, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null)

[EARLY ACCESS] GetVirtualDocumentRows: Get Virtual Document Rows

Retrieve the rows of the virtual document with the specified identifiers and the given effectiveAt date time.    Get virtual document rows merges multiple StructuredResultData items upserted with UpsertStructuredResultData  for a single StructuredResultDataId.                Since an item of StructuredResultData is always upserted with a StructuredResultDataId, of which  effectiveAt is a part, then merging across the asAt dimension is supported but not merging across the  effectiveAt dimension.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetVirtualDocumentRowsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredResultDataApi(config);
            var scope = "scope_example";  // string | The scope in which to retrieve the virtual document.
            var code = "code_example";  // string | The code of the virtual document to retrieve.
            var source = "source_example";  // string | The source of the virtual document to retrieve.
            var resultType = "resultType_example";  // string | The result type of the virtual document to retrieve.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel | The effectiveAt datetime at which to retrieve the virtual document.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the virtual document. Defaults to returning the latest version if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing virtual document rows from a previous               call to list virtual document rows. This value is returned from the previous call. If a pagination token is               provided the filter, effectiveAt, and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:               https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] GetVirtualDocumentRows: Get Virtual Document Rows
                PagedResourceListOfVirtualRow result = apiInstance.GetVirtualDocumentRows(scope, code, source, resultType, effectiveAt, asAt, page, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredResultDataApi.GetVirtualDocumentRows: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetVirtualDocumentRowsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetVirtualDocumentRows: Get Virtual Document Rows
    ApiResponse<PagedResourceListOfVirtualRow> response = apiInstance.GetVirtualDocumentRowsWithHttpInfo(scope, code, source, resultType, effectiveAt, asAt, page, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StructuredResultDataApi.GetVirtualDocumentRowsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope in which to retrieve the virtual document. |  |
| **code** | **string** | The code of the virtual document to retrieve. |  |
| **source** | **string** | The source of the virtual document to retrieve. |  |
| **resultType** | **string** | The result type of the virtual document to retrieve. |  |
| **effectiveAt** | **DateTimeOrCutLabel** | The effectiveAt datetime at which to retrieve the virtual document. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the virtual document. Defaults to returning the latest version if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing virtual document rows from a previous               call to list virtual document rows. This value is returned from the previous call. If a pagination token is               provided the filter, effectiveAt, and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:               https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfVirtualRow**](PagedResourceListOfVirtualRow.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The rows of the virtual document. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertresultvalue"></a>
# **UpsertResultValue**
> UpsertStructuredDataResponse UpsertResultValue (string scope, Dictionary<string, UpsertResultValuesDataRequest> requestBody)

[EXPERIMENTAL] UpsertResultValue: Upsert result value

Create or update one or more Upsert one or more result values in a particular scope. An item is updated if it already exists  and created if it does not.                In the request, each data item must be keyed by a unique correlation ID. This ID is ephemeral and not stored by LUSID.  It serves only to easily identify each data item in the response.                The response returns both the collection of successfully created or updated data items, as well as those that failed.  For each failure, a reason is provided.                It is important to check the failed set for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertResultValueExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredResultDataApi(config);
            var scope = "scope_example";  // string | The scope in which to construct the virtual documents.
            var requestBody = new Dictionary<string, UpsertResultValuesDataRequest>(); // Dictionary<string, UpsertResultValuesDataRequest> | The time invariant set of structured data identifiers to retrieve, keyed by a unique, ephemeral correlation ID.

            try
            {
                // [EXPERIMENTAL] UpsertResultValue: Upsert result value
                UpsertStructuredDataResponse result = apiInstance.UpsertResultValue(scope, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredResultDataApi.UpsertResultValue: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertResultValueWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertResultValue: Upsert result value
    ApiResponse<UpsertStructuredDataResponse> response = apiInstance.UpsertResultValueWithHttpInfo(scope, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StructuredResultDataApi.UpsertResultValueWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope in which to construct the virtual documents. |  |
| **requestBody** | [**Dictionary&lt;string, UpsertResultValuesDataRequest&gt;**](UpsertResultValuesDataRequest.md) | The time invariant set of structured data identifiers to retrieve, keyed by a unique, ephemeral correlation ID. |  |

### Return type

[**UpsertStructuredDataResponse**](UpsertStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully retrieved virtual documents along with any failures. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertstructuredresultdata"></a>
# **UpsertStructuredResultData**
> UpsertStructuredDataResponse UpsertStructuredResultData (string scope, Dictionary<string, UpsertStructuredResultDataRequest> requestBody)

UpsertStructuredResultData: Upsert structured result data

Create or update one or more structured result data items in a particular scope. An item is updated if it already exists  and created if it does not.                In the request, each data item must be keyed by a unique correlation ID. This ID is ephemeral and not stored by LUSID.  It serves only to easily identify each data item in the response.                The response returns both the collection of successfully created or updated data items, as well as those that failed.  For each failure, a reason is provided.                It is important to check the failed set for any unsuccessful results.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertStructuredResultDataExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredResultDataApi(config);
            var scope = "scope_example";  // string | The scope in which to create or update data items.
            var requestBody = new Dictionary<string, UpsertStructuredResultDataRequest>(); // Dictionary<string, UpsertStructuredResultDataRequest> | The set of data items to create or update, keyed by a unique, ephemeral correlation ID.

            try
            {
                // UpsertStructuredResultData: Upsert structured result data
                UpsertStructuredDataResponse result = apiInstance.UpsertStructuredResultData(scope, requestBody);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredResultDataApi.UpsertStructuredResultData: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertStructuredResultDataWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // UpsertStructuredResultData: Upsert structured result data
    ApiResponse<UpsertStructuredDataResponse> response = apiInstance.UpsertStructuredResultDataWithHttpInfo(scope, requestBody);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling StructuredResultDataApi.UpsertStructuredResultDataWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope in which to create or update data items. |  |
| **requestBody** | [**Dictionary&lt;string, UpsertStructuredResultDataRequest&gt;**](UpsertStructuredResultDataRequest.md) | The set of data items to create or update, keyed by a unique, ephemeral correlation ID. |  |

### Return type

[**UpsertStructuredDataResponse**](UpsertStructuredDataResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully created or updated data items along with any failures. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

