# Lusid.Sdk.Model.FundStructureCloseStep
One member's step in a fund structure close.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemberShortCode** | **string** | The node code of the member in the structure. | 
**Fund** | [**ResourceId**](ResourceId.md) |  | 
**Step** | **int** | The position of the member in the close order. | 
**Status** | **string** | What happened to the member. Available values: Finalised, AlreadyFinal, Failed, Skipped. | 
**Failure** | **string** | The failure that stopped the member finalising, if any. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string memberShortCode = "memberShortCode";
ResourceId fund = new ResourceId();
string status = "status";
string failure = "example failure";

FundStructureCloseStep fundStructureCloseStepInstance = new FundStructureCloseStep(
    memberShortCode: memberShortCode,
    fund: fund,
    step: step,
    status: status,
    failure: failure);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
