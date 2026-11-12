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
**OutstandingCalls** | **decimal?** | Capital called but not yet paid in, counting capital that was returned as recallable and has since been recalled. Omitted while a line that has had returned capital marked recallable has not been rebuilt with recalled capital as a balance, since the figure could then miss an unpaid recall. | [optional] 

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
