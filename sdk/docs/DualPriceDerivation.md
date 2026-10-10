# Lusid.Sdk.Model.DualPriceDerivation
How a Dual fund derives its dealing prices from one real price by fixed spreads.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RealSide** | **string** | The price read from the valuation: Bid or Offer, from which the other side is derived, or Mid, the share class unit price, from which both sides are derived, for a fund whose market data has no bid or offer. Available values: Bid, Offer, Mid. | 
**IncludeNdc** | **bool** | Whether the real side is read including notional dealing costs, which needs the NAV type to have a notional dealing cost table. Must be false for Mid. | 
**BidSpreadBps** | **decimal?** | How far below the real price the bid is set, in basis points of the real price. Zero or more. Required when the bid is derived, for an Offer or Mid real side, and absent for a Bid one. | [optional] 
**OfferSpreadBps** | **decimal?** | How far above the real price the offer is set, in basis points of the real price. Zero or more. Required when the offer is derived, for a Bid or Mid real side, and absent for an Offer one. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string realSide = "realSide";
bool includeNdc = //"True";

DualPriceDerivation dualPriceDerivationInstance = new DualPriceDerivation(
    realSide: realSide,
    includeNdc: includeNdc,
    bidSpreadBps: bidSpreadBps,
    offerSpreadBps: offerSpreadBps);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
