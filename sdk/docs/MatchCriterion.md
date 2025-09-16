# Lusid.Sdk.Model.MatchCriterion
A condition to be evaluated.  Each supported CriterionType has a corresponding schema.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CriterionType** | **string** | The available values are: PropertyValueEquals, PropertyValueIn, SubHoldingKeyValueEquals | 

```csharp
using Lusid.Sdk.Model;
using System;

string criterionType = "criterionType";

MatchCriterion matchCriterionInstance = new MatchCriterion(
    criterionType: criterionType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
