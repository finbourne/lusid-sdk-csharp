# Lusid.Sdk.Api.ApplicationMetadataApi

All URIs are relative to *http://http:/api*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetExcelAddin**](ApplicationMetadataApi.md#getexceladdin) | **GET** /api/metadata/downloads/exceladdin | [EARLY ACCESS] Download Excel Addin
[**GetLusidVersions**](ApplicationMetadataApi.md#getlusidversions) | **GET** /api/metadata/versions | [EARLY ACCESS] Get LUSID versions
[**ListAccessControlledResources**](ApplicationMetadataApi.md#listaccesscontrolledresources) | **GET** /api/metadata/access/resources | [EARLY ACCESS] Get resources available for access control



## GetExcelAddin

> FileResponse GetExcelAddin (string version = null)

[EARLY ACCESS] Download Excel Addin

Download the LUSID Excel Addin for Microsoft Excel. Not providing a specific value will return the latest version being returned

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetExcelAddinExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationMetadataApi();
            var version = version_example;  // string | The requested version of the Excel plugin (optional) 

            try
            {
                // [EARLY ACCESS] Download Excel Addin
                FileResponse result = apiInstance.GetExcelAddin(version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationMetadataApi.GetExcelAddin: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **version** | **string**| The requested version of the Excel plugin | [optional] 

### Return type

[**FileResponse**](FileResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## GetLusidVersions

> VersionSummaryDto GetLusidVersions ()

[EARLY ACCESS] Get LUSID versions

Get the semantic versions associated with LUSID and its ecosystem

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetLusidVersionsExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationMetadataApi();

            try
            {
                // [EARLY ACCESS] Get LUSID versions
                VersionSummaryDto result = apiInstance.GetLusidVersions();
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationMetadataApi.GetLusidVersions: " + e.Message );
            }
        }
    }
}
```

### Parameters

This endpoint does not need any parameter.

### Return type

[**VersionSummaryDto**](VersionSummaryDto.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)


## ListAccessControlledResources

> ResourceListOfAccessControlledResource ListAccessControlledResources (string filter = null)

[EARLY ACCESS] Get resources available for access control

Get the comprehensive set of resources that are available for access control

### Example

```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class ListAccessControlledResourcesExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationMetadataApi();
            var filter = filter_example;  // string | Optional. Expression to filter the result set (optional) 

            try
            {
                // [EARLY ACCESS] Get resources available for access control
                ResourceListOfAccessControlledResource result = apiInstance.ListAccessControlledResources(filter);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationMetadataApi.ListAccessControlledResources: " + e.Message );
            }
        }
    }
}
```

### Parameters


Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **filter** | **string**| Optional. Expression to filter the result set | [optional] 

### Return type

[**ResourceListOfAccessControlledResource**](ResourceListOfAccessControlledResource.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

- **Content-Type**: Not defined
- **Accept**: text/plain, application/json, text/json

[[Back to top]](#)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to Model list]](../README.md#documentation-for-models)
[[Back to README]](../README.md)

