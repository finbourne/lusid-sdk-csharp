# Lusid.Sdk.Api.ApplicationMetadataApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetExcelAddin**](ApplicationMetadataApi.md#getexceladdin) | **GET** /api/metadata/downloads/exceladdin | Download Excel Addin
[**GetExcelDownloadUrl**](ApplicationMetadataApi.md#getexceldownloadurl) | **GET** /api/metadata/downloads/excel | Get Excel download url
[**GetLusidVersions**](ApplicationMetadataApi.md#getlusidversions) | **GET** /api/metadata/versions | Get LUSID versions


<a name="getexceladdin"></a>
# **GetExcelAddin**
> FileResponse GetExcelAddin (string version = null)

Download Excel Addin

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
                // Download Excel Addin
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getexceldownloadurl"></a>
# **GetExcelDownloadUrl**
> string GetExcelDownloadUrl (string version = null)

Get Excel download url

Request an authorised url for an Excel client version

### Example
```csharp
using System;
using System.Diagnostics;
using Lusid.Sdk.Api;
using Lusid.Sdk.Client;
using Lusid.Sdk.Model;

namespace Example
{
    public class GetExcelDownloadUrlExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new ApplicationMetadataApi();
            var version = version_example;  // string | The requested version of the Excel plugin (optional) 

            try
            {
                // Get Excel download url
                string result = apiInstance.GetExcelDownloadUrl(version);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling ApplicationMetadataApi.GetExcelDownloadUrl: " + e.Message );
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

**string**

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getlusidversions"></a>
# **GetLusidVersions**
> VersionSummaryDto GetLusidVersions ()

Get LUSID versions

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
                // Get LUSID versions
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

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

