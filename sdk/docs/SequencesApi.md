# Lusid.Sdk.Api.SequencesApi

All URIs are relative to *http://local-unit-test-server.lusid.com:38608*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateSequence**](SequencesApi.md#createsequence) | **POST** /api/sequences/{scope} | [EARLY ACCESS] CreateSequence: Create a new sequence
[**GetSequence**](SequencesApi.md#getsequence) | **GET** /api/sequences/{scope}/{code} | [EARLY ACCESS] GetSequence: Get a specified sequence
[**ListSequences**](SequencesApi.md#listsequences) | **GET** /api/sequences | [EARLY ACCESS] ListSequences: List Sequences
[**Next**](SequencesApi.md#next) | **GET** /api/sequences/{scope}/{code}/next | [EARLY ACCESS] Next: Get next values from sequence


<a name="createsequence"></a>
# **CreateSequence**
> SequenceDefinition CreateSequence (string scope, CreateSequenceRequest createSequenceRequest)

[EARLY ACCESS] CreateSequence: Create a new sequence

Create a new sequence

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateSequenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:38608";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SequencesApi(config);
            var scope = scope_example;  // string | Scope of the sequence.
            var createSequenceRequest = new CreateSequenceRequest(); // CreateSequenceRequest | Request to create sequence

            try
            {
                // [EARLY ACCESS] CreateSequence: Create a new sequence
                SequenceDefinition result = apiInstance.CreateSequence(scope, createSequenceRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SequencesApi.CreateSequence: " + e.Message );
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
 **scope** | **string**| Scope of the sequence. | 
 **createSequenceRequest** | [**CreateSequenceRequest**](CreateSequenceRequest.md)| Request to create sequence | 

### Return type

[**SequenceDefinition**](SequenceDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The newly created Sequence |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getsequence"></a>
# **GetSequence**
> SequenceDefinition GetSequence (string scope, string code)

[EARLY ACCESS] GetSequence: Get a specified sequence

Return the details of a specified sequence

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetSequenceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:38608";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SequencesApi(config);
            var scope = scope_example;  // string | Scope of the sequence.
            var code = code_example;  // string | Code of the sequence. This together with stated scope uniquely              identifies the sequence.

            try
            {
                // [EARLY ACCESS] GetSequence: Get a specified sequence
                SequenceDefinition result = apiInstance.GetSequence(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SequencesApi.GetSequence: " + e.Message );
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
 **scope** | **string**| Scope of the sequence. | 
 **code** | **string**| Code of the sequence. This together with stated scope uniquely              identifies the sequence. | 

### Return type

[**SequenceDefinition**](SequenceDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested sequence |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listsequences"></a>
# **ListSequences**
> PagedResourceListOfSequenceDefinition ListSequences (string page = null, int? limit = null, string filter = null)

[EARLY ACCESS] ListSequences: List Sequences

List sequences which satisfies filtering criteria.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListSequencesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:38608";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SequencesApi(config);
            var page = page_example;  // string | The pagination token to use to continue listing sequences from a previous call to list sequences. This  value is returned from the previous call. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. Defaults to 500 if not specified. (optional) 
            var filter = filter_example;  // string | Expression to filter the result set.               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] ListSequences: List Sequences
                PagedResourceListOfSequenceDefinition result = apiInstance.ListSequences(page, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SequencesApi.ListSequences: " + e.Message );
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
 **page** | **string**| The pagination token to use to continue listing sequences from a previous call to list sequences. This  value is returned from the previous call. | [optional] 
 **limit** | **int?**| When paginating, limit the number of returned results to this many. Defaults to 500 if not specified. | [optional] 
 **filter** | **string**| Expression to filter the result set.               Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**PagedResourceListOfSequenceDefinition**](PagedResourceListOfSequenceDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The sequences matching filtering criteria |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="next"></a>
# **Next**
> NextValueInSequenceResponse Next (string scope, string code, int? batch = null)

[EARLY ACCESS] Next: Get next values from sequence

Get the next set of values from a specified sequence

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class NextExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "http://local-unit-test-server.lusid.com:38608";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new SequencesApi(config);
            var scope = scope_example;  // string | Scope of the sequence.
            var code = code_example;  // string | Code of the sequence. This together with stated scope uniquely              identifies the sequence.
            var batch = 56;  // int? | Number of sequences items to return for the specified sequence. Default to 1 if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] Next: Get next values from sequence
                NextValueInSequenceResponse result = apiInstance.Next(scope, code, batch);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling SequencesApi.Next: " + e.Message );
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
 **scope** | **string**| Scope of the sequence. | 
 **code** | **string**| Code of the sequence. This together with stated scope uniquely              identifies the sequence. | 
 **batch** | **int?**| Number of sequences items to return for the specified sequence. Default to 1 if not specified. | [optional] 

### Return type

[**NextValueInSequenceResponse**](NextValueInSequenceResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The response containing next available values in specified sequence. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

