# Lusid.Sdk.Model.PartnerPerformanceCashFlow
One dated cash flow the net IRR was solved from, signed from the partner's point of view.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTimeOffset** | The date of the cash flow. | 
**Amount** | **decimal** | The amount of the cash flow, negative for contributions and positive for distributions and the residual value. | 
**Kind** | **string** | The kind of cash flow: Contribution, Distribution or ResidualValue. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal amount = "amount";

string kind = "kind";

PartnerPerformanceCashFlow partnerPerformanceCashFlowInstance = new PartnerPerformanceCashFlow(
    date: date,
    amount: amount,
    kind: kind);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
