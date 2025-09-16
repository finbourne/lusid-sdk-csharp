# Lusid.Sdk.Model.SettlementInstructionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SettlementInstructionId** | **string** |  | 
**TransactionId** | **string** |  | 
**SettlementCategory** | **string** |  | 
**InstructionType** | **string** |  | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** |  | 
**ContractualSettlementDate** | **DateTimeOffset?** |  | [optional] 
**ActualSettlementDate** | **DateTimeOffset** |  | 
**Units** | **decimal** |  | 
**SubHoldingKeyOverrides** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) |  | [optional] 
**CustodianAccountOverride** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string settlementInstructionId = "settlementInstructionId";
string transactionId = "transactionId";
string settlementCategory = "settlementCategory";
string instructionType = "example instructionType";
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();decimal units = "units";

Dictionary<string, PerpetualProperty> subHoldingKeyOverrides = new Dictionary<string, PerpetualProperty>();
ResourceId? custodianAccountOverride = new ResourceId();


SettlementInstructionRequest settlementInstructionRequestInstance = new SettlementInstructionRequest(
    settlementInstructionId: settlementInstructionId,
    transactionId: transactionId,
    settlementCategory: settlementCategory,
    instructionType: instructionType,
    instrumentIdentifiers: instrumentIdentifiers,
    contractualSettlementDate: contractualSettlementDate,
    actualSettlementDate: actualSettlementDate,
    units: units,
    subHoldingKeyOverrides: subHoldingKeyOverrides,
    custodianAccountOverride: custodianAccountOverride);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
