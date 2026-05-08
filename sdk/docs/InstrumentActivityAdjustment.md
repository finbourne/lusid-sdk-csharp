# Lusid.Sdk.Model.InstrumentActivityAdjustment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NavActivityAdjustmentType** | **string** | The type of the entity being applied, for example a PortfolioTransaction. Available values: PortfolioTransactionAdjustment, PortfolioSettlementInstructionAdjustment, InstrumentActivityAdjustment, QuoteActivityAdjustment. | 
**NavActivityAdjustmentSource** | **string** | The post closed activity source of the given entity, for example Manual. Available values: Undefined, Manual, Auto. | 
**AsAt** | **DateTimeOffset** | The asAt time for which the adjustment is being applied. | 
**Scope** | **string** | The Scope of the given entity | 
**LusidInstrumentId** | **string** | The LusidInstrumentId of the given entity | 

```csharp
using Lusid.Sdk.Model;
using System;

string navActivityAdjustmentSource = "navActivityAdjustmentSource";
string scope = "scope";
string lusidInstrumentId = "lusidInstrumentId";

InstrumentActivityAdjustment instrumentActivityAdjustmentInstance = new InstrumentActivityAdjustment(
    navActivityAdjustmentSource: navActivityAdjustmentSource,
    asAt: asAt,
    scope: scope,
    lusidInstrumentId: lusidInstrumentId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
