# Lusid.Sdk.Api.ComplianceGenericApi

All URIs are relative to *https://www.lusid.com/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeleteComplianceRule2**](ComplianceGenericApi.md#deletecompliancerule2) | **DELETE** /api/compliance/generic/rules/{scope}/{code} | [EARLY ACCESS] DeleteComplianceRule2: Get compliance rule.
[**GetComplianceRule2**](ComplianceGenericApi.md#getcompliancerule2) | **GET** /api/compliance/generic/rules/{scope}/{code} | [EARLY ACCESS] GetComplianceRule2: Get compliance rule.
[**GetComplianceTemplate**](ComplianceGenericApi.md#getcompliancetemplate) | **GET** /api/compliance/templates/{scope}/{code} | [EARLY ACCESS] GetComplianceTemplate: Get the requested compliance template.
[**ListComplianceRules2**](ComplianceGenericApi.md#listcompliancerules2) | **GET** /api/compliance/generic/rules | [EARLY ACCESS] ListComplianceRules2: List compliance rules.
[**ListComplianceTemplates**](ComplianceGenericApi.md#listcompliancetemplates) | **GET** /api/compliance/templates | [EARLY ACCESS] ListComplianceTemplates: Get a specific compliance template
[**UpsertComplianceRule**](ComplianceGenericApi.md#upsertcompliancerule) | **POST** /api/compliance/generic/rules | [EARLY ACCESS] UpsertComplianceRule: Upsert a compliance rule.


<a name="deletecompliancerule2"></a>
# **DeleteComplianceRule2**
> DeletedEntityResponse DeleteComplianceRule2 (string scope, string code)

[EARLY ACCESS] DeleteComplianceRule2: Get compliance rule.

PLEASE NOTE: loopback EarlyAccess endpoint for discussion only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteComplianceRule2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplianceGenericApi(config);
            var scope = scope_example;  // string | The compliance rule's scope.
            var code = code_example;  // string | The compliance rule's code.

            try
            {
                // [EARLY ACCESS] DeleteComplianceRule2: Get compliance rule.
                DeletedEntityResponse result = apiInstance.DeleteComplianceRule2(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplianceGenericApi.DeleteComplianceRule2: " + e.Message );
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
 **scope** | **string**| The compliance rule&#39;s scope. | 
 **code** | **string**| The compliance rule&#39;s code. | 

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

<a name="getcompliancerule2"></a>
# **GetComplianceRule2**
> ComplianceRuleResponse GetComplianceRule2 (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetComplianceRule2: Get compliance rule.

PLEASE NOTE: loopback EarlyAccess endpoint for discussion only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetComplianceRule2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplianceGenericApi(config);
            var scope = scope_example;  // string | The compliance rule's scope.
            var code = code_example;  // string | The compliance rule's code.
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. Asat time for query. (optional) 

            try
            {
                // [EARLY ACCESS] GetComplianceRule2: Get compliance rule.
                ComplianceRuleResponse result = apiInstance.GetComplianceRule2(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplianceGenericApi.GetComplianceRule2: " + e.Message );
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
 **scope** | **string**| The compliance rule&#39;s scope. | 
 **code** | **string**| The compliance rule&#39;s code. | 
 **asAt** | **DateTimeOffset?**| Optional. Asat time for query. | [optional] 

### Return type

[**ComplianceRuleResponse**](ComplianceRuleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested compliance rule. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getcompliancetemplate"></a>
# **GetComplianceTemplate**
> ComplianceTemplate GetComplianceTemplate (string scope, string code, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetComplianceTemplate: Get the requested compliance template.

Use this endpoint to fetch a specific compliance template.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetComplianceTemplateExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplianceGenericApi(config);
            var scope = scope_example;  // string | Scope of TemplateID
            var code = code_example;  // string | Code of TemplateID
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The time at which to get results from. Default : latest (optional) 

            try
            {
                // [EARLY ACCESS] GetComplianceTemplate: Get the requested compliance template.
                ComplianceTemplate result = apiInstance.GetComplianceTemplate(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplianceGenericApi.GetComplianceTemplate: " + e.Message );
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
 **scope** | **string**| Scope of TemplateID | 
 **code** | **string**| Code of TemplateID | 
 **asAt** | **DateTimeOffset?**| Optional. The time at which to get results from. Default : latest | [optional] 

### Return type

[**ComplianceTemplate**](ComplianceTemplate.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested compliance template. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcompliancerules2"></a>
# **ListComplianceRules2**
> PagedResourceListOfComplianceRuleResponse ListComplianceRules2 (DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null)

[EARLY ACCESS] ListComplianceRules2: List compliance rules.

PLEASE NOTE: loopback EarlyAccess endpoint for discussion only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListComplianceRules2Example
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplianceGenericApi(config);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. Asat time. (optional) 
            var page = page_example;  // string | Optional. Pagination token. (optional) 
            var start = 56;  // int? | Optional. Entry at which to start. (optional) 
            var limit = 56;  // int? | Optional. Entries per page. (optional) 
            var filter = filter_example;  // string | Optional. Filter. (optional) 

            try
            {
                // [EARLY ACCESS] ListComplianceRules2: List compliance rules.
                PagedResourceListOfComplianceRuleResponse result = apiInstance.ListComplianceRules2(asAt, page, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplianceGenericApi.ListComplianceRules2: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| Optional. Asat time. | [optional] 
 **page** | **string**| Optional. Pagination token. | [optional] 
 **start** | **int?**| Optional. Entry at which to start. | [optional] 
 **limit** | **int?**| Optional. Entries per page. | [optional] 
 **filter** | **string**| Optional. Filter. | [optional] 

### Return type

[**PagedResourceListOfComplianceRuleResponse**](PagedResourceListOfComplianceRuleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of compliance rules. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="listcompliancetemplates"></a>
# **ListComplianceTemplates**
> PagedResourceListOfComplianceTemplate ListComplianceTemplates (DateTimeOffset? asAt = null, string page = null, int? start = null, int? limit = null, string filter = null)

[EARLY ACCESS] ListComplianceTemplates: Get a specific compliance template

Use this endpoint to fetch a list of all available compliance template ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListComplianceTemplatesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplianceGenericApi(config);
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | Optional. The time at which to get results from. Default : latest (optional) 
            var page = page_example;  // string | Optional. The pagination token to use to continue listing compliance runs from a previous call to list compliance runs.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results. (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 
            var filter = filter_example;  // string | Optional. Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] ListComplianceTemplates: Get a specific compliance template
                PagedResourceListOfComplianceTemplate result = apiInstance.ListComplianceTemplates(asAt, page, start, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplianceGenericApi.ListComplianceTemplates: " + e.Message );
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
 **asAt** | **DateTimeOffset?**| Optional. The time at which to get results from. Default : latest | [optional] 
 **page** | **string**| Optional. The pagination token to use to continue listing compliance runs from a previous call to list compliance runs.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, and asAt fields              must not have changed since the original request. Also, if set, a start value cannot be provided. | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results. | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 
 **filter** | **string**| Optional. Expression to filter the result set. Read more about filtering results from LUSID here https://support.lusid.com/filtering-results-from-lusid. | [optional] 

### Return type

[**PagedResourceListOfComplianceTemplate**](PagedResourceListOfComplianceTemplate.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The list of compliance templates available. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertcompliancerule"></a>
# **UpsertComplianceRule**
> ComplianceRuleResponse UpsertComplianceRule (UpsertComplianceRuleRequest upsertComplianceRuleRequest = null)

[EARLY ACCESS] UpsertComplianceRule: Upsert a compliance rule.

PLEASE NOTE: loopback EarlyAccess endpoint for discussion only.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertComplianceRuleExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ComplianceGenericApi(config);
            var upsertComplianceRuleRequest = new UpsertComplianceRuleRequest(); // UpsertComplianceRuleRequest |  (optional) 

            try
            {
                // [EARLY ACCESS] UpsertComplianceRule: Upsert a compliance rule.
                ComplianceRuleResponse result = apiInstance.UpsertComplianceRule(upsertComplianceRuleRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ComplianceGenericApi.UpsertComplianceRule: " + e.Message );
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
 **upsertComplianceRuleRequest** | [**UpsertComplianceRuleRequest**](UpsertComplianceRuleRequest.md)|  | [optional] 

### Return type

[**ComplianceRuleResponse**](ComplianceRuleResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upserted compliance rule. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

