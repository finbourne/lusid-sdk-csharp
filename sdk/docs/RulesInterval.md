# Lusid.Sdk.Model.RulesInterval

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveRange** | [**DateRange**](DateRange.md) |  | 
**Rules** | [**List&lt;AmortisationRule&gt;**](AmortisationRule.md) | The rules of this rule set. | 

```csharp
using Lusid.Sdk.Model;
using System;

DateRange effectiveRange = new DateRange();
List<AmortisationRule> rules = new List<AmortisationRule>();

RulesInterval rulesIntervalInstance = new RulesInterval(
    effectiveRange: effectiveRange,
    rules: rules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
