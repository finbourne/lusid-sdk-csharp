# Lusid.Sdk.Api.PackagesApi

All URIs are relative to *https://www.lusid.com/api*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**DeletePackage**](PackagesApi.md#deletepackage) | **DELETE** /api/packages/{scope}/{code} | [EXPERIMENTAL] DeletePackage: Delete package |
| [**GetPackage**](PackagesApi.md#getpackage) | **GET** /api/packages/{scope}/{code} | [EXPERIMENTAL] GetPackage: Get Package |
| [**ListPackages**](PackagesApi.md#listpackages) | **GET** /api/packages | [EXPERIMENTAL] ListPackages: List Packages |
| [**UpsertPackages**](PackagesApi.md#upsertpackages) | **POST** /api/packages | [EXPERIMENTAL] UpsertPackages: Upsert Package |

<a id="deletepackage"></a>
# **DeletePackage**
> DeletedEntityResponse DeletePackage (string scope, string code)

[EXPERIMENTAL] DeletePackage: Delete package

Delete an package. Deletion will be valid from the package's creation datetime.  This means that the package will no longer exist at any effective datetime from the asAt datetime of deletion.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class DeletePackageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PackagesApi(config);
            var scope = "scope_example";  // string | The package scope.
            var code = "code_example";  // string | The package's code. This, together with the scope uniquely identifies the package to delete.

            try
            {
                // [EXPERIMENTAL] DeletePackage: Delete package
                DeletedEntityResponse result = apiInstance.DeletePackage(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PackagesApi.DeletePackage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeletePackageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeletePackage: Delete package
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeletePackageWithHttpInfo(scope, code);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PackagesApi.DeletePackageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The package scope. |  |
| **code** | **string** | The package&#39;s code. This, together with the scope uniquely identifies the package to delete. |  |

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
| **200** | The response from deleting an package. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="getpackage"></a>
# **GetPackage**
> Package GetPackage (string scope, string code, DateTimeOffset? asAt = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] GetPackage: Get Package

Fetch a Package that matches the specified identifier

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetPackageExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PackagesApi(config);
            var scope = "scope_example";  // string | The scope to which the package belongs.
            var code = "code_example";  // string | The package's unique identifier.
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the package. Defaults to return the latest version of the package if not specified. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Package\" domain to decorate onto the package.              These take the format {domain}/{scope}/{code} e.g. \"Package/system/Name\". (optional) 

            try
            {
                // [EXPERIMENTAL] GetPackage: Get Package
                Package result = apiInstance.GetPackage(scope, code, asAt, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PackagesApi.GetPackage: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetPackageWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetPackage: Get Package
    ApiResponse<Package> response = apiInstance.GetPackageWithHttpInfo(scope, code, asAt, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PackagesApi.GetPackageWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **scope** | **string** | The scope to which the package belongs. |  |
| **code** | **string** | The package&#39;s unique identifier. |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the package. Defaults to return the latest version of the package if not specified. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Package\&quot; domain to decorate onto the package.              These take the format {domain}/{scope}/{code} e.g. \&quot;Package/system/Name\&quot;. | [optional]  |

### Return type

[**Package**](Package.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The package matching the given identifier. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listpackages"></a>
# **ListPackages**
> PagedResourceListOfPackage ListPackages (DateTimeOffset? asAt = null, string? page = null, List<string>? sortBy = null, int? limit = null, string? filter = null, List<string>? propertyKeys = null)

[EXPERIMENTAL] ListPackages: List Packages

Fetch the last pre-AsAt date version of each package in scope (does not fetch the entire history).

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListPackagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PackagesApi(config);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the package. Defaults to return the latest version of the package if not specified. (optional) 
            var page = "page_example";  // string? | The pagination token to use to continue listing packages from a previous call to list packages.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. (optional) 
            var sortBy = new List<string>?(); // List<string>? | A list of field names or properties to sort by, each suffixed by \" ASC\" or \" DESC\" (optional) 
            var limit = 56;  // int? | When paginating, limit the number of returned results to this many. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var propertyKeys = new List<string>?(); // List<string>? | A list of property keys from the \"Package\" domain to decorate onto each package.                  These take the format {domain}/{scope}/{code} e.g. \"Package/system/Name\". (optional) 

            try
            {
                // [EXPERIMENTAL] ListPackages: List Packages
                PagedResourceListOfPackage result = apiInstance.ListPackages(asAt, page, sortBy, limit, filter, propertyKeys);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PackagesApi.ListPackages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListPackagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListPackages: List Packages
    ApiResponse<PagedResourceListOfPackage> response = apiInstance.ListPackagesWithHttpInfo(asAt, page, sortBy, limit, filter, propertyKeys);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PackagesApi.ListPackagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the package. Defaults to return the latest version of the package if not specified. | [optional]  |
| **page** | **string?** | The pagination token to use to continue listing packages from a previous call to list packages.              This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields              must not have changed since the original request. | [optional]  |
| **sortBy** | [**List&lt;string&gt;?**](string.md) | A list of field names or properties to sort by, each suffixed by \&quot; ASC\&quot; or \&quot; DESC\&quot; | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here:              https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **propertyKeys** | [**List&lt;string&gt;?**](string.md) | A list of property keys from the \&quot;Package\&quot; domain to decorate onto each package.                  These take the format {domain}/{scope}/{code} e.g. \&quot;Package/system/Name\&quot;. | [optional]  |

### Return type

[**PagedResourceListOfPackage**](PagedResourceListOfPackage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Packages in scope. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="upsertpackages"></a>
# **UpsertPackages**
> ResourceListOfPackage UpsertPackages (PackageSetRequest? packageSetRequest = null)

[EXPERIMENTAL] UpsertPackages: Upsert Package

Upsert; update existing packages with given ids, or create new packages otherwise.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class UpsertPackagesExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/api";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new PackagesApi(config);
            var packageSetRequest = new PackageSetRequest?(); // PackageSetRequest? | The collection of package requests. (optional) 

            try
            {
                // [EXPERIMENTAL] UpsertPackages: Upsert Package
                ResourceListOfPackage result = apiInstance.UpsertPackages(packageSetRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PackagesApi.UpsertPackages: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpsertPackagesWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpsertPackages: Upsert Package
    ApiResponse<ResourceListOfPackage> response = apiInstance.UpsertPackagesWithHttpInfo(packageSetRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling PackagesApi.UpsertPackagesWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **packageSetRequest** | [**PackageSetRequest?**](PackageSetRequest?.md) | The collection of package requests. | [optional]  |

### Return type

[**ResourceListOfPackage**](ResourceListOfPackage.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | A collection of packages. |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

