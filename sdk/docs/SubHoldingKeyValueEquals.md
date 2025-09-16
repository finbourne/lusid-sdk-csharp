# Lusid.Sdk.Model.SubHoldingKeyValueEquals
A criterion that checks whether a SubHoldingKey Value is equal to the given string value

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CriterionType** | **string** | The available values are: PropertyValueEquals, PropertyValueIn, SubHoldingKeyValueEquals | 
**SubHoldingKey** | **string** | The sub holding key whose value will form the left-hand side of the operation | 
**Value** | **string** | The value to be compared against | 

```csharp
using Lusid.Sdk.Model;
using System;

string subHoldingKey = "subHoldingKey";
string value = "value";

SubHoldingKeyValueEquals subHoldingKeyValueEqualsInstance = new SubHoldingKeyValueEquals(
    subHoldingKey: subHoldingKey,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
