# Lusid.Sdk.Model.AllocationEventRequest
The request used to raise or replace an Allocation Event. The event is computed against its map straight away.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the Allocation Event. Together with the scope this uniquely identifies the event. | 
**AllocationMapId** | [**ResourceId**](ResourceId.md) |  | 
**EventType** | **string** | The type of the event: CapitalCall, Distribution, FeeExpense, ValuationMove, Equalisation, RecallExpiry, Transfer, Default, Commitment or DealFunding. Selects the basis rule from the map. A recall is a CapitalCall with a Recall component. A Commitment event is not shared from a basis: its basis values are the signed commitment amounts per commitment line, and they must sum to the amount. Available values: CapitalCall, Distribution, FeeExpense, ValuationMove, Commitment, Equalisation, RecallExpiry, Transfer, Default, DealFunding. | 
**Amount** | **decimal** | The total amount to be shared across the participants. | 
**Currency** | **string** | The ISO 4217 code of the currency of the amount. The amount may not be finer than the currency&#39;s minor unit: two decimal places for most currencies, none for JPY, three for KWD and BHD. A code with no defined minor unit, such as XAU or XAG, is taken to have two decimal places. | 
**EventDate** | **DateTimeOffset** | The date of the event: the point at which the map, its participants and their basis values are read. | 
**Description** | **string** | A description of the Allocation Event. | [optional] 
**BasisValues** | [**List&lt;AllocationMapBasisValue&gt;**](AllocationMapBasisValue.md) | Optional basis values per investor record, used when the map&#39;s basis is not resolvable from stored data. | [optional] 
**Components** | [**List&lt;AllocationEventComponent&gt;**](AllocationEventComponent.md) | The parts the amount splits into, each shared on its own basis and booked to its own slot. The component amounts must sum to the event amount. Absent means the whole amount is one component: Investment for a CapitalCall, ROC for a Distribution. | [optional] 
**Transfers** | [**List&lt;AllocationEventTransfer&gt;**](AllocationEventTransfer.md) | For a Transfer event, the legs to book: each moves a fraction of one capital interest line to another. Required for a Transfer event and not allowed on any other type. The fractions out of one line must sum to at most one; the amount of a Transfer event is zero. | [optional] 
**Equalisation** | [**AllocationEventEqualisation**](AllocationEventEqualisation.md) |  | [optional] 
**UseOfProceeds** | [**List&lt;AllocationEventUseOfProceeds&gt;**](AllocationEventUseOfProceeds.md) | For a CapitalCall, what the call pays for: rows of purpose, deal and amount that sum to the call amount. An Investment row names a deal the vehicle has funded and is shared under that deal&#39;s participation, with each investor&#39;s share recorded as paid in for that deal; when the deal was funded from a facility the row repays the draw. Not allowed with components or on any other event type. | [optional] 
**DealFunding** | [**AllocationEventDealFunding**](AllocationEventDealFunding.md) |  | [optional] 
**EffectiveAt** | **DateTimeOffset?** | The effective datetime at which the event is created or replaced. Defaults to the earliest effective time on create and the current LUSID system datetime on replace. | [optional] 
**Replaces** | [**ResourceId**](ResourceId.md) |  | [optional] 
**NoticeDate** | **DateTimeOffset?** | The date the notice went to investors. | [optional] 
**DueDate** | **DateTimeOffset?** | The date the investors&#39; cash is due. | [optional] 
**SettlementDate** | **DateTimeOffset?** | The date the postings settle. Defaults to the event date. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
ResourceId allocationMapId = new ResourceId();
string eventType = "eventType";decimal amount = "amount";

string currency = "currency";
string description = "example description";
List<AllocationMapBasisValue> basisValues = new List<AllocationMapBasisValue>();
List<AllocationEventComponent> components = new List<AllocationEventComponent>();
List<AllocationEventTransfer> transfers = new List<AllocationEventTransfer>();
AllocationEventEqualisation? equalisation = new AllocationEventEqualisation();

List<AllocationEventUseOfProceeds> useOfProceeds = new List<AllocationEventUseOfProceeds>();
AllocationEventDealFunding? dealFunding = new AllocationEventDealFunding();

ResourceId? replaces = new ResourceId();


AllocationEventRequest allocationEventRequestInstance = new AllocationEventRequest(
    code: code,
    allocationMapId: allocationMapId,
    eventType: eventType,
    amount: amount,
    currency: currency,
    eventDate: eventDate,
    description: description,
    basisValues: basisValues,
    components: components,
    transfers: transfers,
    equalisation: equalisation,
    useOfProceeds: useOfProceeds,
    dealFunding: dealFunding,
    effectiveAt: effectiveAt,
    replaces: replaces,
    noticeDate: noticeDate,
    dueDate: dueDate,
    settlementDate: settlementDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
