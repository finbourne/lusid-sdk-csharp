# Lusid.Sdk.Model.MarginCall
A margin call a run produced under a collateral agreement: our figure, the counterparty's demand once recorded  and how they compare, and where the call is in its lifecycle.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The URI of this margin call. | [optional] 
**Id** | **string** | The identifier of the call: the run id and the call&#39;s business key joined with &#39;/&#39;. | 
**RunId** | **string** | The run that produced the call. Filterable. | 
**AgreementId** | [**ResourceId**](ResourceId.md) |  | 
**Counterparty** | [**CounterpartyIdentifier**](CounterpartyIdentifier.md) |  | [optional] 
**Item** | **string** | The margin item of the agreement the call is for. Filterable. | 
**MarginType** | **string** | The type of margin called. Currently VariationMargin. Filterable. | 
**Method** | **string** | The calculation method of the margin item. | [optional] 
**Settlement** | **string** | Whether the item is settled or collateralised. | [optional] 
**Direction** | **string** | Who posts: WePost, TheyPost or None when the exposure is flat. Filterable. | 
**Currency** | **string** | The currency of the call, the agreement&#39;s base currency. Filterable. | 
**Required** | **decimal** | The margin required under the agreement, signed as the call. | 
**Held** | **decimal** | The collateral already held against the item, signed as the call. | 
**Call** | **decimal** | Our figure for the amount to move: required less held. Filterable. | 
**MatchTolerance** | **decimal?** | The agreement&#39;s match tolerance captured on the call. | [optional] 
**CounterpartyDemand** | **decimal?** | The counterparty&#39;s figure for the call, once recorded. | [optional] 
**Difference** | **decimal?** | The counterparty&#39;s demand less our call, once recorded. | [optional] 
**MatchStatus** | **string** | How the counterparty&#39;s demand compares to our call. One of Unmatched, Matched, WithinTolerance, Break or NotRequired. Filterable. | 
**DemandReceivedAt** | **DateTimeOffset?** | When the counterparty&#39;s demand was received. | [optional] 
**StatementReference** | **string** | A reference to the counterparty&#39;s statement, such as a Drive path. | [optional] 
**DemandNote** | **string** | A note recorded with the counterparty&#39;s demand. | [optional] 
**AgreedAmount** | **decimal?** | The amount agreed to move, once the call is accepted or disputed. | [optional] 
**DisputedAmount** | **decimal?** | The part of the counterparty&#39;s demand left in dispute. | [optional] 
**DisputeReason** | **string** | Why the call is disputed. | [optional] 
**DisputeOwner** | **string** | Who owns the dispute. | [optional] 
**State** | **string** | Where the call is in its lifecycle. One of Calculated, Accepted or Disputed. Filterable. | 
**Deadline** | **DateTimeOffset?** | The time the call must be agreed by. Empty until agreements carry a notification time. | [optional] 
**Supersedes** | [**MarginCallReference**](MarginCallReference.md) |  | [optional] 
**CarriedFrom** | [**MarginCallReference**](MarginCallReference.md) |  | [optional] 
**CarriedDisputedAmount** | **decimal?** | The amount left in dispute on the carried call. Informational; not added to this call. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string id = "id";
string runId = "runId";
ResourceId agreementId = new ResourceId();
CounterpartyIdentifier? counterparty = new CounterpartyIdentifier();

string item = "item";
string marginType = "marginType";
string method = "example method";
string settlement = "example settlement";
string direction = "direction";
string currency = "currency";decimal required = "required";
decimal held = "held";
decimal call = "call";

string matchStatus = "matchStatus";
string statementReference = "example statementReference";
string demandNote = "example demandNote";
string disputeReason = "example disputeReason";
string disputeOwner = "example disputeOwner";
string state = "state";
MarginCallReference? supersedes = new MarginCallReference();

MarginCallReference? carriedFrom = new MarginCallReference();


MarginCall marginCallInstance = new MarginCall(
    href: href,
    id: id,
    runId: runId,
    agreementId: agreementId,
    counterparty: counterparty,
    item: item,
    marginType: marginType,
    method: method,
    settlement: settlement,
    direction: direction,
    currency: currency,
    required: required,
    held: held,
    call: call,
    matchTolerance: matchTolerance,
    counterpartyDemand: counterpartyDemand,
    difference: difference,
    matchStatus: matchStatus,
    demandReceivedAt: demandReceivedAt,
    statementReference: statementReference,
    demandNote: demandNote,
    agreedAmount: agreedAmount,
    disputedAmount: disputedAmount,
    disputeReason: disputeReason,
    disputeOwner: disputeOwner,
    state: state,
    deadline: deadline,
    supersedes: supersedes,
    carriedFrom: carriedFrom,
    carriedDisputedAmount: carriedDisputedAmount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
