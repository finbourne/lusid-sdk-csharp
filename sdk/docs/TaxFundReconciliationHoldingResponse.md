# Lusid.Sdk.Model.TaxFundReconciliationHoldingResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Period** | [**TaxAccountingPeriod**](TaxAccountingPeriod.md) |  | [optional] 
**HoldingId** | **string** | The identifier of the holding. For a company this is the pooled LUSID instrument identifier, for a fund the portfolio code and instrument identifier. | [optional] 
**InstrumentId** | **string** | The LUSID unique identifier of the instrument. | [optional] 
**InstrumentName** | **string** | The name of the instrument. | [optional] 
**CompanyAmount** | **decimal** | The company-level amount for the holding. | [optional] 
**FundProxies** | [**List&lt;TaxFundReconciliationProxyRow&gt;**](TaxFundReconciliationProxyRow.md) | The member funds&#39; notional figures for the holding. | [optional] 
**Difference** | **decimal** | The difference between the two sides. | [optional] 
**Category** | **string** | The reconciliation category of the difference, when there is one. Available values: ExcludedHoldings, TaxCostAdjustments, OutOfSync, Scope, PoolAveraging, Matching, Indexation, KinkTest. | [optional] 
**Explanation** | **string** | The explanation of the difference. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? fundId = new ResourceId();

TaxAccountingPeriod? period = new TaxAccountingPeriod();

string holdingId = "example holdingId";
string instrumentId = "example instrumentId";
string instrumentName = "example instrumentName";decimal? companyAmount = "example companyAmount";
List<TaxFundReconciliationProxyRow> fundProxies = new List<TaxFundReconciliationProxyRow>();decimal? difference = "example difference";
string category = "example category";
string explanation = "example explanation";

TaxFundReconciliationHoldingResponse taxFundReconciliationHoldingResponseInstance = new TaxFundReconciliationHoldingResponse(
    fundId: fundId,
    period: period,
    holdingId: holdingId,
    instrumentId: instrumentId,
    instrumentName: instrumentName,
    companyAmount: companyAmount,
    fundProxies: fundProxies,
    difference: difference,
    category: category,
    explanation: explanation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
