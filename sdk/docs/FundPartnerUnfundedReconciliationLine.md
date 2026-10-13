# Lusid.Sdk.Model.FundPartnerUnfundedReconciliationLine
One booked allocation to the partner on the unfunded commitment statement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllocationEventId** | [**ResourceId**](ResourceId.md) |  | 
**EventDate** | **DateTimeOffset** | The event date of the allocation. | 
**EventType** | **string** | The kind of allocation event: CapitalCall, Distribution, FeeExpense, ValuationMove, Equalisation, RecallExpiry, Transfer, Default or Commitment. | 
**Component** | **string** | The component of the event the amount belongs to, for example Investment, MgmtFee or ROC. | [optional] 
**IlpaTransactionType** | **string** | The ILPA transaction type the line is reported under, from the map&#39;s override or the default for the event type and component. | 
**InsideFund** | **bool** | Whether the flow is inside the fund&#39;s commitment. False for flows outside it, such as equalisation interest or late payment interest, which do not move unfunded. | 
**Amount** | **decimal** | The amount allocated to the partner, in the statement currency. | 
**UnfundedImpact** | **decimal** | The effect of the line on unfunded commitment: negative for a call inside the commitment or an expired recallable, positive for a recallable distribution, and the signed amount for a commitment change or transfer. Zero for a flow that does not move unfunded. | 
**RecallableUntil** | **DateTimeOffset?** | For a recallable distribution, the last date it may be recalled. Absent when there is no deadline or the line is not recallable. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId allocationEventId = new ResourceId();
string eventType = "eventType";
string component = "example component";
string ilpaTransactionType = "ilpaTransactionType";
bool insideFund = //"True";decimal amount = "amount";
decimal unfundedImpact = "unfundedImpact";


FundPartnerUnfundedReconciliationLine fundPartnerUnfundedReconciliationLineInstance = new FundPartnerUnfundedReconciliationLine(
    allocationEventId: allocationEventId,
    eventDate: eventDate,
    eventType: eventType,
    component: component,
    ilpaTransactionType: ilpaTransactionType,
    insideFund: insideFund,
    amount: amount,
    unfundedImpact: unfundedImpact,
    recallableUntil: recallableUntil);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
