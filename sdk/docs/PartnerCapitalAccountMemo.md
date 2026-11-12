# Lusid.Sdk.Model.PartnerCapitalAccountMemo
The memo block of a capital account statement: commitment balances from the register at the period end.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Commitment** | **decimal** | The partner&#39;s total commitment. | 
**UncalledCommitment** | **decimal** | The commitment not yet called. | 
**Recallable** | **decimal** | Distributions that the fund may recall. | 
**AvailableCommitment** | **decimal** | The commitment available to call, being uncalled plus recallable. | 
**ContributionsReceivable** | **decimal?** | Called contributions not yet received from the partner, counting capital that was returned as recallable and has since been recalled. Omitted while a register line of the partner that has had returned capital marked recallable has not been rebuilt with recalled capital as a balance, since the figure could then miss an unpaid recall; the declared distributions are then served gross. | [optional] 
**DistributionsDeclaredNotPaid** | **decimal** | Distributions declared to the partner but not yet paid. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal commitment = "commitment";
decimal uncalledCommitment = "uncalledCommitment";
decimal recallable = "recallable";
decimal availableCommitment = "availableCommitment";
decimal distributionsDeclaredNotPaid = "distributionsDeclaredNotPaid";


PartnerCapitalAccountMemo partnerCapitalAccountMemoInstance = new PartnerCapitalAccountMemo(
    commitment: commitment,
    uncalledCommitment: uncalledCommitment,
    recallable: recallable,
    availableCommitment: availableCommitment,
    contributionsReceivable: contributionsReceivable,
    distributionsDeclaredNotPaid: distributionsDeclaredNotPaid);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
