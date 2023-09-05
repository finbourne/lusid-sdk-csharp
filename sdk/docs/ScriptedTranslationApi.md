# Lusid.Sdk.Api.ScriptedTranslationApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetTranslationDialect**](ScriptedTranslationApi.md#gettranslationdialect) | **GET** /api/scriptedtranslation/dialects/{scope}/{vendor}/{sourceSystem}/{entityType}/{serialisationFormat}/{version} | [EARLY ACCESS] GetTranslationDialect: Get a dialect. |
| [**GetTranslationScript**](ScriptedTranslationApi.md#gettranslationscript) | **GET** /api/scriptedtranslation/scripts/{scope}/{code}/{version} | [EARLY ACCESS] GetTranslationScript: Retrieve a translation script by its identifier. |
| [**ListDialectIds**](ScriptedTranslationApi.md#listdialectids) | **GET** /api/scriptedtranslation/dialects/ids | [EARLY ACCESS] ListDialectIds: List dialect identifiers matching an optional filter. |
| [**ListTranslationScriptIds**](ScriptedTranslationApi.md#listtranslationscriptids) | **GET** /api/scriptedtranslation/scripts/ids | [EARLY ACCESS] ListTranslationScriptIds: List translation script identifiers. |
| [**TranslateEntities**](ScriptedTranslationApi.md#translateentities) | **POST** /api/scriptedtranslation/translateentities | [EARLY ACCESS] TranslateEntities: Translate a collection of entities with a specified translation script. |
| [**TranslateEntitiesInlined**](ScriptedTranslationApi.md#translateentitiesinlined) | **POST** /api/scriptedtranslation/translateentitiesinlined | [EARLY ACCESS] TranslateEntitiesInlined: Translate a collection of entities, inlining the body of the translation script. |
| [**UpsertTranslationDialect**](ScriptedTranslationApi.md#upserttranslationdialect) | **POST** /api/scriptedtranslation/dialects | [EARLY ACCESS] UpsertTranslationDialect: Upsert a Dialect. |
| [**UpsertTranslationScript**](ScriptedTranslationApi.md#upserttranslationscript) | **POST** /api/scriptedtranslation/scripts | [EARLY ACCESS] UpsertTranslationScript: Upsert a translation script. |

<a id="gettranslationdialect"></a>
# **GetTranslationDialect**
> Dialect GetTranslationDialect (string scope, string vendor, string sourceSystem, string entityType, string serialisationFormat, string version, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetTranslationDialect: Get a dialect.

Get the dialect with the given identifier at the specific asAt time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetTranslationDialectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScriptedTranslationApi(config);
            var scope = "scope_example";  // string | The scope of the dialect.
            var vendor = "vendor_example";  // string | The vendor of the dialect, the entity that created it. e.g. ISDA, FINBOURNE.
            var sourceSystem = "sourceSystem_example";  // string | The source system of the dialect, the system that understands it. e.g. LUSID, QuantLib.
            var entityType = "entityType_example";  // string | The type of entity this dialect describes e.g. Instrument.
            var serialisationFormat = "serialisationFormat_example";  // string | The serialisation format of a document in this dialect. e.g. JSON, XML.
            var version = "version_example";  // string | The semantic version of the dialect: MAJOR.MINOR.PATCH.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the dialect. Defaults to return the latest version of the dialect if not specified. (optional) 

            try
            {
                // [EARLY ACCESS] GetTranslationDialect: Get a dialect.
                Dialect result = apiInstance.GetTranslationDialect(scope, vendor, sourceSystem, entityType, serialisationFormat, version, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptedTranslationApi.GetTranslationDialect: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTranslationDialectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetTranslationDialect: Get a dialect.
    ApiResponse<Dialect> response = apiInstance.GetTranslationDialectWithHttpInfo(scope, vendor, sourceSystem, entityType, serialisationFormat, version, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScriptedTranslationApi.GetTranslationDialectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope of the dialect. |  |
| **vendor** | **string** | The vendor of the dialect, the entity that created it. e.g. ISDA, FINBOURNE. |  |
| **sourceSystem** | **string** | The source system of the dialect, the system that understands it. e.g. LUSID, QuantLib. |  |
| **entityType** | **string** | The type of entity this dialect describes e.g. Instrument. |  |
| **serialisationFormat** | **string** | The serialisation format of a document in this dialect. e.g. JSON, XML. |  |
| **version** | **string** | The semantic version of the dialect: MAJOR.MINOR.PATCH. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the dialect. Defaults to return the latest version of the dialect if not specified. | [optional]  |

### Return type

[**Dialect**](Dialect.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The dialect with the given ID. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettranslationscript"></a>
# **GetTranslationScript**
> TranslationScript GetTranslationScript (string scope, string code, string version, DateTimeOffset? asAt = null)

[EARLY ACCESS] GetTranslationScript: Retrieve a translation script by its identifier.

Retrieves a translation script to be used for translating financial entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetTranslationScriptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScriptedTranslationApi(config);
            var scope = "scope_example";  // string | Scope of the translation script.
            var code = "code_example";  // string | Code of the translation script.
            var version = "version_example";  // string | Semantic version of the translation script.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the translation script. Defaults to latest. (optional) 

            try
            {
                // [EARLY ACCESS] GetTranslationScript: Retrieve a translation script by its identifier.
                TranslationScript result = apiInstance.GetTranslationScript(scope, code, version, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptedTranslationApi.GetTranslationScript: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTranslationScriptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] GetTranslationScript: Retrieve a translation script by its identifier.
    ApiResponse<TranslationScript> response = apiInstance.GetTranslationScriptWithHttpInfo(scope, code, version, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScriptedTranslationApi.GetTranslationScriptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | Scope of the translation script. |  |
| **code** | **string** | Code of the translation script. |  |
| **version** | **string** | Semantic version of the translation script. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the translation script. Defaults to latest. | [optional]  |

### Return type

[**TranslationScript**](TranslationScript.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested translation script. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listdialectids"></a>
# **ListDialectIds**
> PagedResourceListOfDialectId ListDialectIds (DateTimeOffset? asAt = null, string? page = null, int? limit = null, string? filter = null)

[EARLY ACCESS] ListDialectIds: List dialect identifiers matching an optional filter.

List the stored dialects' identifiers with pagination and filtering at the specified asAt time.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListDialectIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScriptedTranslationApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the dialects.              Defaults to return the latest version of the dialect if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing dialect IDs from a previous call to list dialect IDs.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 

            try
            {
                // [EARLY ACCESS] ListDialectIds: List dialect identifiers matching an optional filter.
                PagedResourceListOfDialectId result = apiInstance.ListDialectIds(asAt, page, limit, filter);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptedTranslationApi.ListDialectIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListDialectIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListDialectIds: List dialect identifiers matching an optional filter.
    ApiResponse<PagedResourceListOfDialectId> response = apiInstance.ListDialectIdsWithHttpInfo(asAt, page, limit, filter);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScriptedTranslationApi.ListDialectIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the dialects.              Defaults to return the latest version of the dialect if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing dialect IDs from a previous call to list dialect IDs.              This value is returned from the previous call. If a pagination token is provided the filter and asAt fields              must not have changed since the original request. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |

### Return type

[**PagedResourceListOfDialectId**](PagedResourceListOfDialectId.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | A collection of dialect IDs. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtranslationscriptids"></a>
# **ListTranslationScriptIds**
> PagedResourceListOfTranslationScriptId ListTranslationScriptIds (DateTimeOffset? asAt = null, int? limit = null, string? filter = null, string? page = null)

[EARLY ACCESS] ListTranslationScriptIds: List translation script identifiers.

List translation script ids.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListTranslationScriptIdsExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScriptedTranslationApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the script identifiers. Defaults to latest. (optional) 
            var limit = 56;  // int? | When paginating, limit the results to this number. Defaults to 100 if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the results. For example, Id.Version.Major eq 1 to list IDs with major version 1              or Id.Scope eq 'my-scripts' to list result only for a particular scope. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing translation script IDs; this              value is returned from the previous call. If a pagination token is provided, the filter field              must not have changed since the original request. (optional) 

            try
            {
                // [EARLY ACCESS] ListTranslationScriptIds: List translation script identifiers.
                PagedResourceListOfTranslationScriptId result = apiInstance.ListTranslationScriptIds(asAt, limit, filter, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptedTranslationApi.ListTranslationScriptIds: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTranslationScriptIdsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] ListTranslationScriptIds: List translation script identifiers.
    ApiResponse<PagedResourceListOfTranslationScriptId> response = apiInstance.ListTranslationScriptIdsWithHttpInfo(asAt, limit, filter, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScriptedTranslationApi.ListTranslationScriptIdsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the script identifiers. Defaults to latest. | [optional]  |
| **limit** | **int?** | When paginating, limit the results to this number. Defaults to 100 if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the results. For example, Id.Version.Major eq 1 to list IDs with major version 1              or Id.Scope eq &#39;my-scripts&#39; to list result only for a particular scope. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing translation script IDs; this              value is returned from the previous call. If a pagination token is provided, the filter field              must not have changed since the original request. | [optional]  |

### Return type

[**PagedResourceListOfTranslationScriptId**](PagedResourceListOfTranslationScriptId.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The requested translation script IDs. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="translateentities"></a>
# **TranslateEntities**
> TranslateEntitiesResponse TranslateEntities (TranslateEntitiesRequest translateEntitiesRequest)

[EARLY ACCESS] TranslateEntities: Translate a collection of entities with a specified translation script.

Run the provided translation request. The entities to translate are specified in the request body as a  dictionary with (ephemeral) unique correlation IDs. The script to use and optional dialect to validate  results against are sourced from the database.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class TranslateEntitiesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScriptedTranslationApi(config);
            var translateEntitiesRequest = new TranslateEntitiesRequest(); // TranslateEntitiesRequest | The entities to translate, along with identifiers for the script and (optional) dialect to use.

            try
            {
                // [EARLY ACCESS] TranslateEntities: Translate a collection of entities with a specified translation script.
                TranslateEntitiesResponse result = apiInstance.TranslateEntities(translateEntitiesRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptedTranslationApi.TranslateEntities: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TranslateEntitiesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] TranslateEntities: Translate a collection of entities with a specified translation script.
    ApiResponse<TranslateEntitiesResponse> response = apiInstance.TranslateEntitiesWithHttpInfo(translateEntitiesRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScriptedTranslationApi.TranslateEntitiesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translateEntitiesRequest** | [**TranslateEntitiesRequest**](TranslateEntitiesRequest.md) | The entities to translate, along with identifiers for the script and (optional) dialect to use. |  |

### Return type

[**TranslateEntitiesResponse**](TranslateEntitiesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The translated entities along with any errors for entities that failed to be translated indexed by their correlation IDs. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="translateentitiesinlined"></a>
# **TranslateEntitiesInlined**
> TranslateEntitiesResponse TranslateEntitiesInlined (TranslateEntitiesInlinedRequest translateEntitiesInlinedRequest)

[EARLY ACCESS] TranslateEntitiesInlined: Translate a collection of entities, inlining the body of the translation script.

Run the provided translation request. The entities to translate, script to use and dialect to validate results against  are all specified in the request body. The entities are given as a dictionary with (ephemeral) unique correlation IDs.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class TranslateEntitiesInlinedExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScriptedTranslationApi(config);
            var translateEntitiesInlinedRequest = new TranslateEntitiesInlinedRequest(); // TranslateEntitiesInlinedRequest | The entities to translate, along with the script to use and an optional schema for validation.

            try
            {
                // [EARLY ACCESS] TranslateEntitiesInlined: Translate a collection of entities, inlining the body of the translation script.
                TranslateEntitiesResponse result = apiInstance.TranslateEntitiesInlined(translateEntitiesInlinedRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptedTranslationApi.TranslateEntitiesInlined: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the TranslateEntitiesInlinedWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] TranslateEntitiesInlined: Translate a collection of entities, inlining the body of the translation script.
    ApiResponse<TranslateEntitiesResponse> response = apiInstance.TranslateEntitiesInlinedWithHttpInfo(translateEntitiesInlinedRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScriptedTranslationApi.TranslateEntitiesInlinedWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translateEntitiesInlinedRequest** | [**TranslateEntitiesInlinedRequest**](TranslateEntitiesInlinedRequest.md) | The entities to translate, along with the script to use and an optional schema for validation. |  |

### Return type

[**TranslateEntitiesResponse**](TranslateEntitiesResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The translated entities along with any errors for entities that failed to be translated indexed by their correlation IDs. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upserttranslationdialect"></a>
# **UpsertTranslationDialect**
> Dialect UpsertTranslationDialect (Dialect dialect)

[EARLY ACCESS] UpsertTranslationDialect: Upsert a Dialect.

Upsert the given dialect.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertTranslationDialectExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScriptedTranslationApi(config);
            var dialect = new Dialect(); // Dialect | The dialect to upsert.

            try
            {
                // [EARLY ACCESS] UpsertTranslationDialect: Upsert a Dialect.
                Dialect result = apiInstance.UpsertTranslationDialect(dialect);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptedTranslationApi.UpsertTranslationDialect: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertTranslationDialectWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertTranslationDialect: Upsert a Dialect.
    ApiResponse<Dialect> response = apiInstance.UpsertTranslationDialectWithHttpInfo(dialect);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScriptedTranslationApi.UpsertTranslationDialectWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **dialect** | [**Dialect**](Dialect.md) | The dialect to upsert. |  |

### Return type

[**Dialect**](Dialect.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The upserted dialect. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upserttranslationscript"></a>
# **UpsertTranslationScript**
> TranslationScript UpsertTranslationScript (TranslationScript translationScript)

[EARLY ACCESS] UpsertTranslationScript: Upsert a translation script.

Upserts a translation script to be used for translating financial entities.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertTranslationScriptExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ScriptedTranslationApi(config);
            var translationScript = new TranslationScript(); // TranslationScript | The translation script to be upserted.

            try
            {
                // [EARLY ACCESS] UpsertTranslationScript: Upsert a translation script.
                TranslationScript result = apiInstance.UpsertTranslationScript(translationScript);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ScriptedTranslationApi.UpsertTranslationScript: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertTranslationScriptWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EARLY ACCESS] UpsertTranslationScript: Upsert a translation script.
    ApiResponse<TranslationScript> response = apiInstance.UpsertTranslationScriptWithHttpInfo(translationScript);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ScriptedTranslationApi.UpsertTranslationScriptWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **translationScript** | [**TranslationScript**](TranslationScript.md) | The translation script to be upserted. |  |

### Return type

[**TranslationScript**](TranslationScript.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The successfully created translation script. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

