# Lusid.Sdk.Api.AmortisationRuleSetsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateAmortisationRuleSet**](AmortisationRuleSetsApi.md#createamortisationruleset) | **POST** /api/amortisation/rulesets/{scope} | [EXPERIMENTAL] CreateAmortisationRuleSet: Create an amortisation rule set. |
| [**DeleteAmortisationRuleset**](AmortisationRuleSetsApi.md#deleteamortisationruleset) | **DELETE** /api/amortisation/rulesets/{scope}/{code} | [EXPERIMENTAL] DeleteAmortisationRuleset: Delete an amortisation rule set. |
| [**GetAmortisationRuleSet**](AmortisationRuleSetsApi.md#getamortisationruleset) | **GET** /api/amortisation/rulesets/{scope}/{code} | [EXPERIMENTAL] GetAmortisationRuleSet: Retrieve the definition of a single amortisation rule set |
| [**ListAmortisationRuleSets**](AmortisationRuleSetsApi.md#listamortisationrulesets) | **GET** /api/amortisation/rulesets | [EXPERIMENTAL] ListAmortisationRuleSets: List amortisation rule sets. |
| [**SetAmortisationRules**](AmortisationRuleSetsApi.md#setamortisationrules) | **PUT** /api/amortisation/rulesets/{scope}/{code}/rules | [EXPERIMENTAL] SetAmortisationRules: Set Amortisation Rules on an existing Amortisation Rule Set. |
| [**UpdateAmortisationRuleSetDetails**](AmortisationRuleSetsApi.md#updateamortisationrulesetdetails) | **PUT** /api/amortisation/rulesets/{scope}/{code}/details | [EXPERIMENTAL] UpdateAmortisationRuleSetDetails: Update an amortisation rule set. |

<a id="createamortisationruleset"></a>
# **CreateAmortisationRuleSet**
> AmortisationRuleSet CreateAmortisationRuleSet (string scope, CreateAmortisationRuleSetRequest createAmortisationRuleSetRequest)

[EXPERIMENTAL] CreateAmortisationRuleSet: Create an amortisation rule set.

Creates an amortisation rule set definition at the given effective time.  The user must be entitled to read any properties specified in each rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateAmortisationRuleSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AmortisationRuleSetsApi(config);
            var scope = "scope_example";  // string | The scope of the rule set.
            var createAmortisationRuleSetRequest = new CreateAmortisationRuleSetRequest(); // CreateAmortisationRuleSetRequest | The contents of the rule set.

            try
            {
                // [EXPERIMENTAL] CreateAmortisationRuleSet: Create an amortisation rule set.
                AmortisationRuleSet result = apiInstance.CreateAmortisationRuleSet(scope, createAmortisationRuleSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmortisationRuleSetsApi.CreateAmortisationRuleSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateAmortisationRuleSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateAmortisationRuleSet: Create an amortisation rule set.
    ApiResponse<AmortisationRuleSet> response = apiInstance.CreateAmortisationRuleSetWithHttpInfo(scope, createAmortisationRuleSetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmortisationRuleSetsApi.CreateAmortisationRuleSetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the rule set. |  |
| **createAmortisationRuleSetRequest** | [**CreateAmortisationRuleSetRequest**](CreateAmortisationRuleSetRequest.md) | The contents of the rule set. |  |

### Return type

[**AmortisationRuleSet**](AmortisationRuleSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Create a rule set for amortisation. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deleteamortisationruleset"></a>
# **DeleteAmortisationRuleset**
> DeletedEntityResponse DeleteAmortisationRuleset (string scope, string code)

[EXPERIMENTAL] DeleteAmortisationRuleset: Delete an amortisation rule set.

<br>              Deletes the rule set perpetually, including its rules.                <br>              The rule set will remain viewable at previous as at times, but it will no longer be considered applicable.                <br>              This cannot be undone.              

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteAmortisationRulesetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AmortisationRuleSetsApi(config);
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.

            try
            {
                // [EXPERIMENTAL] DeleteAmortisationRuleset: Delete an amortisation rule set.
                DeletedEntityResponse result = apiInstance.DeleteAmortisationRuleset(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmortisationRuleSetsApi.DeleteAmortisationRuleset: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteAmortisationRulesetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteAmortisationRuleset: Delete an amortisation rule set.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteAmortisationRulesetWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmortisationRuleSetsApi.DeleteAmortisationRulesetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The rule set scope. |  |
| **code** | **string** | The rule set code. |  |

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

<a id="getamortisationruleset"></a>
# **GetAmortisationRuleSet**
> AmortisationRuleSet GetAmortisationRuleSet (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetAmortisationRuleSet: Retrieve the definition of a single amortisation rule set

Retrieves the amortisation rule set definition at the given effective and as at times.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetAmortisationRuleSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AmortisationRuleSetsApi(config);
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the rule definition.  Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rule definition. Defaults to returning the latest version if not  specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetAmortisationRuleSet: Retrieve the definition of a single amortisation rule set
                AmortisationRuleSet result = apiInstance.GetAmortisationRuleSet(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmortisationRuleSetsApi.GetAmortisationRuleSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetAmortisationRuleSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetAmortisationRuleSet: Retrieve the definition of a single amortisation rule set
    ApiResponse<AmortisationRuleSet> response = apiInstance.GetAmortisationRuleSetWithHttpInfo(scope, code, effectiveAt, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmortisationRuleSetsApi.GetAmortisationRuleSetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The rule set scope. |  |
| **code** | **string** | The rule set code. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the rule definition.  Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the rule definition. Defaults to returning the latest version if not  specified. | [optional]  |

### Return type

[**AmortisationRuleSet**](AmortisationRuleSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Details of one rule set. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listamortisationrulesets"></a>
# **ListAmortisationRuleSets**
> PagedResourceListOfAmortisationRuleSet ListAmortisationRuleSets (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null, List<string>? sortBy = null)

[EXPERIMENTAL] ListAmortisationRuleSets: List amortisation rule sets.

Retrieves all amortisation rule sets at the given effective and as at times

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListAmortisationRuleSetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AmortisationRuleSetsApi(config);
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the rule definitions.  Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rule definitions. Defaults to returning the latest version if not  specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing AmortisationRuleSets; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 

            try
            {
                // [EXPERIMENTAL] ListAmortisationRuleSets: List amortisation rule sets.
                PagedResourceListOfAmortisationRuleSet result = apiInstance.ListAmortisationRuleSets(effectiveAt, asAt, page, limit, filter, sortBy);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmortisationRuleSetsApi.ListAmortisationRuleSets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListAmortisationRuleSetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListAmortisationRuleSets: List amortisation rule sets.
    ApiResponse<PagedResourceListOfAmortisationRuleSet> response = apiInstance.ListAmortisationRuleSetsWithHttpInfo(effectiveAt, asAt, page, limit, filter, sortBy);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmortisationRuleSetsApi.ListAmortisationRuleSetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the rule definitions.  Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the rule definitions. Defaults to returning the latest version if not  specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing AmortisationRuleSets; this              value is returned from the previous call. If a pagination token is provided, the filter, effectiveAt              and asAt fields must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results.              For more information about filtering results, see https://support.lusid.com/knowledgebase/article/KA-01914. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |

### Return type

[**PagedResourceListOfAmortisationRuleSet**](PagedResourceListOfAmortisationRuleSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A list of rule sets available. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="setamortisationrules"></a>
# **SetAmortisationRules**
> AmortisationRuleSet SetAmortisationRules (string scope, string code, SetAmortisationRulesRequest setAmortisationRulesRequest)

[EXPERIMENTAL] SetAmortisationRules: Set Amortisation Rules on an existing Amortisation Rule Set.

Sets the rules on the Amortisation Rule Set, replacing the existing rules with the set provided.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class SetAmortisationRulesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AmortisationRuleSetsApi(config);
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.
            var setAmortisationRulesRequest = new SetAmortisationRulesRequest(); // SetAmortisationRulesRequest | The contents of the rules.

            try
            {
                // [EXPERIMENTAL] SetAmortisationRules: Set Amortisation Rules on an existing Amortisation Rule Set.
                AmortisationRuleSet result = apiInstance.SetAmortisationRules(scope, code, setAmortisationRulesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmortisationRuleSetsApi.SetAmortisationRules: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the SetAmortisationRulesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] SetAmortisationRules: Set Amortisation Rules on an existing Amortisation Rule Set.
    ApiResponse<AmortisationRuleSet> response = apiInstance.SetAmortisationRulesWithHttpInfo(scope, code, setAmortisationRulesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmortisationRuleSetsApi.SetAmortisationRulesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The rule set scope. |  |
| **code** | **string** | The rule set code. |  |
| **setAmortisationRulesRequest** | [**SetAmortisationRulesRequest**](SetAmortisationRulesRequest.md) | The contents of the rules. |  |

### Return type

[**AmortisationRuleSet**](AmortisationRuleSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update the rules for an amortisation rule set. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updateamortisationrulesetdetails"></a>
# **UpdateAmortisationRuleSetDetails**
> AmortisationRuleSet UpdateAmortisationRuleSetDetails (string scope, string code, UpdateAmortisationRuleSetDetailsRequest updateAmortisationRuleSetDetailsRequest)

[EXPERIMENTAL] UpdateAmortisationRuleSetDetails: Update an amortisation rule set.

Updates the amortisation rule set definition for all effective time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateAmortisationRuleSetDetailsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new AmortisationRuleSetsApi(config);
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.
            var updateAmortisationRuleSetDetailsRequest = new UpdateAmortisationRuleSetDetailsRequest(); // UpdateAmortisationRuleSetDetailsRequest | The contents of the rule set.

            try
            {
                // [EXPERIMENTAL] UpdateAmortisationRuleSetDetails: Update an amortisation rule set.
                AmortisationRuleSet result = apiInstance.UpdateAmortisationRuleSetDetails(scope, code, updateAmortisationRuleSetDetailsRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AmortisationRuleSetsApi.UpdateAmortisationRuleSetDetails: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateAmortisationRuleSetDetailsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateAmortisationRuleSetDetails: Update an amortisation rule set.
    ApiResponse<AmortisationRuleSet> response = apiInstance.UpdateAmortisationRuleSetDetailsWithHttpInfo(scope, code, updateAmortisationRuleSetDetailsRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling AmortisationRuleSetsApi.UpdateAmortisationRuleSetDetailsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The rule set scope. |  |
| **code** | **string** | The rule set code. |  |
| **updateAmortisationRuleSetDetailsRequest** | [**UpdateAmortisationRuleSetDetailsRequest**](UpdateAmortisationRuleSetDetailsRequest.md) | The contents of the rule set. |  |

### Return type

[**AmortisationRuleSet**](AmortisationRuleSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update the details of an Amortisation Rule Set. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

