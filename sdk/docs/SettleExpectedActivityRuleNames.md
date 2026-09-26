# Lusid.Sdk.Model.SettleExpectedActivityRuleNames
Names the matching rules that carry the settlement semantics a SettleExpectedActivity writeback depends  upon. Each named rule's target-side formula must be the unmodified settlement activity field; the origin  side is unconstrained.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ActivityType** | **string** | The core rule whose target-side formula is the unmodified &#39;activityType&#39;. Settlement instructions are suggested where the origin-side value is Settled and the target-side value is Expected. | 
**ActivityDate** | **string** | The core rule whose target-side formula is the unmodified &#39;activityDate&#39;. The origin side supplies the actual settlement date. | 
**Units** | **string** | The aggregate rule whose target-side formula is the unmodified &#39;units&#39;. The origin side supplies the units, and the tolerance on this rule classifies the units difference. | 

```csharp
using Lusid.Sdk.Model;
using System;

string activityType = "activityType";
string activityDate = "activityDate";
string units = "units";

SettleExpectedActivityRuleNames settleExpectedActivityRuleNamesInstance = new SettleExpectedActivityRuleNames(
    activityType: activityType,
    activityDate: activityDate,
    units: units);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
