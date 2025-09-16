# Lusid.Sdk.Model.StagedModificationsEntityHrefs

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WhenStaged** | **string** | The specific Uniform Resource Identifier (URI) for the staged modification change at the time when the change was requested. | [optional] 
**Preview** | **string** | The specific Uniform Resource Identifier (URI) for the preview of staged modification change once applied. | [optional] 
**Latest** | **string** | The specific Uniform Resource Identifier (URI) for the staged modification at latest time. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string whenStaged = "example whenStaged";
string preview = "example preview";
string latest = "example latest";
List<Link> links = new List<Link>();

StagedModificationsEntityHrefs stagedModificationsEntityHrefsInstance = new StagedModificationsEntityHrefs(
    whenStaged: whenStaged,
    preview: preview,
    latest: latest,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
