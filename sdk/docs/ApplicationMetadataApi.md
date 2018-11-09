# LusidSdk.Api.ApplicationMetadataApi

All URIs are relative to *https://localhost*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetExcelDownloadUrl**](ApplicationMetadataApi.md#getexceldownloadurl) | **GET** /api/metadata/downloads/excel | Get Excel download url
[**GetLusidVersions**](ApplicationMetadataApi.md#getlusidversions) | **GET** /api/metadata/versions | Get LUSID versions


<a name="getexceldownloadurl"></a>
# **GetExcelDownloadUrl**
> string GetExcelDownloadUrl (string version = null)

Get Excel download url

Request an authorised url for an Excel client version

### Example
```csharp
using System;
using System.Diagnostics;
using LusidSdk.Api;
using LusidSdk.Client;
using LusidSdk.Model;

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
> VersionSummary GetLusidVersions ()

Get LUSID versions

Get the semantic versions associated with LUSID and its ecosystem

### Example
```csharp
using System;
using System.Diagnostics;
using LusidSdk.Api;
using LusidSdk.Client;
using LusidSdk.Model;

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
                VersionSummary result = apiInstance.GetLusidVersions();
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

[**VersionSummary**](VersionSummary.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

