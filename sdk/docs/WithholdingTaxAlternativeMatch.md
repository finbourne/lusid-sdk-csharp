# Lusid.Sdk.Model.WithholdingTaxAlternativeMatch

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IfValues** | **Dictionary&lt;string, string&gt;** | The values of the unresolved dimensions that choose this row, one or more. | 
**MatchedRuleId** | **string** | The identifier booking would stamp for the row that these values choose. | 
**StopAtSourceRate** | **decimal** | The rate that this row would withhold at source. | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> ifValues = new Dictionary<string, string>();
string matchedRuleId = "matchedRuleId";decimal stopAtSourceRate = "stopAtSourceRate";


WithholdingTaxAlternativeMatch withholdingTaxAlternativeMatchInstance = new WithholdingTaxAlternativeMatch(
    ifValues: ifValues,
    matchedRuleId: matchedRuleId,
    stopAtSourceRate: stopAtSourceRate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
