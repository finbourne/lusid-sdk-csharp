# Lusid.Sdk.Model.AllocationEventNoticeUnfundedReconciliation
The partner's unfunded commitment rolled through the event on the notice.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Opening** | **decimal** | The unfunded commitment before the event. | 
**Calls** | **decimal** | Capital calls reducing the unfunded commitment. | 
**DistributionsRecallable** | **decimal** | Recallable distributions restoring the unfunded commitment. | 
**Expiries** | **decimal** | Recallable amounts that expired. | 
**CommitmentChanges** | **decimal** | Changes to the commitment itself. | 
**Transfers** | **decimal** | Transfers of unfunded commitment between partners. | 
**Closing** | **decimal** | The unfunded commitment after the event. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal opening = "opening";
decimal calls = "calls";
decimal distributionsRecallable = "distributionsRecallable";
decimal expiries = "expiries";
decimal commitmentChanges = "commitmentChanges";
decimal transfers = "transfers";
decimal closing = "closing";


AllocationEventNoticeUnfundedReconciliation allocationEventNoticeUnfundedReconciliationInstance = new AllocationEventNoticeUnfundedReconciliation(
    opening: opening,
    calls: calls,
    distributionsRecallable: distributionsRecallable,
    expiries: expiries,
    commitmentChanges: commitmentChanges,
    transfers: transfers,
    closing: closing);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
