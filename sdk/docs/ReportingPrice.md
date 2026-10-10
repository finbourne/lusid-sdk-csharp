# Lusid.Sdk.Model.ReportingPrice
A share class price a fund publishes at each valuation point under a label of its own, alongside the dealing price.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | **string** | The share class price published: Mid, the unit price, or Bid, Offer, BidIncNdc or OfferIncNdc, as the valuation recipe of each active NAV type publishes it. Available values: Mid, Bid, Offer, BidIncNdc, OfferIncNdc, Creation, Cancellation. | 
**Label** | **string** | The name the price is published under in the share class&#39;s reporting prices. Unique within the fund. | 

```csharp
using Lusid.Sdk.Model;
using System;

string source = "source";
string label = "label";

ReportingPrice reportingPriceInstance = new ReportingPrice(
    source: source,
    label: label);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
