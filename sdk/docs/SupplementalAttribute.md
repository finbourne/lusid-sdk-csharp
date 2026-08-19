# Lusid.Sdk.Model.SupplementalAttribute

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttributeName** | **string** | The reference name of the supplemental attribute. | 
**LeftFormula** | **string** | Derivation formula evaluated against the left side of the reconciliation. | 
**RightFormula** | **string** | Derivation formula evaluated against the right side of the reconciliation. | 

```csharp
using Lusid.Sdk.Model;
using System;

string attributeName = "attributeName";
string leftFormula = "leftFormula";
string rightFormula = "rightFormula";

SupplementalAttribute supplementalAttributeInstance = new SupplementalAttribute(
    attributeName: attributeName,
    leftFormula: leftFormula,
    rightFormula: rightFormula);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
