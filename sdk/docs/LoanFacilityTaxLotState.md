# Lusid.Sdk.Model.LoanFacilityTaxLotState
Facility-level state for a single tax lot. These values live on the facility holding rather than on any  contract holding, and are keyed on the tax lot alone - a lot holding balances on several contracts still  has one cost and one facility accrual.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaxLotId** | **string** | The tax lot being set, identified by the transaction id of the trade that opened it. | 
**Cost** | **decimal?** | The cost of this tax lot in the instrument&#39;s domestic currency, which for a loan facility is the  facility currency. Maps to Holding/Cost/Dom.                Stated rather than derived because loan facility cost is not units multiplied by price - it is the  funded balance at price plus the unfunded balance at price less par. A migrated lot whose real cost  came from several historical trades at different prices cannot be expressed by choosing one price on  the trade that opens it. Omit it to keep whatever cost that trade established. | [optional] 
**CostInPortfolioCcy** | **decimal?** | The cost of this tax lot in the portfolio currency. Maps to Holding/Cost/Pfolio, and is what makes  unrealised PnL exact across a currency boundary. Equals Cost multiplied by PortfolioFxRate. | [optional] 
**PortfolioFxRate** | **decimal?** | The FX rate from the facility currency to the portfolio currency at the time of the original trade.  One when the two currencies are the same. | [optional] 
**FacilityAccruedInterest** | **decimal?** | Accrued interest on the unfunded portion of the facility for this tax lot - the commitment fee. The  facility&#39;s own accrual, distinct from the accruals held against each contract, and already in the  facility currency. The two are summed to give the accrued interest reported against the holding.                Omit it and the lot&#39;s accrual is left as it is, so a migrated lot accrues from its own trade date. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string taxLotId = "taxLotId";

LoanFacilityTaxLotState loanFacilityTaxLotStateInstance = new LoanFacilityTaxLotState(
    taxLotId: taxLotId,
    cost: cost,
    costInPortfolioCcy: costInPortfolioCcy,
    portfolioFxRate: portfolioFxRate,
    facilityAccruedInterest: facilityAccruedInterest);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
