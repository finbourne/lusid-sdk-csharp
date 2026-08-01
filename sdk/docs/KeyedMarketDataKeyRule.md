# Lusid.Sdk.Model.KeyedMarketDataKeyRule
One keyed rule of an MdkrGroup shift: the key names the result column (scenario:key) and the rule  is a standard market data key rule resolved for that column.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key naming this rule&#39;s result column, e.g. \&quot;bid\&quot;. | 
**Rule** | [**MarketDataKeyRule**](MarketDataKeyRule.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
MarketDataKeyRule rule = new MarketDataKeyRule();

KeyedMarketDataKeyRule keyedMarketDataKeyRuleInstance = new KeyedMarketDataKeyRule(
    key: key,
    rule: rule);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
