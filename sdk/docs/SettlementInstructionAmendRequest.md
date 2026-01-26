# Lusid.Sdk.Model.SettlementInstructionAmendRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SettlementInstructionId** | **string** |  | 
**Operation** | **string** |  | [optional] 
**Properties** | [**List&lt;PerpetualProperty&gt;**](PerpetualProperty.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string settlementInstructionId = "settlementInstructionId";
string operation = "example operation";
List<PerpetualProperty> properties = new List<PerpetualProperty>();

SettlementInstructionAmendRequest settlementInstructionAmendRequestInstance = new SettlementInstructionAmendRequest(
    settlementInstructionId: settlementInstructionId,
    operation: operation,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
