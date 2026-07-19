# Lusid.Sdk.Model.AccountedComplexMarketData
The Valuation Point complex market data response for a Fund, including the origin of the complex market data relative to the Valuation Point period.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ComplexMarketData** | [**ComplexMarketData**](ComplexMarketData.md) |  | [optional] 
**ValuationPointOrigin** | **string** | Designates if the complex market data was originally part of the Valuation Point or if it was added as part of a Complex Close action. Available values: None, Original, Added, OriginalAndAdded. | [optional] 
**AddedOriginValuationPointCode** | **string** | The Valuation Point code, only for complex market data added as part of a Complex Close action. | [optional] 
**AddedOriginValuationPointVariantCode** | **string** | The Valuation Point variant code, only for complex market data added as part of a Complex Close action. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ComplexMarketData? complexMarketData = new ComplexMarketData();

string valuationPointOrigin = "example valuationPointOrigin";
string addedOriginValuationPointCode = "example addedOriginValuationPointCode";
string addedOriginValuationPointVariantCode = "example addedOriginValuationPointVariantCode";

AccountedComplexMarketData accountedComplexMarketDataInstance = new AccountedComplexMarketData(
    complexMarketData: complexMarketData,
    valuationPointOrigin: valuationPointOrigin,
    addedOriginValuationPointCode: addedOriginValuationPointCode,
    addedOriginValuationPointVariantCode: addedOriginValuationPointVariantCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
