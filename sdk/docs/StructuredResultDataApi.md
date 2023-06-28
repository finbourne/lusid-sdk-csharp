# Lusid.Sdk.Api.StructuredResultDataApi

All URIs are relative to *https://fbn-prd.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetAddressKeyDefinitionsForDocument**](StructuredResultDataApi.md#getaddresskeydefinitionsfordocument) | **GET** /api/unitresults/virtualdocument/{scope}/{code}/{source}/{resultType}/addresskeydefinitions | [EARLY ACCESS] GetAddressKeyDefinitionsForDocument: Get AddressKeyDefinitions for a virtual document.


<a name="getaddresskeydefinitionsfordocument"></a>
# **GetAddressKeyDefinitionsForDocument**
> ResourceListOfAddressKeyDefinition GetAddressKeyDefinitionsForDocument (string scope, string code, string source, string resultType, DateTimeOrCutLabel effectiveAt = null, DateTimeOffset? asAt = null)

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
            config.BasePath = "https://fbn-prd.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new StructuredResultDataApi(config);
            var scope = scope_example;  // string | The scope of the document for which address key definitions are retrieved.
            var code = code_example;  // string | The code of the document for which address key definitions are retrieved.
            var source = source_example;  // string | The source of the document for which address key definitions are retrieved.
            var resultType = resultType_example;  // string | The result type of the document for which address key definitions are retrieved.
            var effectiveAt = effectiveAt_example;  // DateTimeOrCutLabel | The effective datetime to query the document for which the address key definitions are retrieved.              Defaults to querying the latest version if not specified. (optional) 
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | The asAt datetime to query the document for which the address key definitions are retrieved.              Defaults to querying the latest version if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] GetAddressKeyDefinitionsForDocument: Get AddressKeyDefinitions for a virtual document.
                ResourceListOfAddressKeyDefinition result = apiInstance.GetAddressKeyDefinitionsForDocument(scope, code, source, resultType, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling StructuredResultDataApi.GetAddressKeyDefinitionsForDocument: " + e.Message );
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
 **scope** | **string**| The scope of the document for which address key definitions are retrieved. | 
 **code** | **string**| The code of the document for which address key definitions are retrieved. | 
 **source** | **string**| The source of the document for which address key definitions are retrieved. | 
 **resultType** | **string**| The result type of the document for which address key definitions are retrieved. | 
 **effectiveAt** | **DateTimeOrCutLabel**| The effective datetime to query the document for which the address key definitions are retrieved.              Defaults to querying the latest version if not specified. | [optional] 
 **asAt** | **DateTimeOffset?**| The asAt datetime to query the document for which the address key definitions are retrieved.              Defaults to querying the latest version if not specified. | [optional] 

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

