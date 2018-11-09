# LusidSdk.Api.SystemConfigurationApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateConfigurationTransactionType**](SystemConfigurationApi.md#createconfigurationtransactiontype) | **POST** /api/systemconfiguration/transactiontypes | Create transaction type
[**ListConfigurationTransactionTypes**](SystemConfigurationApi.md#listconfigurationtransactiontypes) | **GET** /api/systemconfiguration/transactiontypes | List transaction types
[**SetConfigurationTransactionTypes**](SystemConfigurationApi.md#setconfigurationtransactiontypes) | **PUT** /api/systemconfiguration/transactiontypes | Set transaction types


<a name="createconfigurationtransactiontype"></a>
# **CreateConfigurationTransactionType**
> TransactionConfigurationData CreateConfigurationTransactionType (TransactionConfigurationDataRequest type = null)

Create transaction type

Create a new transaction type by specifying a definition and the mappings to movements

### Example
```csharp
using System;
using System.Diagnostics;
using LusidSdk.Api;
using LusidSdk.Client;
using LusidSdk.Model;

namespace Example
{
    public class CreateConfigurationTransactionTypeExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SystemConfigurationApi();
            var type = new TransactionConfigurationDataRequest(); // TransactionConfigurationDataRequest | A transaction type definition (optional) 

            try
            {
                // Create transaction type
                TransactionConfigurationData result = apiInstance.CreateConfigurationTransactionType(type);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemConfigurationApi.CreateConfigurationTransactionType: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **type** | [**TransactionConfigurationDataRequest**](TransactionConfigurationDataRequest.md)| A transaction type definition | [optional] 

### Return type

[**TransactionConfigurationData**](TransactionConfigurationData.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listconfigurationtransactiontypes"></a>
# **ListConfigurationTransactionTypes**
> ResourceListOfTransactionMetaData ListConfigurationTransactionTypes ()

List transaction types

Get the list of persisted transaction types

### Example
```csharp
using System;
using System.Diagnostics;
using LusidSdk.Api;
using LusidSdk.Client;
using LusidSdk.Model;

namespace Example
{
    public class ListConfigurationTransactionTypesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SystemConfigurationApi();

            try
            {
                // List transaction types
                ResourceListOfTransactionMetaData result = apiInstance.ListConfigurationTransactionTypes();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemConfigurationApi.ListConfigurationTransactionTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters
This endpoint does not need any parameter.

### Return type

[**ResourceListOfTransactionMetaData**](ResourceListOfTransactionMetaData.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="setconfigurationtransactiontypes"></a>
# **SetConfigurationTransactionTypes**
> ResourceListOfTransactionMetaData SetConfigurationTransactionTypes (List<TransactionConfigurationDataRequest> types = null)

Set transaction types

Set all transaction types to be used by the movements engine, for the organisation                WARNING! Changing these mappings will have a material impact on how data, new and old, is processed and aggregated by LUSID. This will affect your whole organisation. Only change if you are fully aware of the implications of the change.

### Example
```csharp
using System;
using System.Diagnostics;
using LusidSdk.Api;
using LusidSdk.Client;
using LusidSdk.Model;

namespace Example
{
    public class SetConfigurationTransactionTypesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SystemConfigurationApi();
            var types = new List<TransactionConfigurationDataRequest>(); // List<TransactionConfigurationDataRequest> | The complete set of transaction type definitions (optional) 

            try
            {
                // Set transaction types
                ResourceListOfTransactionMetaData result = apiInstance.SetConfigurationTransactionTypes(types);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling SystemConfigurationApi.SetConfigurationTransactionTypes: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **types** | [**List&lt;TransactionConfigurationDataRequest&gt;**](TransactionConfigurationDataRequest.md)| The complete set of transaction type definitions | [optional] 

### Return type

[**ResourceListOfTransactionMetaData**](ResourceListOfTransactionMetaData.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

