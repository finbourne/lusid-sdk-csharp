# Lusid.Sdk.Api.PersonalisationsApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**DeletePersonalisation**](PersonalisationsApi.md#deletepersonalisation) | **DELETE** /api/personalisations | Delete a personalisation
[**GetPersonalisations**](PersonalisationsApi.md#getpersonalisations) | **GET** /api/personalisations | Get personalisation
[**UpsertPersonalisations**](PersonalisationsApi.md#upsertpersonalisations) | **POST** /api/personalisations | Upsert personalisations


<a name="deletepersonalisation"></a>
# **DeletePersonalisation**
> DeletedEntityResponse DeletePersonalisation (string key = null, string scope = null, string group = null)

Delete a personalisation

Delete a personalisation at a specific scope (or use scope ALL to purge the setting entirely)

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePersonalisationExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonalisationsApi();
            var key = key_example;  // string | The key of the setting to be deleted (optional) 
            var scope = scope_example;  // string | The scope to delete at (use ALL to purge the setting entirely) (optional) 
            var group = group_example;  // string | Optional. If deleting a setting at group level, specify the group here (optional) 

            try
            {
                // Delete a personalisation
                DeletedEntityResponse result = apiInstance.DeletePersonalisation(key, scope, group);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalisationsApi.DeletePersonalisation: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **key** | **string**| The key of the setting to be deleted | [optional] 
 **scope** | **string**| The scope to delete at (use ALL to purge the setting entirely) | [optional] 
 **group** | **string**| Optional. If deleting a setting at group level, specify the group here | [optional] 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getpersonalisations"></a>
# **GetPersonalisations**
> ResourceListOfPersonalisation GetPersonalisations (string pattern = null, string scope = null, bool? recursive = null, bool? wildcards = null, List<string> sortBy = null, int? start = null, int? limit = null)

Get personalisation

Get a personalisation, recursing to get any referenced if required.

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPersonalisationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonalisationsApi();
            var pattern = pattern_example;  // string | The search pattern or specific key (optional) 
            var scope = scope_example;  // string | Optional. The scope level to request for (optional) 
            var recursive = true;  // bool? | Optional. Whether to recurse into dereference recursive settings (optional)  (default to false)
            var wildcards = true;  // bool? | Optional. Whether to apply wildcards to the provided pattern and pull back any matching (optional)  (default to false)
            var sortBy = new List<string>(); // List<string> | Optional. Order the results by these fields. Use use the '-' sign to denote descending order e.g. -MyFieldName (optional) 
            var start = 56;  // int? | Optional. When paginating, skip this number of results (optional) 
            var limit = 56;  // int? | Optional. When paginating, limit the number of returned results to this many. (optional) 

            try
            {
                // Get personalisation
                ResourceListOfPersonalisation result = apiInstance.GetPersonalisations(pattern, scope, recursive, wildcards, sortBy, start, limit);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalisationsApi.GetPersonalisations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **pattern** | **string**| The search pattern or specific key | [optional] 
 **scope** | **string**| Optional. The scope level to request for | [optional] 
 **recursive** | **bool?**| Optional. Whether to recurse into dereference recursive settings | [optional] [default to false]
 **wildcards** | **bool?**| Optional. Whether to apply wildcards to the provided pattern and pull back any matching | [optional] [default to false]
 **sortBy** | [**List&lt;string&gt;**](string.md)| Optional. Order the results by these fields. Use use the &#39;-&#39; sign to denote descending order e.g. -MyFieldName | [optional] 
 **start** | **int?**| Optional. When paginating, skip this number of results | [optional] 
 **limit** | **int?**| Optional. When paginating, limit the number of returned results to this many. | [optional] 

### Return type

[**ResourceListOfPersonalisation**](ResourceListOfPersonalisation.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="upsertpersonalisations"></a>
# **UpsertPersonalisations**
> UpsertPersonalisationResponse UpsertPersonalisations (List<Personalisation> personalisations = null)

Upsert personalisations

Upsert one or more personalisations

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPersonalisationsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PersonalisationsApi();
            var personalisations = new List<Personalisation>(); // List<Personalisation> | The set of personalisations to persist (optional) 

            try
            {
                // Upsert personalisations
                UpsertPersonalisationResponse result = apiInstance.UpsertPersonalisations(personalisations);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling PersonalisationsApi.UpsertPersonalisations: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **personalisations** | [**List&lt;Personalisation&gt;**](Personalisation.md)| The set of personalisations to persist | [optional] 

### Return type

[**UpsertPersonalisationResponse**](UpsertPersonalisationResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

