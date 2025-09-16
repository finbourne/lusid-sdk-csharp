# Lusid.Sdk.Model.TaxRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | A user-friendly name | 
**Description** | **string** | A description for this rule | 
**Rate** | **decimal** | The rate to be applied if all criteria are met | 
**MatchCriteria** | [**List&lt;MatchCriterion&gt;**](MatchCriterion.md) | A set of criteria to be met for this rule to be applied | 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "name";
string description = "description";decimal rate = "rate";

List<MatchCriterion> matchCriteria = new List<MatchCriterion>();

TaxRule taxRuleInstance = new TaxRule(
    name: name,
    description: description,
    rate: rate,
    matchCriteria: matchCriteria);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
