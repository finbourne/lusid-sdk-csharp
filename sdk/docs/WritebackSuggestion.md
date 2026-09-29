# Lusid.Sdk.Model.WritebackSuggestion
A writeback suggested against a target-side item of a rec result. Polymorphic by WritebackType; each  supported type has a corresponding inherited class carrying the upsertable request it proposes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WritebackType** | **string** | Polymorphic discriminator, carrying the same values as writebackType on the matching ruleset&#39;s writeback configuration. Supported types: SettleExpectedActivity. Available values: SettleExpectedActivity. | 
**ResultPattern** | [**WritebackResultPattern**](WritebackResultPattern.md) |  | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**SettlementInstructionRequest** | [**SettlementInstructionRequest**](SettlementInstructionRequest.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;
```
 [SettleExpectedActivityWritebackSuggestion](./SettleExpectedActivityWritebackSuggestion.md)See all compatible oneOf types with WritebackSuggestion

# Example with WritebackSuggestion
{
     Type  =  "SettleExpectedActivityWritebackSuggestion"
};
//Create WritebackSuggestion Instance
var writebackSuggestionInstance = new writebackSuggestion(settleExpectedActivityWritebackSuggestionInstance)



[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
