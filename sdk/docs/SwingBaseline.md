# Lusid.Sdk.Model.SwingBaseline
The price a Single fund's dealing price starts from before any swing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Source** | **string** | The price the dealing price starts from: Mid, the share class unit price, or Bid or Offer, the share class price that the valuation recipe of each active NAV type publishes on that side. Available values: Mid, Bid, Offer. | 
**IncludeNdc** | **bool?** | Whether a Bid or Offer baseline reads the price including notional dealing costs, which needs the NAV type to have a notional dealing cost table. Required for a Bid or Offer baseline and must be omitted for a Mid baseline. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string source = "source";
bool? includeNdc = //"True";

SwingBaseline swingBaselineInstance = new SwingBaseline(
    source: source,
    includeNdc: includeNdc);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
