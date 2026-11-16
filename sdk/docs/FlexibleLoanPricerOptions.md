# Lusid.Sdk.Model.FlexibleLoanPricerOptions
Model options for instruments of type flexibleDeposit and flexibleLoan when used on a standalone basis.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelOptionsType** | **string** | Available values: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, CdsModelOptions, FlexibleLoanPricerOptions, HullWhiteModelOptions, BondLookupModelOptions, BondForwardModelOptions, SimpleModelOptions, StripBondModelOptions. | 
**SetCleanPVToZero** | **bool** | If set to true the CleanPV will be set to zero in valuations and PV will effectively just be the Accrual. | 
**UsePriceQuoteForCleanPV** | **bool?** | If set to true the CleanPV calculation will be looking for a price quote (no default price is assumed). CleanPV will be calculated as Holding/Balance * priceQuote / quoteScaleFactor | [optional] 
**ExcludeIncomeFromPV** | **bool?** | Read by a TotalReturnSwap whose asset leg has a ResetSchedule and whose underlying pays interest or coupons. If set to true the swap&#39;s PV leaves out the underlying&#39;s interest and coupon payments and adds the interest accrued on them to the valuation date instead, so CleanPV is the price return and PV is CleanPV + Accrued. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool setCleanPVToZero = //"True";
bool? usePriceQuoteForCleanPV = //"True";
bool? excludeIncomeFromPV = //"True";

FlexibleLoanPricerOptions flexibleLoanPricerOptionsInstance = new FlexibleLoanPricerOptions(
    setCleanPVToZero: setCleanPVToZero,
    usePriceQuoteForCleanPV: usePriceQuoteForCleanPV,
    excludeIncomeFromPV: excludeIncomeFromPV);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
