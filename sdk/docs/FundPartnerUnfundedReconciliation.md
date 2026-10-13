# Lusid.Sdk.Model.FundPartnerUnfundedReconciliation
The unfunded commitment statement of one partner over a period: the register's opening unfunded, the booked  activity that moves it, the closing unfunded that implies, and the register's own closing unfunded it is checked against.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the statement is for. | 
**FundId** | [**ResourceId**](ResourceId.md) |  | 
**Currency** | **string** | The currency of every amount on the statement, being the commitment currency of the register line. | 
**PeriodFrom** | **DateTimeOffset** | The effective datetime the statement opens at. | 
**PeriodTo** | **DateTimeOffset** | The effective datetime the statement closes at. | 
**OpeningUnfunded** | **decimal** | The unfunded commitment at the opening datetime, from the register. | 
**ContributionsInsideCommitment** | **decimal** | Capital called inside the commitment over the period, which reduces unfunded. Contributions outside the commitment, such as equalisation interest, are listed but do not count here. | 
**RecallableDistributions** | **decimal** | Distributions over the period returned as recallable, which restore unfunded. | 
**ExpiredRecallable** | **decimal** | Recallable distributions whose recall deadline passed in the period without being recalled, which reduce unfunded. | 
**CommitmentChanges** | **decimal** | Changes to the commitment over the period, which move unfunded one for one. | 
**Transfers** | **decimal** | Commitment transferred in or out over the period, which moves unfunded one for one. | 
**ClosingUnfunded** | **decimal** | Opening unfunded less contributions inside the commitment, plus recallable distributions, less expired recallable, plus or minus commitment changes and transfers. | 
**RegisterUnfunded** | **decimal** | The unfunded commitment at the closing datetime, from the register. | 
**Difference** | **decimal** | Closing unfunded less the register&#39;s unfunded at the closing datetime. Zero when the statement ties. | 
**Ties** | **bool** | Whether the closing unfunded equals the register&#39;s unfunded at the closing datetime. | 
**Lines** | [**List&lt;FundPartnerUnfundedReconciliationLine&gt;**](FundPartnerUnfundedReconciliationLine.md) | Every booked allocation to the partner over the period, in event date order, with the ILPA transaction type each is reported under and its effect on unfunded. | 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";
ResourceId fundId = new ResourceId();
string currency = "currency";decimal openingUnfunded = "openingUnfunded";
decimal contributionsInsideCommitment = "contributionsInsideCommitment";
decimal recallableDistributions = "recallableDistributions";
decimal expiredRecallable = "expiredRecallable";
decimal commitmentChanges = "commitmentChanges";
decimal transfers = "transfers";
decimal closingUnfunded = "closingUnfunded";
decimal registerUnfunded = "registerUnfunded";
decimal difference = "difference";

bool ties = //"True";
List<FundPartnerUnfundedReconciliationLine> lines = new List<FundPartnerUnfundedReconciliationLine>();

FundPartnerUnfundedReconciliation fundPartnerUnfundedReconciliationInstance = new FundPartnerUnfundedReconciliation(
    investorRecordId: investorRecordId,
    fundId: fundId,
    currency: currency,
    periodFrom: periodFrom,
    periodTo: periodTo,
    openingUnfunded: openingUnfunded,
    contributionsInsideCommitment: contributionsInsideCommitment,
    recallableDistributions: recallableDistributions,
    expiredRecallable: expiredRecallable,
    commitmentChanges: commitmentChanges,
    transfers: transfers,
    closingUnfunded: closingUnfunded,
    registerUnfunded: registerUnfunded,
    difference: difference,
    ties: ties,
    lines: lines);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
