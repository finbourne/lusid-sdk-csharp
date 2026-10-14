# Lusid.Sdk.Model.PartyTerms
What one party posts under a margin item.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Threshold** | **decimal?** | The exposure that is tolerated before margin is called. Empty means no threshold. | [optional] 
**IndependentAmount** | **decimal** | The independent amount posted in addition to variation margin. | 
**CashInterest** | [**CashInterest**](CashInterest.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal independentAmount = "independentAmount";

CashInterest? cashInterest = new CashInterest();


PartyTerms partyTermsInstance = new PartyTerms(
    threshold: threshold,
    independentAmount: independentAmount,
    cashInterest: cashInterest);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
