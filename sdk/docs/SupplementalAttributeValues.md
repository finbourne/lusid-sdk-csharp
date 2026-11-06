# Lusid.Sdk.Model.SupplementalAttributeValues
A supplemental attribute value carried on a rec result for context. Does not contribute to matching.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttributeName** | **string** | The name of the supplemental attribute. | 
**LeftValue** | **string** | The left-side value: the value the left items agree on, or \&quot;[multiple values]\&quot; where they do not. Null where the left side has no items. | [optional] 
**RightValue** | **string** | The right-side value: the value the right items agree on, or \&quot;[multiple values]\&quot; where they do not. Null where the right side has no items. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string attributeName = "attributeName";
string leftValue = "example leftValue";
string rightValue = "example rightValue";

SupplementalAttributeValues supplementalAttributeValuesInstance = new SupplementalAttributeValues(
    attributeName: attributeName,
    leftValue: leftValue,
    rightValue: rightValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
