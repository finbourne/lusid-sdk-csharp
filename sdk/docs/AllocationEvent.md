# Lusid.Sdk.Model.AllocationEvent
One economic event shared across the participants of an Allocation Map: raised as a draft, computed into  per-investor shares, and finally booked.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Description** | **string** | A description of the Allocation Event. | [optional] 
**AllocationMapId** | [**ResourceId**](ResourceId.md) |  | 
**EventType** | **string** | The type of the event: CapitalCall, Distribution, FeeExpense, ValuationMove, Equalisation, RecallExpiry, Transfer, Default, Commitment or DealFunding. Selects the basis rule from the map. A recall is a CapitalCall with a Recall component. A Commitment event is not shared from a basis: its basis values are the signed commitment amounts per commitment line, and they must sum to the amount. Available values: CapitalCall, Distribution, FeeExpense, ValuationMove, Commitment, Equalisation, RecallExpiry, Transfer, Default, DealFunding. | 
**Amount** | **decimal** | The total amount to be shared across the participants. | 
**Currency** | **string** | The ISO 4217 code of the currency of the amount. The amount may not be finer than the currency&#39;s minor unit: two decimal places for most currencies, none for JPY, three for KWD and BHD. A code with no defined minor unit, such as XAU or XAG, is taken to have two decimal places. | 
**EventDate** | **DateTimeOffset** | The date of the event: the point at which the map, its participants and their basis values are read. | 
**Status** | **string** | The lifecycle status of the event: Draft until its shares are computed, Computed once they are, Booking while its postings are being written, Booked once they all are, and Reversed once a booked event has been backed out. Available values: Draft, Computed, Booked, Booking, Reversed. | 
**BasisSource** | **string** | Where the basis values came from when the shares were last computed. | [optional] 
**Allocations** | [**List&lt;AllocationMapAllocation&gt;**](AllocationMapAllocation.md) | The per-investor shares of the amount, as last computed. | 
**BookingReference** | **string** | The reference under which the shares were posted. Set only once the event is booked. | [optional] 
**BookedAt** | **DateTimeOffset?** | The datetime at which the event was booked. | [optional] 
**ReallocationReason** | **string** | The reason given when the event was last recomputed, if it has been. | [optional] 
**Components** | [**List&lt;AllocationEventComponent&gt;**](AllocationEventComponent.md) | The parts the amount splits into, each shared on its own basis and booked to its own slot. The component amounts must sum to the event amount. Absent means the whole amount is one component: Investment for a CapitalCall, ROC for a Distribution. | [optional] 
**Residuals** | [**List&lt;AllocationEventRoundingResidual&gt;**](AllocationEventRoundingResidual.md) | The minor units left over when each component&#39;s shares were rounded to the currency, and which investor records took them. | [optional] 
**BasisDiagnostics** | [**AllocationEventBasisDiagnostics**](AllocationEventBasisDiagnostics.md) |  | [optional] 
**WrittenIds** | **List&lt;string&gt;** | The identifiers of the postings the booking has written so far, in write order. Complete once the event is Booked. | [optional] 
**BookingErrors** | [**List&lt;AllocationEventBookingError&gt;**](AllocationEventBookingError.md) | The postings the booking could not write. Non-empty leaves the event in Booking; book again under the same reference to resume, or unbook to cancel what was written. | [optional] 
**Warnings** | [**List&lt;AllocationEventBookingWarning&gt;**](AllocationEventBookingWarning.md) | The validation rules the booking was allowed to proceed through under the map&#39;s policy, for instance an OverCall on a map that warns rather than refuses. Kept for the life of the event. | [optional] 
**Transfers** | [**List&lt;AllocationEventTransfer&gt;**](AllocationEventTransfer.md) | For a Transfer event, the legs to book: each moves a fraction of one capital interest line to another. Required for a Transfer event and not allowed on any other type. The fractions out of one line must sum to at most one; the amount of a Transfer event is zero. | [optional] 
**Equalisation** | [**AllocationEventEqualisation**](AllocationEventEqualisation.md) |  | [optional] 
**UseOfProceeds** | [**List&lt;AllocationEventUseOfProceeds&gt;**](AllocationEventUseOfProceeds.md) | For a CapitalCall, what the call pays for: rows of purpose, deal and amount that sum to the call amount. An Investment row names a deal the vehicle has funded and is shared under that deal&#39;s participation, with each investor&#39;s share recorded as paid in for that deal; when the deal was funded from a facility the row repays the draw. Not allowed with components or on any other event type. | [optional] 
**DealFunding** | [**AllocationEventDealFunding**](AllocationEventDealFunding.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**ParentAllocationEventId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Replaces** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Reversal** | [**AllocationEventReversal**](AllocationEventReversal.md) |  | [optional] 
**NoticeDate** | **DateTimeOffset?** | The date the notice went to investors. | [optional] 
**DueDate** | **DateTimeOffset?** | The date the investors&#39; cash is due. | [optional] 
**SettlementDate** | **DateTimeOffset?** | The date the postings settle. Defaults to the event date. | [optional] 
**Receipts** | [**List&lt;AllocationEventReceipt&gt;**](AllocationEventReceipt.md) | The cash received against the event, in the order it was recorded. | [optional] 
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
List<AllocationEventComponent> components = new List<AllocationEventComponent>();
List<AllocationEventRoundingResidual> residuals = new List<AllocationEventRoundingResidual>();
AllocationEventBasisDiagnostics? basisDiagnostics = new AllocationEventBasisDiagnostics();

List<string> writtenIds = new List<string>();
List<AllocationEventBookingError> bookingErrors = new List<AllocationEventBookingError>();
List<AllocationEventBookingWarning> warnings = new List<AllocationEventBookingWarning>();
List<AllocationEventTransfer> transfers = new List<AllocationEventTransfer>();
AllocationEventEqualisation? equalisation = new AllocationEventEqualisation();

List<AllocationEventUseOfProceeds> useOfProceeds = new List<AllocationEventUseOfProceeds>();
AllocationEventDealFunding? dealFunding = new AllocationEventDealFunding();

ModelVersion? varVersion = new ModelVersion();

ResourceId? parentAllocationEventId = new ResourceId();

ResourceId? replaces = new ResourceId();

AllocationEventReversal? reversal = new AllocationEventReversal();

List<AllocationEventReceipt> receipts = new List<AllocationEventReceipt>();
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
    components: components,
    residuals: residuals,
    basisDiagnostics: basisDiagnostics,
    writtenIds: writtenIds,
    bookingErrors: bookingErrors,
    warnings: warnings,
    transfers: transfers,
    equalisation: equalisation,
    useOfProceeds: useOfProceeds,
    dealFunding: dealFunding,
    varVersion: varVersion,
    parentAllocationEventId: parentAllocationEventId,
    replaces: replaces,
    reversal: reversal,
    noticeDate: noticeDate,
    dueDate: dueDate,
    settlementDate: settlementDate,
    receipts: receipts,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
