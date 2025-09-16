# Lusid.Sdk.Model.InstrumentPaymentDiaryLeg
A leg containing a set of cashflows.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LegIndex** | **int** | Index (integer) for the leg of a payment diary. | [optional] 
**LegId** | **string** | Identifier string for the leg of a payment diary. | [optional] 
**Rows** | [**List&lt;InstrumentPaymentDiaryRow&gt;**](InstrumentPaymentDiaryRow.md) | List of individual cashflows within the payment diary. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string legId = "example legId";
List<InstrumentPaymentDiaryRow> rows = new List<InstrumentPaymentDiaryRow>();

InstrumentPaymentDiaryLeg instrumentPaymentDiaryLegInstance = new InstrumentPaymentDiaryLeg(
    legIndex: legIndex,
    legId: legId,
    rows: rows);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
