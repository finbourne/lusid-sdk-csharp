# Lusid.Sdk.Model.RecDefRuleset

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecType** | **string** | The type of reconciliation this entry configures. Must be valid for the definitionType, and must match the reconciliationType of the referenced matching ruleset. Available values: Holding, CashHolding, Valuation, InputTransaction, OutputTransaction, SettlementActivity. | 
**MatchingRulesetId** | [**ResourceId**](ResourceId.md) |  | 
**RelationalDataFilter** | **string** | Selects the slice of the relational dataset this definition draws from, e.g. \&quot;custodian eq &#39;NT&#39;\&quot;. Only permitted when the referenced ruleset declares a relational side, and combined with AND at run time with that ruleset&#39;s own filter for the side. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string recType = "recType";
ResourceId matchingRulesetId = new ResourceId();
string relationalDataFilter = "example relationalDataFilter";

RecDefRuleset recDefRulesetInstance = new RecDefRuleset(
    recType: recType,
    matchingRulesetId: matchingRulesetId,
    relationalDataFilter: relationalDataFilter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
