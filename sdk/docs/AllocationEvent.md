# Lusid.Sdk.Model.AllocationEvent
One economic event shared across the participants of an Allocation Map: raised as a draft, computed into  per-investor shares, and finally booked.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Description** | **string** | A description of the Allocation Event. | [optional] 
**AllocationMapId** | [**ResourceId**](ResourceId.md) |  | 
**EventType** | **string** | The type of the event: CapitalCall, Distribution, FeeExpense or ValuationMove. Selects the basis rule from the map. Available values: CapitalCall, Distribution, FeeExpense, ValuationMove. | 
**Amount** | **decimal** | The total amount to be shared across the participants. | 
**Currency** | **string** | The ISO 4217 code of the currency of the amount. The amount may not be finer than the currency&#39;s minor unit: two decimal places for most currencies, none for JPY, three for KWD and BHD. A code with no defined minor unit, such as XAU or XAG, is taken to have two decimal places. | 
**EventDate** | **DateTimeOffset** | The date of the event: the point at which the map, its participants and their basis values are read. | 
**Status** | **string** | The lifecycle status of the event: Draft until its shares are computed, Computed once they are, and Booked once posted. Available values: Draft, Computed, Booked. | 
**BasisSource** | **string** | Where the basis values came from when the shares were last computed. | [optional] 
**Allocations** | [**List&lt;AllocationMapAllocation&gt;**](AllocationMapAllocation.md) | The per-investor shares of the amount, as last computed. | 
**BookingReference** | **string** | The reference under which the shares were posted. Set only once the event is booked. | [optional] 
**BookedAt** | **DateTimeOffset?** | The datetime at which the event was booked. | [optional] 
**ReallocationReason** | **string** | The reason given when the event was last recomputed, if it has been. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string description = "example description";
ResourceId allocationMapId = new ResourceId();
string eventType = "eventType";decimal amount = "amount";

string currency = "currency";
string status = "status";
string basisSource = "example basisSource";
List<AllocationMapAllocation> allocations = new List<AllocationMapAllocation>();
string bookingReference = "example bookingReference";
string reallocationReason = "example reallocationReason";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

AllocationEvent allocationEventInstance = new AllocationEvent(
    href: href,
    id: id,
    description: description,
    allocationMapId: allocationMapId,
    eventType: eventType,
    amount: amount,
    currency: currency,
    eventDate: eventDate,
    status: status,
    basisSource: basisSource,
    allocations: allocations,
    bookingReference: bookingReference,
    bookedAt: bookedAt,
    reallocationReason: reallocationReason,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
