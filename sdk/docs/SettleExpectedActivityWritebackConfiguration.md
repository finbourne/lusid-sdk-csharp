# Lusid.Sdk.Model.SettleExpectedActivityWritebackConfiguration
Suggests settlement instructions where settlement on the origin side confirms expected settlement activity  on the target side. Only valid on a ruleset whose recType is SettlementActivity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MandatoryRuleNames** | [**SettleExpectedActivityRuleNames**](SettleExpectedActivityRuleNames.md) |  | 
**ResultPatterns** | [**List&lt;WritebackResultPattern&gt;**](WritebackResultPattern.md) | The combinations of units difference and result cardinality for which writeback is suggested. A combination that is not present never produces a suggestion. Each combination may appear once, and the collection is returned in a canonical order regardless of the order supplied. | 
**WritebackType** | **string** | Polymorphic discriminator, naming the change the writeback makes to LUSID. Supported types: SettleExpectedActivity, which is only valid when recType is SettlementActivity. Available values: SettleExpectedActivity. | 
**TargetSide** | **string** | The side the writeback changes, the other being the source of truth. One of: Left, Right. As the writeback changes LUSID, this side must draw on a native LUSID dataset rather than relational data. Available values: Left, Right. | 

```csharp
using Lusid.Sdk.Model;
using System;

SettleExpectedActivityRuleNames mandatoryRuleNames = new SettleExpectedActivityRuleNames();
List<WritebackResultPattern> resultPatterns = new List<WritebackResultPattern>();
string writebackType = "writebackType";
string targetSide = "targetSide";

SettleExpectedActivityWritebackConfiguration settleExpectedActivityWritebackConfigurationInstance = new SettleExpectedActivityWritebackConfiguration(
    mandatoryRuleNames: mandatoryRuleNames,
    resultPatterns: resultPatterns,
    writebackType: writebackType,
    targetSide: targetSide);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
