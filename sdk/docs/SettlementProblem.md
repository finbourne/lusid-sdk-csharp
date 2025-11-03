# Lusid.Sdk.Model.SettlementProblem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SettlementInstructionId** | **string** | The id of the problematic settlement instruction. Combined with the portfolio id this uniquely identifies a settlement instruction | 
**Category** | **string** | The category this instruction belongs to | 
**Status** | **string** | The status of the settlement instruction. Possible values are &#39;Invalid&#39; or &#39;Rejected&#39;. | 

```csharp
using Lusid.Sdk.Model;
using System;

string settlementInstructionId = "settlementInstructionId";
string category = "category";
string status = "status";

SettlementProblem settlementProblemInstance = new SettlementProblem(
    settlementInstructionId: settlementInstructionId,
    category: category,
    status: status);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
