# Lusid.Sdk.Api.InstrumentEventTypesApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTransactionTemplate**](InstrumentEventTypesApi.md#createtransactiontemplate) | **POST** /api/instrumenteventtypes/{instrumentEventType}/transactiontemplates/{instrumentType}/{scope} | [EXPERIMENTAL] CreateTransactionTemplate: Create Transaction Template |
| [**GetTransactionTemplateSpecification**](InstrumentEventTypesApi.md#gettransactiontemplatespecification) | **GET** /api/instrumenteventtypes/{instrumentEventType}/transactiontemplatespecification | [EXPERIMENTAL] GetTransactionTemplateSpecification: Get Transaction Template Specification. |

<a id="createtransactiontemplate"></a>
# **CreateTransactionTemplate**
> TransactionTemplateResponse CreateTransactionTemplate (string instrumentEventType, string instrumentType, string scope, TransactionTemplateRequest transactionTemplateRequest)

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
            var instrumentType = "instrumentType_example";  // string | The template is applied to events which originate from instruments of this type
            var scope = "scope_example";  // string | The scope in which the template lies.
            var transactionTemplateRequest = new TransactionTemplateRequest(); // TransactionTemplateRequest | A request defining a new transaction template to be created.

            try
            {
                // [EXPERIMENTAL] CreateTransactionTemplate: Create Transaction Template
                TransactionTemplateResponse result = apiInstance.CreateTransactionTemplate(instrumentEventType, instrumentType, scope, transactionTemplateRequest);
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
    ApiResponse<TransactionTemplateResponse> response = apiInstance.CreateTransactionTemplateWithHttpInfo(instrumentEventType, instrumentType, scope, transactionTemplateRequest);
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
| **instrumentType** | **string** | The template is applied to events which originate from instruments of this type |  |
| **scope** | **string** | The scope in which the template lies. |  |
| **transactionTemplateRequest** | [**TransactionTemplateRequest**](TransactionTemplateRequest.md) | A request defining a new transaction template to be created. |  |

### Return type

[**TransactionTemplateResponse**](TransactionTemplateResponse.md)

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

