# Lusid.Sdk.Model.InstrumentActivity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NavActivityAdjustmentType** | **string** | . The available values are: PortfolioTransaction, PortfolioSettlementInstruction, InstrumentActivity, QuoteActivity | 
**AsAt** | **DateTimeOffset** | The asAt time for which the adjustment is being applied. | 
**Scope** | **string** | The Scope of the given entity | 
**LusidInstrumentId** | **string** | The LusidInstrumentId of the given entity | 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string lusidInstrumentId = "lusidInstrumentId";

InstrumentActivity instrumentActivityInstance = new InstrumentActivity(
    asAt: asAt,
    scope: scope,
    lusidInstrumentId: lusidInstrumentId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
