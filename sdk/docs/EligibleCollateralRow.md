# Lusid.Sdk.Model.EligibleCollateralRow
One class of eligible collateral and how it is valued, as stored on a schedule.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The stable key the row is referred to by. Unique within the schedule. | 
**Description** | **string** | A description of the row. Optional. | [optional] 
**Selector** | [**EligibleCollateralAssetSelector**](EligibleCollateralAssetSelector.md) |  | 
**ValuationPercentage** | **decimal** | The fraction of an asset&#39;s value that is accepted as collateral, for example 0.95 for 95%. Greater than 0 and at most 1. | 
**FxHaircut** | **decimal?** | The further fraction deducted when the asset&#39;s currency is not the agreement&#39;s base currency, so that the effective valuation percentage is ValuationPercentage - FxHaircut. At least 0 and less than the valuationPercentage. Not allowed for a BaseCurrencyCash selector. Optional. | [optional] 
**MinResidualMaturityYears** | **decimal?** | The inclusive lower bound of the residual maturity in years that the row applies to. Only allowed for an Instrument selector. Optional. | [optional] 
**MaxResidualMaturityYears** | **decimal?** | The exclusive upper bound of the residual maturity in years that the row applies to. Only allowed for an Instrument selector. Optional. | [optional] 
**ConcentrationGroup** | **string** | The group the row&#39;s assets count towards for a concentration limit, for example &#39;sovereign&#39; or &#39;issuer&#39;. Rows naming the same group share one limit. Required when a concentrationLimit is set. Optional. | [optional] 
**ConcentrationLimit** | **decimal?** | The largest fraction of the collateral held plus the call that assets of the row&#39;s concentration group may make up, for example 0.3 for 30%. Greater than 0 and at most 1. Required when a concentrationGroup is set. Optional. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string description = "example description";
EligibleCollateralAssetSelector selector = new EligibleCollateralAssetSelector();decimal valuationPercentage = "valuationPercentage";

string concentrationGroup = "example concentrationGroup";

EligibleCollateralRow eligibleCollateralRowInstance = new EligibleCollateralRow(
    code: code,
    description: description,
    selector: selector,
    valuationPercentage: valuationPercentage,
    fxHaircut: fxHaircut,
    minResidualMaturityYears: minResidualMaturityYears,
    maxResidualMaturityYears: maxResidualMaturityYears,
    concentrationGroup: concentrationGroup,
    concentrationLimit: concentrationLimit);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
