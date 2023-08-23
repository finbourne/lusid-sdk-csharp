# Lusid.Sdk.Api.SystemConfigurationApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateConfigurationTransactionType**](SystemConfigurationApi.md#createconfigurationtransactiontype) | **POST** /api/systemconfiguration/transactions/type | [EARLY ACCESS] CreateConfigurationTransactionType: Create transaction type |
| [**CreateSideDefinition**](SystemConfigurationApi.md#createsidedefinition) | **POST** /api/systemconfiguration/transactions/side | [EXPERIMENTAL] CreateSideDefinition: Create side definition |
| [**DeleteTransactionConfigurationSource**](SystemConfigurationApi.md#deletetransactionconfigurationsource) | **DELETE** /api/systemconfiguration/transactions/type/{source} | [EXPERIMENTAL] DeleteTransactionConfigurationSource: Delete all transaction configurations for a source |
| [**GetTransactionConfigurationSource**](SystemConfigurationApi.md#gettransactionconfigurationsource) | **GET** /api/systemconfiguration/transactions/type/{source} | [EXPERIMENTAL] GetTransactionConfigurationSource: Get all transaction configurations for a source |
| [**ListConfigurationTransactionTypes**](SystemConfigurationApi.md#listconfigurationtransactiontypes) | **GET** /api/systemconfiguration/transactions | [EARLY ACCESS] ListConfigurationTransactionTypes: List transaction types |
| [**SetConfigurationTransactionTypes**](SystemConfigurationApi.md#setconfigurationtransactiontypes) | **PUT** /api/systemconfiguration/transactions | [EXPERIMENTAL] SetConfigurationTransactionTypes: Set transaction types |
| [**SetTransactionConfigurationSource**](SystemConfigurationApi.md#settransactionconfigurationsource) | **PUT** /api/systemconfiguration/transactions/type/{source} | [EXPERIMENTAL] SetTransactionConfigurationSource: Set transaction types for a source |

<a id="createconfigurationtransactiontype"></a>
# **CreateConfigurationTransactionType**
> TransactionSetConfigurationData CreateConfigurationTransactionType (TransactionConfigurationDataRequest? transactionConfigurationDataRequest = null)

[EARLY ACCESS] CreateConfigurationTransactionType: Create transaction type

Create a new transaction type by specifying a definition and mappings to movements.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateConfigurationTransactionTypeExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SystemConfigurationApi(config);
            var transactionConfigurationDataRequest = new TransactionConfigurationDataRequest?(); // TransactionConfigurationDataRequest? | A transaction type definition. (optional) 

            try
            {
                // [EARLY ACCESS] CreateConfigurationTransactionType: Create transaction type
                TransactionSetConfigurationData result = apiInstance.CreateConfigurationTransactionType(transactionConfigurationDataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemConfigurationApi.CreateConfigurationTransactionType: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateConfigurationTransactionTypeWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] CreateConfigurationTransactionType: Create transaction type
    ApiResponse<TransactionSetConfigurationData> response = apiInstance.CreateConfigurationTransactionTypeWithHttpInfo(transactionConfigurationDataRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemConfigurationApi.CreateConfigurationTransactionTypeWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionConfigurationDataRequest** | [**TransactionConfigurationDataRequest?**](TransactionConfigurationDataRequest?.md) | A transaction type definition. | [optional]  |

### Return type

[**TransactionSetConfigurationData**](TransactionSetConfigurationData.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="createsidedefinition"></a>
# **CreateSideDefinition**
> TransactionSetConfigurationData CreateSideDefinition (SideConfigurationDataRequest? sideConfigurationDataRequest = null)

[EXPERIMENTAL] CreateSideDefinition: Create side definition

Create a new side definition for use in a transaction type. For more information, see https://support.lusid.com/knowledgebase/article/KA-01875.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateSideDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SystemConfigurationApi(config);
            var sideConfigurationDataRequest = new SideConfigurationDataRequest?(); // SideConfigurationDataRequest? | The definition of the side. (optional) 

            try
            {
                // [EXPERIMENTAL] CreateSideDefinition: Create side definition
                TransactionSetConfigurationData result = apiInstance.CreateSideDefinition(sideConfigurationDataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemConfigurationApi.CreateSideDefinition: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateSideDefinitionWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateSideDefinition: Create side definition
    ApiResponse<TransactionSetConfigurationData> response = apiInstance.CreateSideDefinitionWithHttpInfo(sideConfigurationDataRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemConfigurationApi.CreateSideDefinitionWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **sideConfigurationDataRequest** | [**SideConfigurationDataRequest?**](SideConfigurationDataRequest?.md) | The definition of the side. | [optional]  |

### Return type

[**TransactionSetConfigurationData**](TransactionSetConfigurationData.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetransactionconfigurationsource"></a>
# **DeleteTransactionConfigurationSource**
> DeletedEntityResponse DeleteTransactionConfigurationSource (string source)

[EXPERIMENTAL] DeleteTransactionConfigurationSource: Delete all transaction configurations for a source

/// WARNING! Changing existing transaction types has a material impact on how data, new and old,  is processed and aggregated by LUSID, and will affect your whole organisation. Only call this API if you are fully aware of the implications of the change.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteTransactionConfigurationSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SystemConfigurationApi(config);
            var source = "source_example";  // string | The source to delete transaction configurations for

            try
            {
                // [EXPERIMENTAL] DeleteTransactionConfigurationSource: Delete all transaction configurations for a source
                DeletedEntityResponse result = apiInstance.DeleteTransactionConfigurationSource(source);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemConfigurationApi.DeleteTransactionConfigurationSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTransactionConfigurationSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteTransactionConfigurationSource: Delete all transaction configurations for a source
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteTransactionConfigurationSourceWithHttpInfo(source);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemConfigurationApi.DeleteTransactionConfigurationSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **source** | **string** | The source to delete transaction configurations for |  |

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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettransactionconfigurationsource"></a>
# **GetTransactionConfigurationSource**
> TransactionSetConfigurationData GetTransactionConfigurationSource (string source, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetTransactionConfigurationSource: Get all transaction configurations for a source

Returns failure if requested source is not found

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetTransactionConfigurationSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SystemConfigurationApi(config);
            var source = "source_example";  // string | The source for which to retrieve transaction configurations
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the transaction configurations.              Defaults to returning the latest version of the transaction configurations if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetTransactionConfigurationSource: Get all transaction configurations for a source
                TransactionSetConfigurationData result = apiInstance.GetTransactionConfigurationSource(source, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemConfigurationApi.GetTransactionConfigurationSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTransactionConfigurationSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetTransactionConfigurationSource: Get all transaction configurations for a source
    ApiResponse<TransactionSetConfigurationData> response = apiInstance.GetTransactionConfigurationSourceWithHttpInfo(source, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemConfigurationApi.GetTransactionConfigurationSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **source** | **string** | The source for which to retrieve transaction configurations |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the transaction configurations.              Defaults to returning the latest version of the transaction configurations if not specified. | [optional]  |

### Return type

[**TransactionSetConfigurationData**](TransactionSetConfigurationData.md)

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

<a id="listconfigurationtransactiontypes"></a>
# **ListConfigurationTransactionTypes**
> TransactionSetConfigurationData ListConfigurationTransactionTypes (DateTimeOffset? asAt = null)

[EARLY ACCESS] ListConfigurationTransactionTypes: List transaction types

Get the list of current transaction types. For information on the default transaction types provided with  LUSID, see https://support.lusid.com/knowledgebase/article/KA-01873/.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListConfigurationTransactionTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SystemConfigurationApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the transaction types. Defaults              to returning the latest versions if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] ListConfigurationTransactionTypes: List transaction types
                TransactionSetConfigurationData result = apiInstance.ListConfigurationTransactionTypes(asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemConfigurationApi.ListConfigurationTransactionTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListConfigurationTransactionTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListConfigurationTransactionTypes: List transaction types
    ApiResponse<TransactionSetConfigurationData> response = apiInstance.ListConfigurationTransactionTypesWithHttpInfo(asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemConfigurationApi.ListConfigurationTransactionTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the transaction types. Defaults              to returning the latest versions if not specified. | [optional]  |

### Return type

[**TransactionSetConfigurationData**](TransactionSetConfigurationData.md)

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

<a id="setconfigurationtransactiontypes"></a>
# **SetConfigurationTransactionTypes**
> TransactionSetConfigurationData SetConfigurationTransactionTypes (TransactionSetConfigurationDataRequest? transactionSetConfigurationDataRequest = null)

[EXPERIMENTAL] SetConfigurationTransactionTypes: Set transaction types

Configure all existing transaction types. Note it is not possible to configure a single existing transaction type on its own.                WARNING! Changing existing transaction types has a material impact on how data, new and old, is processed and aggregated by LUSID, and will affect your whole organisation. Only call this API if you are fully aware of the implications of the change.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetConfigurationTransactionTypesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SystemConfigurationApi(config);
            var transactionSetConfigurationDataRequest = new TransactionSetConfigurationDataRequest?(); // TransactionSetConfigurationDataRequest? | The complete set of transaction type definitions. (optional) 

            try
            {
                // [EXPERIMENTAL] SetConfigurationTransactionTypes: Set transaction types
                TransactionSetConfigurationData result = apiInstance.SetConfigurationTransactionTypes(transactionSetConfigurationDataRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemConfigurationApi.SetConfigurationTransactionTypes: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetConfigurationTransactionTypesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] SetConfigurationTransactionTypes: Set transaction types
    ApiResponse<TransactionSetConfigurationData> response = apiInstance.SetConfigurationTransactionTypesWithHttpInfo(transactionSetConfigurationDataRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemConfigurationApi.SetConfigurationTransactionTypesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **transactionSetConfigurationDataRequest** | [**TransactionSetConfigurationDataRequest?**](TransactionSetConfigurationDataRequest?.md) | The complete set of transaction type definitions. | [optional]  |

### Return type

[**TransactionSetConfigurationData**](TransactionSetConfigurationData.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="settransactionconfigurationsource"></a>
# **SetTransactionConfigurationSource**
> TransactionSetConfigurationData SetTransactionConfigurationSource (string source, List<SetTransactionConfigurationSourceRequest> setTransactionConfigurationSourceRequest)

[EXPERIMENTAL] SetTransactionConfigurationSource: Set transaction types for a source

This will replace all the existing transaction configurations for the given source                WARNING! Changing existing transaction types has a material impact on how data, new and old, is processed and aggregated by LUSID, and will affect your whole organisation. Only call this API if you are fully aware of the implications of the change.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetTransactionConfigurationSourceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SystemConfigurationApi(config);
            var source = "source_example";  // string | The source to set the transaction configurations for
            var setTransactionConfigurationSourceRequest = new List<SetTransactionConfigurationSourceRequest>(); // List<SetTransactionConfigurationSourceRequest> | The set of transaction configurations

            try
            {
                // [EXPERIMENTAL] SetTransactionConfigurationSource: Set transaction types for a source
                TransactionSetConfigurationData result = apiInstance.SetTransactionConfigurationSource(source, setTransactionConfigurationSourceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SystemConfigurationApi.SetTransactionConfigurationSource: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetTransactionConfigurationSourceWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] SetTransactionConfigurationSource: Set transaction types for a source
    ApiResponse<TransactionSetConfigurationData> response = apiInstance.SetTransactionConfigurationSourceWithHttpInfo(source, setTransactionConfigurationSourceRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling SystemConfigurationApi.SetTransactionConfigurationSourceWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **source** | **string** | The source to set the transaction configurations for |  |
| **setTransactionConfigurationSourceRequest** | [**List&lt;SetTransactionConfigurationSourceRequest&gt;**](SetTransactionConfigurationSourceRequest.md) | The set of transaction configurations |  |

### Return type

[**TransactionSetConfigurationData**](TransactionSetConfigurationData.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

