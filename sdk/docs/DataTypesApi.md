# Lusid.Sdk.Api.DataTypesApi

All URIs are relative to *https://www.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateDataType**](DataTypesApi.md#createdatatype) | **POST** /api/datatypes | [EARLY ACCESS] CreateDataType: Create data type definition
[**GetDataType**](DataTypesApi.md#getdatatype) | **GET** /api/datatypes/{scope}/{code} | GetDataType: Get data type definition
[**GetUnitsFromDataType**](DataTypesApi.md#getunitsfromdatatype) | **GET** /api/datatypes/{scope}/{code}/units | [EARLY ACCESS] GetUnitsFromDataType: Get units from data type
[**ListDataTypeSummaries**](DataTypesApi.md#listdatatypesummaries) | **GET** /api/datatypes | [EARLY ACCESS] ListDataTypeSummaries: List all data type summaries, without the reference data
[**ListDataTypes**](DataTypesApi.md#listdatatypes) | **GET** /api/datatypes/{scope} | ListDataTypes: List data types
[**UpdateDataType**](DataTypesApi.md#updatedatatype) | **PUT** /api/datatypes/{scope}/{code} | [EARLY ACCESS] UpdateDataType: Update data type definition
[**UpdateReferenceValues**](DataTypesApi.md#updatereferencevalues) | **PUT** /api/datatypes/{scope}/{code}/referencedatavalues | [EARLY ACCESS] UpdateReferenceValues: Update reference data on a data type


<a name="createdatatype"></a>
# **CreateDataType**
> DataType CreateDataType (CreateDataTypeRequest createDataTypeRequest = null)

[EARLY ACCESS] CreateDataType: Create data type definition

Create a new data type definition    Data types cannot be created in either the \"default\" or \"system\" scopes.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateDataTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataTypesApi(config);
            var createDataTypeRequest = new CreateDataTypeRequest(); // CreateDataTypeRequest | The definition of the new data type (optional) 

            try
            {
                // [EARLY ACCESS] CreateDataType: Create data type definition
                DataType result = apiInstance.CreateDataType(createDataTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataTypesApi.CreateDataType: " + e.Message );
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
 **createDataTypeRequest** | [**CreateDataTypeRequest**](CreateDataTypeRequest.md)| The definition of the new data type | [optional] 

### Return type

[**DataType**](DataType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getdatatype"></a>
# **GetDataType**
> DataType GetDataType (string scope, string code, DateTimeOffset? asAt = null)

GetDataType: Get data type definition

Get the definition of a specified data type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetDataTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataTypesApi(config);
            var scope = scope_example;  // string | The scope of the data type
            var code = code_example;  // string | The code of the data type
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to retrieve the data type definition. Defaults to              return the latest version of the instrument definition if not specified. (optional) 

            try
            {
                // GetDataType: Get data type definition
                DataType result = apiInstance.GetDataType(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataTypesApi.GetDataType: " + e.Message );
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
 **scope** | **string**| The scope of the data type | 
 **code** | **string**| The code of the data type | 
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to retrieve the data type definition. Defaults to              return the latest version of the instrument definition if not specified. | [optional] 

### Return type

[**DataType**](DataType.md)

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

<a name="getunitsfromdatatype"></a>
# **GetUnitsFromDataType**
> ResourceListOfIUnitDefinitionDto GetUnitsFromDataType (string scope, string code, List<string> units = null, string filter = null, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetUnitsFromDataType: Get units from data type

Get the definitions of the specified units associated bound to a specific data type

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetUnitsFromDataTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataTypesApi(config);
            var scope = scope_example;  // string | The scope of the data type
            var code = code_example;  // string | The code of the data type
            var units = new List<string>(); // List<string> | One or more unit identifiers for which the definition is being requested (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set.               For example, to filter on the Schema, use \"schema eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The as at of the requested data type (optional) 

            try
            {
                // [EARLY ACCESS] GetUnitsFromDataType: Get units from data type
                ResourceListOfIUnitDefinitionDto result = apiInstance.GetUnitsFromDataType(scope, code, units, filter, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataTypesApi.GetUnitsFromDataType: " + e.Message );
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
 **scope** | **string**| The scope of the data type | 
 **code** | **string**| The code of the data type | 
 **units** | [**List&lt;string&gt;**](string.md)| One or more unit identifiers for which the definition is being requested | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set.               For example, to filter on the Schema, use \&quot;schema eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **asAt** | **DateTimeOffset?**| Optional. The as at of the requested data type | [optional] 

### Return type

[**ResourceListOfIUnitDefinitionDto**](ResourceListOfIUnitDefinitionDto.md)

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

<a name="listdatatypesummaries"></a>
# **ListDataTypeSummaries**
> PagedResourceListOfDataTypeSummary ListDataTypeSummaries (DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null, List<string> sortBy = null)

[EARLY ACCESS] ListDataTypeSummaries: List all data type summaries, without the reference data

List all data type summaries

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListDataTypeSummariesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataTypesApi(config);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime at which to list the data type summaries. Defaults to returning the latest version               of each summary if not specified. (optional) 
            var page = page_example;  // string | The pagination token to use to continue listing data type summaries. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set.                For example, to filter on the Scope, use \"id.scope eq 'myscope'\", to filter on Schema, use \"schema eq 'string'\",               to filter on AcceptableValues use \"acceptableValues any (~ eq 'value')\"               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var sortBy = new List<string>(); // List<string> | Sort the results by these fields. Use use the '-' sign to denote descending allocation e.g. -MyFieldName. (optional) 

            try
            {
                // [EARLY ACCESS] ListDataTypeSummaries: List all data type summaries, without the reference data
                PagedResourceListOfDataTypeSummary result = apiInstance.ListDataTypeSummaries(asAt, page, start, limit, filter, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataTypesApi.ListDataTypeSummaries: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| The asAt datetime at which to list the data type summaries. Defaults to returning the latest version               of each summary if not specified. | [optional] 
 **page** | **string**| The pagination token to use to continue listing data type summaries. This  value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt  and asAt fields must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional] 
 **start** | **int?**| When paginating, skip this number of results. | [optional] 
 **limit** | **int?**| When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set.                For example, to filter on the Scope, use \&quot;id.scope eq &#39;myscope&#39;\&quot;, to filter on Schema, use \&quot;schema eq &#39;string&#39;\&quot;,               to filter on AcceptableValues use \&quot;acceptableValues any (~ eq &#39;value&#39;)\&quot;               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Sort the results by these fields. Use use the &#39;-&#39; sign to denote descending allocation e.g. -MyFieldName. | [optional] 

### Return type

[**PagedResourceListOfDataTypeSummary**](PagedResourceListOfDataTypeSummary.md)

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

<a name="listdatatypes"></a>
# **ListDataTypes**
> ResourceListOfDataType ListDataTypes (string scope, DateTimeOffset? asAt = null, bool? includeSystem = null, List<string> sortBy = null, int? start = null, int? limit = null, string filter = null)

ListDataTypes: List data types

List all data types in a specified scope

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListDataTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataTypesApi(config);
            var scope = scope_example;  // string | The requested scope of the data types
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The as at of the requested data types (optional) 
            var includeSystem = true;  // bool? | Whether to additionally include those data types in the \"system\" scope (optional) 
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set.              For example, to filter on the Display Name, use \"displayName eq 'string'\"              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // ListDataTypes: List data types
                ResourceListOfDataType result = apiInstance.ListDataTypes(scope, asAt, includeSystem, sortBy, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataTypesApi.ListDataTypes: " + e.Message );
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
 **scope** | **string**| The requested scope of the data types | 
 **asAt** | **DateTimeOffset?**| The as at of the requested data types | [optional] 
 **includeSystem** | **bool?**| Whether to additionally include those data types in the \&quot;system\&quot; scope | [optional] 
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set.              For example, to filter on the Display Name, use \&quot;displayName eq &#39;string&#39;\&quot;              Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**ResourceListOfDataType**](ResourceListOfDataType.md)

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

<a name="updatedatatype"></a>
# **UpdateDataType**
> DataType UpdateDataType (string scope, string code, UpdateDataTypeRequest updateDataTypeRequest)

[EARLY ACCESS] UpdateDataType: Update data type definition

Update the definition of the specified existing data type    Not all elements within a data type definition are modifiable due to the potential implications for data  already stored against the types

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateDataTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataTypesApi(config);
            var scope = scope_example;  // string | The scope of the data type
            var code = code_example;  // string | The code of the data type
            var updateDataTypeRequest = new UpdateDataTypeRequest(); // UpdateDataTypeRequest | The updated definition of the data type

            try
            {
                // [EARLY ACCESS] UpdateDataType: Update data type definition
                DataType result = apiInstance.UpdateDataType(scope, code, updateDataTypeRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataTypesApi.UpdateDataType: " + e.Message );
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
 **scope** | **string**| The scope of the data type | 
 **code** | **string**| The code of the data type | 
 **updateDataTypeRequest** | [**UpdateDataTypeRequest**](UpdateDataTypeRequest.md)| The updated definition of the data type | 

### Return type

[**DataType**](DataType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatereferencevalues"></a>
# **UpdateReferenceValues**
> DataType UpdateReferenceValues (string scope, string code, List<FieldValue> fieldValue)

[EARLY ACCESS] UpdateReferenceValues: Update reference data on a data type

Replaces the whole set of reference values

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateReferenceValuesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new DataTypesApi(config);
            var scope = scope_example;  // string | The scope of the data type
            var code = code_example;  // string | The code of the data type
            var fieldValue = new List<FieldValue>(); // List<FieldValue> | The updated reference values

            try
            {
                // [EARLY ACCESS] UpdateReferenceValues: Update reference data on a data type
                DataType result = apiInstance.UpdateReferenceValues(scope, code, fieldValue);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling DataTypesApi.UpdateReferenceValues: " + e.Message );
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
 **scope** | **string**| The scope of the data type | 
 **code** | **string**| The code of the data type | 
 **fieldValue** | [**List&lt;FieldValue&gt;**](FieldValue.md)| The updated reference values | 

### Return type

[**DataType**](DataType.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

