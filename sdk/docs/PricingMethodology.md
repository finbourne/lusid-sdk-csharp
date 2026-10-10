# Lusid.Sdk.Model.PricingMethodology
How a fund prices its share classes for dealing. A Single fund deals at one price per class, which starts at a  baseline and may swing with the fund's net cashflow. A Dual fund deals at a bid and an offer per class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OutputShape** | **string** | How many dealing prices each share class publishes: Single, one price that subscriptions and redemptions both deal at, or Dual, a bid that redemptions deal at and an offer that subscriptions deal at. Available values: Single, Dual. | 
**SwingPolicy** | [**SwingPolicy**](SwingPolicy.md) |  | [optional] 
**PriceLabels** | **string** | What a Dual fund&#39;s two prices are. BidOffer is the only label available: the bid and the offer, including notional dealing costs, that the valuation recipe of each active NAV type publishes. Required for a Dual fund and must be omitted for a Single fund. Available values: BidOffer, CreationCancellation. | [optional] 
**Derivation** | [**DualPriceDerivation**](DualPriceDerivation.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string outputShape = "outputShape";
SwingPolicy? swingPolicy = new SwingPolicy();

string priceLabels = "example priceLabels";
DualPriceDerivation? derivation = new DualPriceDerivation();


PricingMethodology pricingMethodologyInstance = new PricingMethodology(
    outputShape: outputShape,
    swingPolicy: swingPolicy,
    priceLabels: priceLabels,
    derivation: derivation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
