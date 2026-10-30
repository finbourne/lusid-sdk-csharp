# Lusid.Sdk.Model.EstimateValuation
The swing decision read at both unit prices the transfer agency's unit-denominated orders could be valued at: this valuation point's estimate price and the last official price, with which one the decision used and how far apart they are.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DecisionPrice** | **string** | The unit price the swing decision was taken on. &#39;EstimatePrice&#39; is the price struck at this valuation point; &#39;LastOfficialPrice&#39; is the unit price the previous valuation point published. &#39;EstimatePrice&#39; when the fund asked for the last official price but has none yet, as on its first valuation point. | 
**AtEstimatePrice** | [**DealingFlowValuation**](DealingFlowValuation.md) |  | 
**AtLastOfficialPrice** | [**DealingFlowValuation**](DealingFlowValuation.md) |  | [optional] 
**Difference** | [**EstimateValuationDifference**](EstimateValuationDifference.md) |  | [optional] 
**UnitBasedShare** | **decimal** | The fraction of the decision&#39;s net cashflow that came from unit-denominated orders, from 0 to 1. Zero when the net cashflow is zero. | 

```csharp
using Lusid.Sdk.Model;
using System;

string decisionPrice = "decisionPrice";
DealingFlowValuation atEstimatePrice = new DealingFlowValuation();
DealingFlowValuation? atLastOfficialPrice = new DealingFlowValuation();

EstimateValuationDifference? difference = new EstimateValuationDifference();
decimal unitBasedShare = "unitBasedShare";


EstimateValuation estimateValuationInstance = new EstimateValuation(
    decisionPrice: decisionPrice,
    atEstimatePrice: atEstimatePrice,
    atLastOfficialPrice: atLastOfficialPrice,
    difference: difference,
    unitBasedShare: unitBasedShare);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
