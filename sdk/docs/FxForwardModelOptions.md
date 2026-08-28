# Lusid.Sdk.Model.FxForwardModelOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelOptionsType** | **string** | Available values: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, CdsModelOptions, FlexibleLoanPricerOptions, HullWhiteModelOptions, BondLookupModelOptions. | 
**ForwardRateObservableType** | **string** | Available values: ForwardPoints, ForwardRate, RatesCurve, FxForwardCurve, Invalid. | 
**DiscountingMethod** | **string** | Available values: Standard, ConstantTimeValueOfMoney, Invalid. | 
**ConvertToReportCcy** | **bool** | Convert all FX flows to the report currency  By setting this all FX forwards will be priced using Forward Curves that have Report Currency as the base. | 
**AllowSpotFallbackForReportCcy** | **bool** | When converting to the report currency, allow falling back to pricing off the natural-pair forward  and converting to the report currency at spot when the report-currency cross forward curves are not  available. Defaults to false, in which case the report-currency cross forwards are required. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string forwardRateObservableType = "forwardRateObservableType";
string discountingMethod = "discountingMethod";
bool convertToReportCcy = //"True";
bool allowSpotFallbackForReportCcy = //"True";

FxForwardModelOptions fxForwardModelOptionsInstance = new FxForwardModelOptions(
    forwardRateObservableType: forwardRateObservableType,
    discountingMethod: discountingMethod,
    convertToReportCcy: convertToReportCcy,
    allowSpotFallbackForReportCcy: allowSpotFallbackForReportCcy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
