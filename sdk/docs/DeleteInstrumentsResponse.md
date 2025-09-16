# Lusid.Sdk.Model.DeleteInstrumentsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**AsAt** | **DateTimeOffset** | The as-at datetime at which the instrument was deleted. | 
**Staged** | [**Dictionary&lt;string, StagedModificationsInfo&gt;**](StagedModificationsInfo.md) | Information about the pending staged modifications for the current entity. | [optional] [readonly] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
Dictionary<string, StagedModificationsInfo> staged = new Dictionary<string, StagedModificationsInfo>();
List<Link> links = new List<Link>();

DeleteInstrumentsResponse deleteInstrumentsResponseInstance = new DeleteInstrumentsResponse(
    href: href,
    asAt: asAt,
    staged: staged,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
