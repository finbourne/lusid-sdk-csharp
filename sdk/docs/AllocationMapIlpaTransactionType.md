# Lusid.Sdk.Model.AllocationMapIlpaTransactionType
The ILPA transaction type an Allocation Map reports one kind of allocation event under, overriding the default.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EventType** | **string** | The kind of allocation event the ILPA transaction type applies to: CapitalCall, Distribution, FeeExpense, ValuationMove, Equalisation, RecallExpiry, Transfer, Default or Commitment. Available values: CapitalCall, Distribution, FeeExpense, ValuationMove, Commitment, Equalisation, RecallExpiry, Transfer, Default, DealFunding. | 
**IlpaTransactionType** | **string** | The ILPA transaction type events of this kind are reported under, for example &#39;Capital Call: Investments&#39; or &#39;Distribution: Recallable&#39;. Must be a value of the system IlpaTransactionType data type. | 
**Component** | **string** | The component of the event the ILPA transaction type applies to, for example MgmtFee or ROC. Absent means the entry is the default for every component of the event type without an entry of its own. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string eventType = "eventType";
string ilpaTransactionType = "ilpaTransactionType";
string component = "example component";

AllocationMapIlpaTransactionType allocationMapIlpaTransactionTypeInstance = new AllocationMapIlpaTransactionType(
    eventType: eventType,
    ilpaTransactionType: ilpaTransactionType,
    component: component);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
