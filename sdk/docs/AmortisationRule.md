# Lusid.Sdk.Model.AmortisationRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the rule. | 
**Description** | **string** | A description of the rule. | [optional] 
**Filter** | **string** | The filter for this rule. | 
**AmortisationMethod** | **string** | The filter for this rule. | 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "name";
string description = "example description";
string filter = "filter";
string amortisationMethod = "amortisationMethod";

AmortisationRule amortisationRuleInstance = new AmortisationRule(
    name: name,
    description: description,
    filter: filter,
    amortisationMethod: amortisationMethod);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
