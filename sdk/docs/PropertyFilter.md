# Lusid.Sdk.Model.PropertyFilter

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | **string** | The key that uniquely identifies a queryable address in Lusid. | [optional] 
**Operator** | **string** | The available values are: Equals, NotEquals, GreaterThan, GreaterThanOrEqualTo, LessThan, LessThanOrEqualTo, In | [optional] 
**Right** | **Object** |  | [optional] 
**RightOperandType** | **string** | The available values are: Absolute, Property | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string left = "example left";
string operator = "example operator";
string rightOperandType = "example rightOperandType";

PropertyFilter propertyFilterInstance = new PropertyFilter(
    left: left,
    operator: operator,
    right: right,
    rightOperandType: rightOperandType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
