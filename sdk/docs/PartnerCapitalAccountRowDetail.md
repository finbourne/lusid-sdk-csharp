# Lusid.Sdk.Model.PartnerCapitalAccountRowDetail
One labelled part of a capital account row's total: the kind of amount, the allocation event it arose on and its  quarter-, year- and inception-to-date amounts, each already included in the row's own column.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** | The kind of amount the entry labels: WithholdingTax for tax withheld from a distribution on the partner&#39;s behalf. | 
**AllocationEventId** | [**ResourceId**](ResourceId.md) |  | 
**EventDate** | **DateTimeOffset** | The effective date of the allocation event the amount arose on. | 
**Qtd** | **decimal** | The part of the row&#39;s quarter-to-date amount the entry labels; zero when the event falls outside the quarter. | 
**Ytd** | **decimal** | The part of the row&#39;s year-to-date amount the entry labels; zero when the event falls outside the year. | 
**Itd** | **decimal** | The part of the row&#39;s inception-to-date amount the entry labels. | 

```csharp
using Lusid.Sdk.Model;
using System;

string kind = "kind";
ResourceId allocationEventId = new ResourceId();decimal qtd = "qtd";
decimal ytd = "ytd";
decimal itd = "itd";


PartnerCapitalAccountRowDetail partnerCapitalAccountRowDetailInstance = new PartnerCapitalAccountRowDetail(
    kind: kind,
    allocationEventId: allocationEventId,
    eventDate: eventDate,
    qtd: qtd,
    ytd: ytd,
    itd: itd);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
