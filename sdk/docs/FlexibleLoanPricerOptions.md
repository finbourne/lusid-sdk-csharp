# Lusid.Sdk.Model.FlexibleLoanPricerOptions
Model options for instruments of type flexibleDeposit and flexibleLoan when used on a standalone basis.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelOptionsType** | **string** | Available values: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, CdsModelOptions, FlexibleLoanPricerOptions, HullWhiteModelOptions, BondLookupModelOptions, BondForwardModelOptions, SimpleModelOptions. | 
**SetCleanPVToZero** | **bool** | If set to true the CleanPV will be set to zero in valuations and PV will effectively just be the Accrual. | 
**UsePriceQuoteForCleanPV** | **bool?** | If set to true the CleanPV calculation will be looking for a price quote (no default price is assumed). CleanPV will be calculated as Holding/Balance * priceQuote / quoteScaleFactor | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool setCleanPVToZero = //"True";
bool? usePriceQuoteForCleanPV = //"True";

FlexibleLoanPricerOptions flexibleLoanPricerOptionsInstance = new FlexibleLoanPricerOptions(
    setCleanPVToZero: setCleanPVToZero,
    usePriceQuoteForCleanPV: usePriceQuoteForCleanPV);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
