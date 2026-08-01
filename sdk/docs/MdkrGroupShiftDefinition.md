# Lusid.Sdk.Model.MdkrGroupShiftDefinition
A group of keyed market data key rules (e.g. bid/mid/ask). When the scenario is used in a  valuation, each key's rule re-resolves the matching market data dependencies independently and  produces its own result column named scenario:key, alongside the base column - which continues to  resolve through the recipe's own rules in the standard waterfall, whether or not the same rules  appear here.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScenarioShiftType** | **string** | Available values: RateCurveShiftDefinition, FxShiftDefinition, EquityShiftDefinition, VolSurfaceShiftDefinition, MdkrGroupShiftDefinition. | 
**Rules** | [**List&lt;KeyedMarketDataKeyRule&gt;**](KeyedMarketDataKeyRule.md) | The keyed rules of the group. Keys must be unique within the group; each key produces one  result column. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<KeyedMarketDataKeyRule> rules = new List<KeyedMarketDataKeyRule>();

MdkrGroupShiftDefinition mdkrGroupShiftDefinitionInstance = new MdkrGroupShiftDefinition(
    rules: rules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
