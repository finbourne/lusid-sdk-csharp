# Lusid.Sdk.Model.StagedModificationsRequestedChangeInterval

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttributeName** | **string** | Name of the property the change applies to. | [optional] 
**EffectiveRange** | [**StagedModificationEffectiveRange**](StagedModificationEffectiveRange.md) |  | [optional] 
**PreviousValue** | [**PropertyValue**](PropertyValue.md) |  | [optional] 
**NewValue** | [**PropertyValue**](PropertyValue.md) |  | [optional] 
**AsAtBasis** | **string** | Whether the change represents the modification when the request was made or the modification as it would be at the latest time. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string attributeName = "example attributeName";
StagedModificationEffectiveRange? effectiveRange = new StagedModificationEffectiveRange();

PropertyValue? previousValue = new PropertyValue();

PropertyValue? newValue = new PropertyValue();

string asAtBasis = "example asAtBasis";
List<Link> links = new List<Link>();

StagedModificationsRequestedChangeInterval stagedModificationsRequestedChangeIntervalInstance = new StagedModificationsRequestedChangeInterval(
    attributeName: attributeName,
    effectiveRange: effectiveRange,
    previousValue: previousValue,
    newValue: newValue,
    asAtBasis: asAtBasis,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
