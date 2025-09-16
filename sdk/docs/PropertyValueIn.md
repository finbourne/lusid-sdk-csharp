# Lusid.Sdk.Model.PropertyValueIn
A criterion that checks whether a Property Value is equal to one of the given string values

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CriterionType** | **string** | The available values are: PropertyValueEquals, PropertyValueIn, SubHoldingKeyValueEquals | 
**PropertyKey** | **string** | The property key whose value will form the left-hand side of the operation | 
**Value** | **List&lt;string&gt;** | The value to be compared against | 

```csharp
using Lusid.Sdk.Model;
using System;

string propertyKey = "propertyKey";
List<string> value = new List<string>();

PropertyValueIn propertyValueInInstance = new PropertyValueIn(
    propertyKey: propertyKey,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
