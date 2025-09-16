# Lusid.Sdk.Model.VersionSummaryDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApiVersion** | **string** |  | [optional] 
**BuildVersion** | **string** |  | [optional] 
**ExcelVersion** | **string** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string apiVersion = "example apiVersion";
string buildVersion = "example buildVersion";
string excelVersion = "example excelVersion";
List<Link> links = new List<Link>();

VersionSummaryDto versionSummaryDtoInstance = new VersionSummaryDto(
    apiVersion: apiVersion,
    buildVersion: buildVersion,
    excelVersion: excelVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
