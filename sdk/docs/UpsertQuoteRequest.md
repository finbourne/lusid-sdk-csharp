# Lusid.Sdk.Model.UpsertQuoteRequest
The details of the quote including its unique identifier, value and lineage.  Please note the Unit field on MetricValue is nullable on the upsert but there  is validation within the quote store to make sure this field is populated.  In the absence of a real unit then we recommend putting something in line with  the data in QuoteId.QuoteSeriesId.quoteType e.g. InterestRate.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**QuoteId** | [**QuoteId**](QuoteId.md) |  | 
**MetricValue** | [**MetricValue**](MetricValue.md) |  | [optional] 
**Lineage** | **string** | Description of the quote&#39;s lineage e.g. &#39;FundAccountant_GreenQuality&#39;. | [optional] 
**ScaleFactor** | **decimal?** | An optional scale factor for non-standard scaling of quotes against the instrument. For example, if you wish the quote&#39;s Value to be scaled down by a factor of 100, enter 100. If not supplied, the default ScaleFactor is 1. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

QuoteId quoteId = new QuoteId();
MetricValue? metricValue = new MetricValue();

string lineage = "example lineage";

UpsertQuoteRequest upsertQuoteRequestInstance = new UpsertQuoteRequest(
    quoteId: quoteId,
    metricValue: metricValue,
    lineage: lineage,
    scaleFactor: scaleFactor);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
