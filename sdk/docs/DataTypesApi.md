# Lusid.Sdk.Api.DataTypesApi

All URIs are relative to *http://local-unit-test-server.lusid.com:61302*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetDataType**](DataTypesApi.md#getdatatype) | **GET** /api/datatypes/{scope}/{code} | GetDataType: Get data type definition
[**GetUnitsFromDataType**](DataTypesApi.md#getunitsfromdatatype) | **GET** /api/datatypes/{scope}/{code}/units | [EARLY ACCESS] GetUnitsFromDataType: Get units from data type
[**ListDataTypes**](DataTypesApi.md#listdatatypes) | **GET** /api/datatypes/{scope} | ListDataTypes: List data types


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
            config.BasePath = "http://local-unit-test-server.lusid.com:61302";
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
            config.BasePath = "http://local-unit-test-server.lusid.com:61302";
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
            config.BasePath = "http://local-unit-test-server.lusid.com:61302";
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

