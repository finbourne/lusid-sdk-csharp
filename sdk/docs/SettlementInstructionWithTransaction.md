# Lusid.Sdk.Model.SettlementInstructionWithTransaction
A Settlement Instruction with its Matched Transaction (if any)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SettlementInstruction** | [**TransactionSettlementInstruction**](TransactionSettlementInstruction.md) |  | [optional] 
**MatchedTransaction** | [**OutputTransaction**](OutputTransaction.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

TransactionSettlementInstruction? settlementInstruction = new TransactionSettlementInstruction();

OutputTransaction? matchedTransaction = new OutputTransaction();


SettlementInstructionWithTransaction settlementInstructionWithTransactionInstance = new SettlementInstructionWithTransaction(
    settlementInstruction: settlementInstruction,
    matchedTransaction: matchedTransaction);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
