# Lusid.Sdk.Model.QuoteId
The unique identifier of the quote.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuoteSeriesId** | [**QuoteSeriesId**](QuoteSeriesId.md) |  | 
**EffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The effective datetime or cut label at which the quote is valid from. | 

```csharp
using Lusid.Sdk.Model;
using System;

QuoteSeriesId quoteSeriesId = new QuoteSeriesId();
DateTimeOrCutLabel effectiveAt = "effectiveAt";

QuoteId quoteIdInstance = new QuoteId(
    quoteSeriesId: quoteSeriesId,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
