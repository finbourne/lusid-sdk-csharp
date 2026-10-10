# Lusid.Sdk.Model.PricingMethodologyOverride
The fund manager's override a share class's dealing price follows instead of the pricing methodology's proposal,  and who made it when.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Decision** | **string** | The basis the dealing price is published on: Mid, Bid or Offer. Under a Stored spread source the spread for Bid or Offer is the stored tier the net cashflow matches in that direction, or that direction&#39;s first tier when the flow is below every tier. Under a Market spread source Bid or Offer reads that side&#39;s price including notional dealing costs, which every active NAV type&#39;s valuation recipe must publish. | 
**Reason** | **string** | Why the fund manager overrode the methodology&#39;s decision. | 
**User** | **string** | The user who made the override. | [optional] 
**Timestamp** | **DateTimeOffset** | When the override was made. | 

```csharp
using Lusid.Sdk.Model;
using System;

string decision = "decision";
string reason = "reason";
string user = "example user";

PricingMethodologyOverride pricingMethodologyOverrideInstance = new PricingMethodologyOverride(
    decision: decision,
    reason: reason,
    user: user,
    timestamp: timestamp);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
