# Lusid.Sdk.Model.SinglePriceDealing
The single dealing price a share class publishes at a valuation point.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DealingPrice** | **decimal?** | The price subscriptions and redemptions deal at, rounded as the share class unit price is. Absent when the class has no units in issue. | [optional] 
**Swung** | **bool** | Whether the dealing price moved away from its baseline. | 
**SwingDirection** | **string** | Offer when a net inflow swung the price up, Bid when a net outflow swung it down. Absent when the price did not swing. | [optional] 
**SwingFrom** | **string** | The baseline the price swung away from. Absent when it did not swing. | [optional] 
**PerValuationSource** | **string** | Bid or Offer when the dealing price is that side&#39;s share class price read as published, from a Bid or Offer baseline or a Market swing. Absent when the price is the mid or a stored spread was applied to it. | [optional] 
**SpreadBps** | **decimal?** | The stored spread applied, in basis points. Absent when the price did not swing or swung to a market price. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool swung = //"True";
string swingDirection = "example swingDirection";
string swingFrom = "example swingFrom";
string perValuationSource = "example perValuationSource";

SinglePriceDealing singlePriceDealingInstance = new SinglePriceDealing(
    dealingPrice: dealingPrice,
    swung: swung,
    swingDirection: swingDirection,
    swingFrom: swingFrom,
    perValuationSource: perValuationSource,
    spreadBps: spreadBps);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
