# Lusid.Sdk.Model.TaxCostRecordRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioScope** | **string** | The scope of the portfolio the holding belongs to. | 
**PortfolioCode** | **string** | The code of the portfolio the holding belongs to. | 
**InstrumentIdentifier** | **string** | The LUSID instrument identifier (LUID) of the holding the tax cost applies to. | 
**NavTypeCode** | **string** | The code of the NAV type the tax cost applies to. Optional; omit for the fund&#39;s primary NAV type. | [optional] 
**TaxCost** | **decimal** | The tax cost of the holding at the effective period end, in the fund&#39;s base currency. | 
**CarriedForwardAmount** | **decimal** | The amount carried forward into the next tax period, in the fund&#39;s base currency. | 
**EffectivePeriodEnd** | **DateTimeOffset** | The end date of the tax period the record applies to. | 
**SourceValuationPointId** | **string** | The identifier of the valuation point the record was derived from. Optional; omit for externally supplied records. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string portfolioScope = "portfolioScope";
string portfolioCode = "portfolioCode";
string instrumentIdentifier = "instrumentIdentifier";
string navTypeCode = "example navTypeCode";decimal taxCost = "taxCost";
decimal carriedForwardAmount = "carriedForwardAmount";

string sourceValuationPointId = "example sourceValuationPointId";

TaxCostRecordRequest taxCostRecordRequestInstance = new TaxCostRecordRequest(
    portfolioScope: portfolioScope,
    portfolioCode: portfolioCode,
    instrumentIdentifier: instrumentIdentifier,
    navTypeCode: navTypeCode,
    taxCost: taxCost,
    carriedForwardAmount: carriedForwardAmount,
    effectivePeriodEnd: effectivePeriodEnd,
    sourceValuationPointId: sourceValuationPointId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
