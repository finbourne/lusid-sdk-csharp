# Lusid.Sdk.Api.TaxRuleSetsApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTaxRuleSet**](TaxRuleSetsApi.md#createtaxruleset) | **POST** /api/tax/rulesets | [EXPERIMENTAL] CreateTaxRuleSet: Create a tax rule set. |
| [**DeleteTaxRuleSet**](TaxRuleSetsApi.md#deletetaxruleset) | **DELETE** /api/tax/rulesets/{scope}/{code} | [EXPERIMENTAL] DeleteTaxRuleSet: Delete a tax rule set. |
| [**GetTaxRuleSet**](TaxRuleSetsApi.md#gettaxruleset) | **GET** /api/tax/rulesets/{scope}/{code} | [EXPERIMENTAL] GetTaxRuleSet: Retrieve the definition of single tax rule set. |
| [**ListTaxRuleSets**](TaxRuleSetsApi.md#listtaxrulesets) | **GET** /api/tax/rulesets | [EXPERIMENTAL] ListTaxRuleSets: List tax rule sets. |
| [**UpdateTaxRuleSet**](TaxRuleSetsApi.md#updatetaxruleset) | **PUT** /api/tax/rulesets/{scope}/{code} | [EXPERIMENTAL] UpdateTaxRuleSet: Update a tax rule set. |

<a id="createtaxruleset"></a>
# **CreateTaxRuleSet**
> TaxRuleSet CreateTaxRuleSet (CreateTaxRuleSetRequest createTaxRuleSetRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] CreateTaxRuleSet: Create a tax rule set.

Creates a tax rule set definition at the given effective time.  The user must be entitled to read any properties specified in each rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class CreateTaxRuleSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxRuleSetsApi(config);
            var createTaxRuleSetRequest = new CreateTaxRuleSetRequest(); // CreateTaxRuleSetRequest | The contents of the rule set.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which the rule set will take effect.  Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] CreateTaxRuleSet: Create a tax rule set.
                TaxRuleSet result = apiInstance.CreateTaxRuleSet(createTaxRuleSetRequest, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxRuleSetsApi.CreateTaxRuleSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTaxRuleSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateTaxRuleSet: Create a tax rule set.
    ApiResponse<TaxRuleSet> response = apiInstance.CreateTaxRuleSetWithHttpInfo(createTaxRuleSetRequest, effectiveAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxRuleSetsApi.CreateTaxRuleSetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTaxRuleSetRequest** | [**CreateTaxRuleSetRequest**](CreateTaxRuleSetRequest.md) | The contents of the rule set. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which the rule set will take effect.  Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**TaxRuleSet**](TaxRuleSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Create a rule set for tax calculations. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetaxruleset"></a>
# **DeleteTaxRuleSet**
> DeletedEntityResponse DeleteTaxRuleSet (string scope, string code)

[EXPERIMENTAL] DeleteTaxRuleSet: Delete a tax rule set.

<br>              Deletes the rule set for all effective time.                <br>              The rule set will remain viewable at previous as at times, but it will no longer be considered applicable.                <br>              This cannot be undone.              

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeleteTaxRuleSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxRuleSetsApi(config);
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.

            try
            {
                // [EXPERIMENTAL] DeleteTaxRuleSet: Delete a tax rule set.
                DeletedEntityResponse result = apiInstance.DeleteTaxRuleSet(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxRuleSetsApi.DeleteTaxRuleSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTaxRuleSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteTaxRuleSet: Delete a tax rule set.
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteTaxRuleSetWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxRuleSetsApi.DeleteTaxRuleSetWithHttpInfo: " + e.Message);
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

<a id="gettaxruleset"></a>
# **GetTaxRuleSet**
> TaxRuleSet GetTaxRuleSet (string scope, string code, DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetTaxRuleSet: Retrieve the definition of single tax rule set.

Retrieves the tax rule set definition at the given effective and as at times.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetTaxRuleSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxRuleSetsApi(config);
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the rule definition.  Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rule definition. Defaults to returning the latest version if not  specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetTaxRuleSet: Retrieve the definition of single tax rule set.
                TaxRuleSet result = apiInstance.GetTaxRuleSet(scope, code, effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxRuleSetsApi.GetTaxRuleSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaxRuleSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetTaxRuleSet: Retrieve the definition of single tax rule set.
    ApiResponse<TaxRuleSet> response = apiInstance.GetTaxRuleSetWithHttpInfo(scope, code, effectiveAt, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxRuleSetsApi.GetTaxRuleSetWithHttpInfo: " + e.Message);
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

[**TaxRuleSet**](TaxRuleSet.md)

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

<a id="listtaxrulesets"></a>
# **ListTaxRuleSets**
> ResourceListOfTaxRuleSet ListTaxRuleSets (DateTimeOrCutLabel? effectiveAt = null, DateTimeOffset? asAt = null)

[EXPERIMENTAL] ListTaxRuleSets: List tax rule sets.

Retrieves all tax rule set definitions at the given effective and as at times

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListTaxRuleSetsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxRuleSetsApi(config);
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which to retrieve the rule definitions.  Defaults to the current LUSID system datetime if not specified. (optional) 
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the rule definitions. Defaults to returning the latest version if not  specified. (optional) 

            try
            {
                // [EXPERIMENTAL] ListTaxRuleSets: List tax rule sets.
                ResourceListOfTaxRuleSet result = apiInstance.ListTaxRuleSets(effectiveAt, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxRuleSetsApi.ListTaxRuleSets: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTaxRuleSetsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListTaxRuleSets: List tax rule sets.
    ApiResponse<ResourceListOfTaxRuleSet> response = apiInstance.ListTaxRuleSetsWithHttpInfo(effectiveAt, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxRuleSetsApi.ListTaxRuleSetsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which to retrieve the rule definitions.  Defaults to the current LUSID system datetime if not specified. | [optional]  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the rule definitions. Defaults to returning the latest version if not  specified. | [optional]  |

### Return type

[**ResourceListOfTaxRuleSet**](ResourceListOfTaxRuleSet.md)

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

<a id="updatetaxruleset"></a>
# **UpdateTaxRuleSet**
> TaxRuleSet UpdateTaxRuleSet (string scope, string code, UpdateTaxRuleSetRequest updateTaxRuleSetRequest, DateTimeOrCutLabel? effectiveAt = null)

[EXPERIMENTAL] UpdateTaxRuleSet: Update a tax rule set.

Updates the tax rule set definition at the given effective time.  The changes will take place from this effective time until the next effective time that the rule has been updated at.  For example, consider a rule that has been created or updated effective at the first day of the coming month.  An upsert effective from the current day will only change the definition until that day.  An additional upsert at the same time (first day of the month) is required if the newly-updated definition is to supersede the future definition.  The user must be entitled to read any properties specified in each rule.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpdateTaxRuleSetExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaxRuleSetsApi(config);
            var scope = "scope_example";  // string | The rule set scope.
            var code = "code_example";  // string | The rule set code.
            var updateTaxRuleSetRequest = new UpdateTaxRuleSetRequest(); // UpdateTaxRuleSetRequest | The contents of the rule set.
            var effectiveAt = "effectiveAt_example";  // DateTimeOrCutLabel? | The effective datetime or cut label at which the rule set will take effect.  Defaults to the current LUSID system datetime if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] UpdateTaxRuleSet: Update a tax rule set.
                TaxRuleSet result = apiInstance.UpdateTaxRuleSet(scope, code, updateTaxRuleSetRequest, effectiveAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaxRuleSetsApi.UpdateTaxRuleSet: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTaxRuleSetWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateTaxRuleSet: Update a tax rule set.
    ApiResponse<TaxRuleSet> response = apiInstance.UpdateTaxRuleSetWithHttpInfo(scope, code, updateTaxRuleSetRequest, effectiveAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TaxRuleSetsApi.UpdateTaxRuleSetWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The rule set scope. |  |
| **code** | **string** | The rule set code. |  |
| **updateTaxRuleSetRequest** | [**UpdateTaxRuleSetRequest**](UpdateTaxRuleSetRequest.md) | The contents of the rule set. |  |
| **effectiveAt** | **DateTimeOrCutLabel?** | The effective datetime or cut label at which the rule set will take effect.  Defaults to the current LUSID system datetime if not specified. | [optional]  |

### Return type

[**TaxRuleSet**](TaxRuleSet.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Update rules for tax calculations. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

