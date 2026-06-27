# Lusid.Sdk.Model.AccountedQuote
The Valuation Point quote response for a Fund, including the origin of the quote relative to the Valuation Point period.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Quote** | [**Quote**](Quote.md) |  | [optional] 
**ValuationPointOrigin** | **string** | Designates if the quote was originally part of the Valuation Point or if it was added as part of a Complex Close action. Available values: None, Original, Added, OriginalAndAdded. | [optional] 
**AddedOriginValuationPointCode** | **string** | The Valuation Point code, only for quotes added as part of a Complex Close action. | [optional] 
**AddedOriginValuationPointVariantCode** | **string** | The Valuation Point variant code, only for quotes added as part of a Complex Close action. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Quote? quote = new Quote();

string valuationPointOrigin = "example valuationPointOrigin";
string addedOriginValuationPointCode = "example addedOriginValuationPointCode";
string addedOriginValuationPointVariantCode = "example addedOriginValuationPointVariantCode";

AccountedQuote accountedQuoteInstance = new AccountedQuote(
    quote: quote,
    valuationPointOrigin: valuationPointOrigin,
    addedOriginValuationPointCode: addedOriginValuationPointCode,
    addedOriginValuationPointVariantCode: addedOriginValuationPointVariantCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
