# Lusid.Sdk.Model.AllocationMapResolution
The result of resolving an Allocation Map for one event: how much each investor record receives, and why.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | The kind of allocation event that was resolved. Available values: CapitalCall, Distribution, FeeExpense, ValuationMove. | [optional] 
**Amount** | **decimal** | The amount that was shared. | [optional] 
**Currency** | **string** | The currency of the amount. | [optional] 
**BasisRule** | **string** | The basis the map applies to this event type. Available values: ValueWeighted, PropertyWeighted, FixedPercentage. | [optional] 
**BasisPool** | **decimal** | The sum of the basis values over the participants that share the remainder pro rata. | [optional] 
**FixedTotal** | **decimal** | The total taken off the top by FixedPercentage exceptions before the remainder is shared. | [optional] 
**ParticipantCount** | **int** | The number of investor records that receive a share, whether fixed or pro rata. | [optional] 
**ExcludedCount** | **int** | The number of investor records an exception removed from the allocation. | [optional] 
**Allocations** | [**List&lt;AllocationMapAllocation&gt;**](AllocationMapAllocation.md) | The share of each investor record, including those excluded, which receive nothing. | [optional] 
**Reconciles** | **bool** | Whether the allocated amounts sum exactly to the requested amount. Amounts are rounded to two decimal places with the largest-remainder method, so an amount with more decimal places does not reconcile. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string eventType = "example eventType";decimal? amount = "example amount";
string currency = "example currency";
string basisRule = "example basisRule";decimal? basisPool = "example basisPool";decimal? fixedTotal = "example fixedTotal";
List<AllocationMapAllocation> allocations = new List<AllocationMapAllocation>();
bool reconciles = //"True";

AllocationMapResolution allocationMapResolutionInstance = new AllocationMapResolution(
    eventType: eventType,
    amount: amount,
    currency: currency,
    basisRule: basisRule,
    basisPool: basisPool,
    fixedTotal: fixedTotal,
    participantCount: participantCount,
    excludedCount: excludedCount,
    allocations: allocations,
    reconciles: reconciles);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
