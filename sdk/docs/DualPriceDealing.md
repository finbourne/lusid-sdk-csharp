# Lusid.Sdk.Model.DualPriceDealing
The bid and offer dealing prices a share class of a Dual fund publishes at a valuation point.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DealingBid** | **decimal?** | The price redemptions deal at, rounded as the share class unit price is. Absent when the class has no units in issue or the valuation did not price the side. | [optional] 
**DealingOffer** | **decimal?** | The price subscriptions deal at, rounded as the share class unit price is. Absent when the class has no units in issue or the valuation did not price the side. | [optional] 
**BidPerValuationSource** | **string** | The share class price the dealing bid was read or derived from: Bid when it is the bid read as published, Offer or Mid when it was derived from that price. Absent when nothing was dealt. | [optional] 
**OfferPerValuationSource** | **string** | The share class price the dealing offer was read or derived from: Offer when it is the offer read as published, Bid or Mid when it was derived from that price. Absent when nothing was dealt. | [optional] 
**BidSpreadBps** | **decimal?** | The spread, in basis points, the dealing bid was set below the price it was derived from by. Absent when the bid was read. | [optional] 
**OfferSpreadBps** | **decimal?** | The spread, in basis points, the dealing offer was set above the price it was derived from by. Absent when the offer was read. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bidPerValuationSource = "example bidPerValuationSource";
string offerPerValuationSource = "example offerPerValuationSource";

DualPriceDealing dualPriceDealingInstance = new DualPriceDealing(
    dealingBid: dealingBid,
    dealingOffer: dealingOffer,
    bidPerValuationSource: bidPerValuationSource,
    offerPerValuationSource: offerPerValuationSource,
    bidSpreadBps: bidSpreadBps,
    offerSpreadBps: offerSpreadBps);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
