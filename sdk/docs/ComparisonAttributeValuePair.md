# Lusid.Sdk.Model.ComparisonAttributeValuePair

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttributeName** | **string** | Comparison rule attribute name. | 
**Value** | **string** | Computed value for the comparison rule attribute. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string attributeName = "attributeName";
string value = "example value";

ComparisonAttributeValuePair comparisonAttributeValuePairInstance = new ComparisonAttributeValuePair(
    attributeName: attributeName,
    value: value);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
