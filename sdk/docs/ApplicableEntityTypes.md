# Lusid.Sdk.Model.ApplicableEntityTypes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApplicableEntityTypesToAdd** | **List&lt;string&gt;** | The types of entities this relational dataset definition can be applied to (e.g. Instrument, Portfolio, etc.). | [optional] 
**ApplicableEntityTypesToRemove** | **List&lt;string&gt;** | The types of entities this relational dataset definition can be applied to (e.g. Instrument, Portfolio, etc.). | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> applicableEntityTypesToAdd = new List<string>();
List<string> applicableEntityTypesToRemove = new List<string>();

ApplicableEntityTypes applicableEntityTypesInstance = new ApplicableEntityTypes(
    applicableEntityTypesToAdd: applicableEntityTypesToAdd,
    applicableEntityTypesToRemove: applicableEntityTypesToRemove);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
