# Lusid.Sdk.Model.FacilityReseedFlow
A draw or repayment booked on a Facility, as a re-seed reads it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Event** | **string** | The event that booked the draw or repayment. | 
**Date** | **DateTimeOffset** | The date the draw or repayment takes effect. | 
**Amount** | **decimal** | The amount drawn or repaid. | 
**Currency** | **string** | The currency the amount was booked in. | 
**IsDraw** | **bool** | Whether the flow draws the Facility rather than repaying it. | 
**AllocationMapId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**StructureMemberId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Reason** | **string** | Why the flow cannot be attributed to the Fund: its allocation map&#39;s structureMemberId is not the map&#39;s member fund. Present for an unattributable flow. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string event = "event";decimal amount = "amount";

string currency = "currency";
bool isDraw = //"True";
ResourceId? allocationMapId = new ResourceId();

ResourceId? structureMemberId = new ResourceId();

string reason = "example reason";

FacilityReseedFlow facilityReseedFlowInstance = new FacilityReseedFlow(
    event: event,
    date: date,
    amount: amount,
    currency: currency,
    isDraw: isDraw,
    allocationMapId: allocationMapId,
    structureMemberId: structureMemberId,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
