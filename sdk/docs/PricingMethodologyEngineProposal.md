# Lusid.Sdk.Model.PricingMethodologyEngineProposal
What the pricing methodology alone publishes for a share class, kept alongside any decision that replaces it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Swung** | **bool** | Whether the methodology swings the price. | 
**SwingDirection** | **string** | Offer or Bid when the methodology swings the price. Absent when it does not. | [optional] 
**SpreadSource** | **string** | Where the methodology&#39;s spread came from: Stored or Market. Absent when it does not swing. | [optional] 
**SpreadBps** | **decimal?** | The stored spread the methodology applies, in basis points. Absent when it does not swing or swings to a market price. | [optional] 
**DealingPrice** | **decimal?** | The dealing price the methodology publishes. Absent when the class has no units in issue. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool swung = //"True";
string swingDirection = "example swingDirection";
string spreadSource = "example spreadSource";

PricingMethodologyEngineProposal pricingMethodologyEngineProposalInstance = new PricingMethodologyEngineProposal(
    swung: swung,
    swingDirection: swingDirection,
    spreadSource: spreadSource,
    spreadBps: spreadBps,
    dealingPrice: dealingPrice);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
