# Lusid.Sdk.Model.UpdateTaxRuleSetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** |  | 
**Description** | **string** |  | 
**Rules** | [**List&lt;TaxRule&gt;**](TaxRule.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "description";
List<TaxRule> rules = new List<TaxRule>();

UpdateTaxRuleSetRequest updateTaxRuleSetRequestInstance = new UpdateTaxRuleSetRequest(
    displayName: displayName,
    description: description,
    rules: rules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
