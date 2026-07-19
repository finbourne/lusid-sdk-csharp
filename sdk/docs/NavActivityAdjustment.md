# Lusid.Sdk.Model.NavActivityAdjustment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NavActivityAdjustmentType** | **string** | The type of the entity being applied, for example a PortfolioTransaction. Available values: PortfolioTransaction, PortfolioSettlementInstruction, InstrumentActivity, QuoteActivity, ComplexMarketDataActivity. | 

```csharp
using Lusid.Sdk.Model;
using System;

string navActivityAdjustmentType = "navActivityAdjustmentType";

NavActivityAdjustment navActivityAdjustmentInstance = new NavActivityAdjustment(
    navActivityAdjustmentType: navActivityAdjustmentType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
