# Lusid.Sdk.Model.Change
The time an entity was modified (amendment and/or historical correction).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**EntityId** | [**ResourceId**](ResourceId.md) |  | 
**Corrected** | **bool** |  | 
**CorrectionEffectiveAt** | **DateTimeOffset?** |  | [optional] 
**CorrectionAsAt** | **DateTimeOffset?** |  | [optional] 
**Amended** | **bool** |  | 
**AmendmentEffectiveAt** | **DateTimeOffset?** |  | [optional] 
**AmendmentAsAt** | **DateTimeOffset?** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId entityId = new ResourceId();
bool corrected = //"True";
bool amended = //"True";
List<Link> links = new List<Link>();

Change changeInstance = new Change(
    href: href,
    entityId: entityId,
    corrected: corrected,
    correctionEffectiveAt: correctionEffectiveAt,
    correctionAsAt: correctionAsAt,
    amended: amended,
    amendmentEffectiveAt: amendmentEffectiveAt,
    amendmentAsAt: amendmentAsAt,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
