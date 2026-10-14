# Lusid.Sdk.Model.EligibleCollateralRowRequest
One class of eligible collateral and how it is valued, as supplied when a schedule is created or upserted.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The stable key the row is referred to by. Unique within the schedule. | 
**Description** | **string** | A description of the row. Optional. | [optional] 
**Selector** | [**EligibleCollateralAssetSelectorRequest**](EligibleCollateralAssetSelectorRequest.md) |  | 
**ValuationPercentage** | **decimal** | The fraction of an asset&#39;s value that is accepted as collateral, for example 0.95 for 95%. Greater than 0 and at most 1. | 
**FxHaircut** | **decimal?** | The further fraction deducted when the asset&#39;s currency is not the agreement&#39;s base currency, so that the effective valuation percentage is ValuationPercentage * (1 - FxHaircut). At least 0 and less than 1. Not allowed for a BaseCurrencyCash selector. Optional. | [optional] 
**MinResidualMaturityYears** | **decimal?** | The inclusive lower bound of the residual maturity in years that the row applies to. Only allowed for an Instrument selector. Optional. | [optional] 
**MaxResidualMaturityYears** | **decimal?** | The exclusive upper bound of the residual maturity in years that the row applies to. Only allowed for an Instrument selector. Optional. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string description = "example description";
EligibleCollateralAssetSelectorRequest selector = new EligibleCollateralAssetSelectorRequest();decimal valuationPercentage = "valuationPercentage";


EligibleCollateralRowRequest eligibleCollateralRowRequestInstance = new EligibleCollateralRowRequest(
    code: code,
    description: description,
    selector: selector,
    valuationPercentage: valuationPercentage,
    fxHaircut: fxHaircut,
    minResidualMaturityYears: minResidualMaturityYears,
    maxResidualMaturityYears: maxResidualMaturityYears);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
