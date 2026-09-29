# Lusid.Sdk.Model.SettleExpectedActivityWritebackSuggestion
Suggests a settlement instruction that settles the expected activity of the target item, using the  settlement confirmed by the origin item on the other side of the result. The request is upsertable as-is.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultPattern** | [**WritebackResultPattern**](WritebackResultPattern.md) |  | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**SettlementInstructionRequest** | [**SettlementInstructionRequest**](SettlementInstructionRequest.md) |  | 
**WritebackType** | **string** | Polymorphic discriminator, carrying the same values as writebackType on the matching ruleset&#39;s writeback configuration. Supported types: SettleExpectedActivity. Available values: SettleExpectedActivity. | 

```csharp
using Lusid.Sdk.Model;
using System;

WritebackResultPattern resultPattern = new WritebackResultPattern();
ResourceId portfolioId = new ResourceId();
SettlementInstructionRequest settlementInstructionRequest = new SettlementInstructionRequest();
string writebackType = "writebackType";

SettleExpectedActivityWritebackSuggestion settleExpectedActivityWritebackSuggestionInstance = new SettleExpectedActivityWritebackSuggestion(
    resultPattern: resultPattern,
    portfolioId: portfolioId,
    settlementInstructionRequest: settlementInstructionRequest,
    writebackType: writebackType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
