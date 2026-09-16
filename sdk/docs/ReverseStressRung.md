# Lusid.Sdk.Model.ReverseStressRung
One evaluated factor and what the portfolio was worth under it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scale** | **decimal** | The factor the scenario&#39;s shifts were multiplied by. | [optional] 
**Value** | **decimal** | The value of the measure under the scaled scenario. | [optional] 
**Pnl** | **decimal** | The change from the unstressed value. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? scale = "example scale";decimal? value = "example value";decimal? pnl = "example pnl";

ReverseStressRung reverseStressRungInstance = new ReverseStressRung(
    scale: scale,
    value: value,
    pnl: pnl);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
