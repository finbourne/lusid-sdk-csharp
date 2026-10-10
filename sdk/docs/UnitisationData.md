# Lusid.Sdk.Model.UnitisationData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SharesInIssue** | **decimal** | The number of shares in issue at a valuation point. | 
**UnitPrice** | **decimal** | The price of one unit of the share class at a valuation point. | 
**NetDealingUnits** | **decimal** | The net dealing in units for the share class at a valuation point. This could be the sum of negative redemptions (in units) and positive subscriptions (in units). | 
**BidPrice** | **decimal?** | The price of one unit of the share class on the bid side at a valuation point: the class&#39;s NAV with the fund&#39;s holdings marked at their bid prices. Equal to the unit price when the fund is struck on the bid. Absent when a holding&#39;s bid could not be priced. | [optional] 
**OfferPrice** | **decimal?** | The price of one unit of the share class on the offer side at a valuation point: the class&#39;s NAV with the fund&#39;s holdings marked at their ask prices. Equal to the unit price when the fund is struck on the ask. Absent when a holding&#39;s ask could not be priced. | [optional] 
**BidPriceIncNdc** | **decimal?** | The bid price of one unit of the share class less the class&#39;s share of the notional dealing costs of selling the fund&#39;s holdings, at a valuation point. Absent when the NAV type has no notional dealing cost table. | [optional] 
**OfferPriceIncNdc** | **decimal?** | The offer price of one unit of the share class plus the class&#39;s share of the notional dealing costs of buying the fund&#39;s holdings, at a valuation point. Absent when the NAV type has no notional dealing cost table. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal sharesInIssue = "sharesInIssue";
decimal unitPrice = "unitPrice";
decimal netDealingUnits = "netDealingUnits";


UnitisationData unitisationDataInstance = new UnitisationData(
    sharesInIssue: sharesInIssue,
    unitPrice: unitPrice,
    netDealingUnits: netDealingUnits,
    bidPrice: bidPrice,
    offerPrice: offerPrice,
    bidPriceIncNdc: bidPriceIncNdc,
    offerPriceIncNdc: offerPriceIncNdc);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
