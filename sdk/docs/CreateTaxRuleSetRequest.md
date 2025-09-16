# Lusid.Sdk.Model.CreateTaxRuleSetRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** |  | 
**Description** | **string** |  | 
**OutputPropertyKey** | **string** |  | 
**Rules** | [**List&lt;TaxRule&gt;**](TaxRule.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "description";
string outputPropertyKey = "outputPropertyKey";
List<TaxRule> rules = new List<TaxRule>();

CreateTaxRuleSetRequest createTaxRuleSetRequestInstance = new CreateTaxRuleSetRequest(
    id: id,
    displayName: displayName,
    description: description,
    outputPropertyKey: outputPropertyKey,
    rules: rules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
