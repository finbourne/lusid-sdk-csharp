# Lusid.Sdk.Model.LoanPeriod

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PaymentDate** | **DateTimeOffset** |  | 
**Notional** | **decimal** |  | 
**InterestAmount** | **decimal** |  | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal notional = "notional";
decimal interestAmount = "interestAmount";


LoanPeriod loanPeriodInstance = new LoanPeriod(
    paymentDate: paymentDate,
    notional: notional,
    interestAmount: interestAmount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
