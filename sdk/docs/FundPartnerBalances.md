# Lusid.Sdk.Model.FundPartnerBalances
The capital balances of one register line, in the commitment currency.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Committed** | **decimal** | The committed capital. | 
**UncalledCommitment** | **decimal** | The commitment not yet called. | 
**PaidIn** | **decimal** | The capital paid in. | 
**Returned** | **decimal** | The capital returned. | 
**Recallable** | **decimal** | The returned capital that may be recalled. | 
**Unfunded** | **decimal** | The unfunded capital. | 
**Funded** | **decimal** | The funded capital. | 
**OutstandingCalls** | **decimal?** | Capital called but not yet paid in. Omitted on a register line that has had returned capital marked recallable, since recalled capital is not yet tracked as a balance and the figure would exclude it. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal committed = "committed";
decimal uncalledCommitment = "uncalledCommitment";
decimal paidIn = "paidIn";
decimal returned = "returned";
decimal recallable = "recallable";
decimal unfunded = "unfunded";
decimal funded = "funded";


FundPartnerBalances fundPartnerBalancesInstance = new FundPartnerBalances(
    committed: committed,
    uncalledCommitment: uncalledCommitment,
    paidIn: paidIn,
    returned: returned,
    recallable: recallable,
    unfunded: unfunded,
    funded: funded,
    outstandingCalls: outstandingCalls);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
