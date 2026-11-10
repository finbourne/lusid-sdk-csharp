# Lusid.Sdk.Model.InstrumentEventActivity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NavActivityAdjustmentType** | **string** | The type of the entity being applied, for example a PortfolioTransaction. Available values: PortfolioTransaction, PortfolioSettlementInstruction, InstrumentActivity, QuoteActivity, ComplexMarketDataActivity, InstrumentEventActivity. | 
**AsAt** | **DateTimeOffset** | The asAt time for which the adjustment is being applied. | 
**CorporateActionSourceScope** | **string** | The scope of the corporate action source that the instrument event belongs to. | 
**CorporateActionSourceCode** | **string** | The code of the corporate action source that the instrument event belongs to. | 
**InstrumentEventId** | **string** | The Id of the instrument event being adjusted. | 

```csharp
using Lusid.Sdk.Model;
using System;

string corporateActionSourceScope = "corporateActionSourceScope";
string corporateActionSourceCode = "corporateActionSourceCode";
string instrumentEventId = "instrumentEventId";

InstrumentEventActivity instrumentEventActivityInstance = new InstrumentEventActivity(
    asAt: asAt,
    corporateActionSourceScope: corporateActionSourceScope,
    corporateActionSourceCode: corporateActionSourceCode,
    instrumentEventId: instrumentEventId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
