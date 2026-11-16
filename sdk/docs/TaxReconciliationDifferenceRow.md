# Lusid.Sdk.Model.TaxReconciliationDifferenceRow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HoldingId** | **string** | The identifier of the holding. For a company this is the pooled LUSID instrument identifier, for a fund the portfolio code and instrument identifier. | [optional] 
**InstrumentId** | **string** | The LUSID unique identifier of the instrument. | [optional] 
**InstrumentName** | **string** | The name of the instrument. | [optional] 
**Category** | **string** | The reconciliation category. Available values: ExcludedHoldings, TaxCostAdjustments, OutOfSync, Scope, PoolAveraging, Matching, Indexation, KinkTest. Available values: ExcludedHoldings, TaxCostAdjustments, OutOfSync, Scope, PoolAveraging, Matching, Indexation, KinkTest. | [optional] 
**ComparedAmount** | **decimal** | The amount on the side being reconciled from. | [optional] 
**TaxAmount** | **decimal** | The amount on the tax side. | [optional] 
**Difference** | **decimal** | The difference between the two sides. | [optional] 
**Explanation** | **string** | The explanation of the difference. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string holdingId = "example holdingId";
string instrumentId = "example instrumentId";
string instrumentName = "example instrumentName";
string category = "example category";decimal? comparedAmount = "example comparedAmount";decimal? taxAmount = "example taxAmount";decimal? difference = "example difference";
string explanation = "example explanation";

TaxReconciliationDifferenceRow taxReconciliationDifferenceRowInstance = new TaxReconciliationDifferenceRow(
    holdingId: holdingId,
    instrumentId: instrumentId,
    instrumentName: instrumentName,
    category: category,
    comparedAmount: comparedAmount,
    taxAmount: taxAmount,
    difference: difference,
    explanation: explanation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
