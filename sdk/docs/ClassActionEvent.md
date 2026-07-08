# Lusid.Sdk.Model.ClassActionEvent
Class Action Event (CLSA) — a voluntary corporate action under which security holders  receive cash compensation from a court-approved settlement fund following litigation  against an issuer.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent. | 
**PaymentDate** | **DateTimeOffset** | Date on which the settlement distribution is paid to the holder. | [optional] 
**FilingDeadline** | **DateTimeOffset** | Court-set deadline for submitting a proof of claim. | [optional] 
**ClassPeriodStart** | **DateTimeOffset** | Lower bound of the eligibility window (inclusive). | [optional] 
**ClassPeriodEnd** | **DateTimeOffset** | Upper bound of the eligibility window (inclusive). | [optional] 
**ExDate** | **DateTimeOffset?** | Date from which the security trades without the settlement right.  Null for most class actions where no ex date is defined. | [optional] 
**RecordDate** | **DateTimeOffset?** | Date at which positions are struck for notification scope. Informational only. | [optional] 
**AnnouncementDate** | **DateTimeOffset?** | Settlement public-announcement or court-approval date. | [optional] 
**CaseReference** | **string** | Lawsuit or settlement-fund identifier (court case number, fund name). Audit-only. | [optional] 
**CashOfferElections** | [**List&lt;CashOfferElection&gt;**](CashOfferElection.md) | Cash offer elections for this event. Exactly one entry carrying the per-share  settlement amount as CashOfferPrice and settlement currency as CashOfferCurrency. | [optional] 
**LapseElections** | [**List&lt;LapseElection&gt;**](LapseElection.md) | Lapse elections for this event. Exactly one entry (NOAC) with IsDefault &#x3D; true. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string caseReference = "example caseReference";
List<CashOfferElection> cashOfferElections = new List<CashOfferElection>();
List<LapseElection> lapseElections = new List<LapseElection>();

ClassActionEvent classActionEventInstance = new ClassActionEvent(
    paymentDate: paymentDate,
    filingDeadline: filingDeadline,
    classPeriodStart: classPeriodStart,
    classPeriodEnd: classPeriodEnd,
    exDate: exDate,
    recordDate: recordDate,
    announcementDate: announcementDate,
    caseReference: caseReference,
    cashOfferElections: cashOfferElections,
    lapseElections: lapseElections);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
