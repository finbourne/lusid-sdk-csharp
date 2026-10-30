# Lusid.Sdk.Model.EstimateValuationOutcome
Where a net cashflow leads the methodology: whether and which way it swings, the spread and tier it lands in, and the dealing price that results.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Swung** | **bool** | Whether the methodology swings the price on this net cashflow. | 
**SwingDirection** | **string** | &#39;Bid&#39; or &#39;Offer&#39;, the side the price swings to. Absent when it does not swing. | [optional] 
**SpreadBps** | **decimal?** | The stored spread applied, in basis points. Absent when the price does not swing or the spread comes from the market. | [optional] 
**TierMatched** | [**SwingSpreadTierBounds**](SwingSpreadTierBounds.md) |  | [optional] 
**DealingPrice** | **decimal?** | The dealing price the methodology publishes on this net cashflow. Absent when the baseline price is unavailable. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool swung = //"True";
string swingDirection = "example swingDirection";
SwingSpreadTierBounds? tierMatched = new SwingSpreadTierBounds();


EstimateValuationOutcome estimateValuationOutcomeInstance = new EstimateValuationOutcome(
    swung: swung,
    swingDirection: swingDirection,
    spreadBps: spreadBps,
    tierMatched: tierMatched,
    dealingPrice: dealingPrice);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
