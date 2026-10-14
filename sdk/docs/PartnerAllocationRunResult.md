# Lusid.Sdk.Model.PartnerAllocationRunResult
The outcome of a partner allocation run: the pools the period's income was split into and what, if anything,  could not be attributed to a pool.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | 
**PeriodStart** | **DateTimeOffset** | The start of the period to allocate, exclusive. | 
**PeriodEnd** | **DateTimeOffset** | The end of the period to allocate, inclusive. A valuation point must end on this date. | 
**NavTypeCode** | **string** | The NAV type to allocate under. Defaults to the fund&#39;s primary NAV type. | 
**Status** | **string** | The outcome of the run. Available values: Computed, Booked, DryRun. | 
**RunId** | **string** | The identifier of the run, which prefixes every transaction it books. | 
**Pools** | [**List&lt;PartnerAllocationPool&gt;**](PartnerAllocationPool.md) | The pools of fund-level amount that were allocated. | 
**Unattributed** | [**List&lt;UnattributedAmount&gt;**](UnattributedAmount.md) | Fund-level amounts that no pool claimed. | 
**BookedTransactionIds** | **List&lt;string&gt;** | The identifiers of the transactions the run booked, if any. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId fundId = new ResourceId();
string navTypeCode = "navTypeCode";
string status = "status";
string runId = "runId";
List<PartnerAllocationPool> pools = new List<PartnerAllocationPool>();
List<UnattributedAmount> unattributed = new List<UnattributedAmount>();
List<string> bookedTransactionIds = new List<string>();

PartnerAllocationRunResult partnerAllocationRunResultInstance = new PartnerAllocationRunResult(
    fundId: fundId,
    periodStart: periodStart,
    periodEnd: periodEnd,
    navTypeCode: navTypeCode,
    status: status,
    runId: runId,
    pools: pools,
    unattributed: unattributed,
    bookedTransactionIds: bookedTransactionIds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
