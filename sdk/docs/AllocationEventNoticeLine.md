# Lusid.Sdk.Model.AllocationEventNoticeLine
One line of a notice: an amount allocated to the partner under an ILPA transaction type.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IlpaTransactionType** | **string** | The ILPA transaction type of the line. | 
**Component** | **string** | The allocation event component the line is for. | [optional] 
**InsideFund** | **bool** | Whether the line moves capital inside the fund, as opposed to a fee or expense outside it. | 
**Amount** | **decimal** | The amount of the line. | 
**UnfundedImpact** | **decimal** | The effect of the line on the partner&#39;s unfunded commitment. | 
**RecallableUntil** | **DateTimeOffset?** | The date until which a recallable distribution may be recalled, or null. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string ilpaTransactionType = "ilpaTransactionType";
string component = "example component";
bool insideFund = //"True";decimal amount = "amount";
decimal unfundedImpact = "unfundedImpact";


AllocationEventNoticeLine allocationEventNoticeLineInstance = new AllocationEventNoticeLine(
    ilpaTransactionType: ilpaTransactionType,
    component: component,
    insideFund: insideFund,
    amount: amount,
    unfundedImpact: unfundedImpact,
    recallableUntil: recallableUntil);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
