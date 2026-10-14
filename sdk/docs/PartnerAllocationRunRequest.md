# Lusid.Sdk.Model.PartnerAllocationRunRequest
The request to allocate a period's income summary to the partners of a partnership fund.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PeriodStart** | **DateTimeOffset** | The start of the period to allocate, exclusive. | 
**PeriodEnd** | **DateTimeOffset** | The end of the period to allocate, inclusive. A valuation point must end on this date. | 
**NavTypeCode** | **string** | The NAV type to allocate under. Defaults to the fund&#39;s primary NAV type. | [optional] 
**DryRun** | **bool** | When true, the allocation is computed and returned but nothing is booked. | [optional] 
**Correction** | **bool** | When true, a period that has already been allocated may be re-allocated. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string navTypeCode = "example navTypeCode";
bool dryRun = //"True";
bool correction = //"True";

PartnerAllocationRunRequest partnerAllocationRunRequestInstance = new PartnerAllocationRunRequest(
    periodStart: periodStart,
    periodEnd: periodEnd,
    navTypeCode: navTypeCode,
    dryRun: dryRun,
    correction: correction);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
