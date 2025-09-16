# Lusid.Sdk.Model.ChangeInterval
Defines a change that occured for an entity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAtModified** | **DateTimeOffset** | The date/time of the change. | [optional] 
**UserIdModified** | **string** | The unique identifier of the user that made the change. | [optional] 
**RequestIdModified** | **string** | The unique identifier of the request that the changes were part of. | [optional] 
**ReasonModified** | **string** | The reason for an entity modification. | [optional] 
**AsAtVersionNumber** | **int** | The version number for the entity (the entity was created at version 1). This may refer to the version number of a changed related entity, not a change for the entity itself. | [optional] 
**StagedModificationIdModified** | **string** | The id of the staged modification that was approved. Will be null if the change didn&#39;t come from a staged modification. | [optional] 
**Action** | **string** | The action performed on the field. | [optional] 
**AttributeName** | **string** | The name of the field or property that has been changed. | [optional] 
**PreviousValue** | [**PropertyValue**](PropertyValue.md) |  | [optional] 
**NewValue** | [**PropertyValue**](PropertyValue.md) |  | [optional] 
**EffectiveRange** | [**EffectiveRange**](EffectiveRange.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string userIdModified = "example userIdModified";
string requestIdModified = "example requestIdModified";
string reasonModified = "example reasonModified";
string stagedModificationIdModified = "example stagedModificationIdModified";
string action = "example action";
string attributeName = "example attributeName";
PropertyValue? previousValue = new PropertyValue();

PropertyValue? newValue = new PropertyValue();

EffectiveRange? effectiveRange = new EffectiveRange();


ChangeInterval changeIntervalInstance = new ChangeInterval(
    asAtModified: asAtModified,
    userIdModified: userIdModified,
    requestIdModified: requestIdModified,
    reasonModified: reasonModified,
    asAtVersionNumber: asAtVersionNumber,
    stagedModificationIdModified: stagedModificationIdModified,
    action: action,
    attributeName: attributeName,
    previousValue: previousValue,
    newValue: newValue,
    effectiveRange: effectiveRange);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
