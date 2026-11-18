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
**Pools** | [**List&lt;PartnerAllocationPool&gt;**](PartnerAllocationPool.md) | The pools of fund-level amount that were allocated, in the allocation bucket set&#39;s bucket order with any tag pools after. | 
**Unattributed** | [**List&lt;UnattributedAmount&gt;**](UnattributedAmount.md) | Always empty: every profit and loss line is pooled or the run is refused. No longer required; removed once no published SDK requires it. | [optional] 
**BookedTransactionIds** | **List&lt;string&gt;** | The identifiers of the transactions the run booked, if any. | 
**Warnings** | **List&lt;string&gt;** | What the run noticed but did not refuse, for example an excluded investor record that is not on the register at the period end, or a fee accrual naming no investor that was pooled as unaccrued fee (AccruedFeeWithoutInvestor). | [optional] 
**IgnoredTags** | [**List&lt;IgnoredDistributionTag&gt;**](IgnoredDistributionTag.md) | The distribution character tags the run did not pool by, by account. | [optional] 
**AccruedFees** | [**List&lt;AccruedFeeLine&gt;**](AccruedFeeLine.md) | The management fees accrued per partner in the period, which the accrual allocates and the run therefore leaves out of the pools. | [optional] 

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
List<string> warnings = new List<string>();
List<IgnoredDistributionTag> ignoredTags = new List<IgnoredDistributionTag>();
List<AccruedFeeLine> accruedFees = new List<AccruedFeeLine>();

PartnerAllocationRunResult partnerAllocationRunResultInstance = new PartnerAllocationRunResult(
    fundId: fundId,
    periodStart: periodStart,
    periodEnd: periodEnd,
    navTypeCode: navTypeCode,
    status: status,
    runId: runId,
    pools: pools,
    unattributed: unattributed,
    bookedTransactionIds: bookedTransactionIds,
    warnings: warnings,
    ignoredTags: ignoredTags,
    accruedFees: accruedFees);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
