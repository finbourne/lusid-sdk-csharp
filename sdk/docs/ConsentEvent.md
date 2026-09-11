# Lusid.Sdk.Model.ConsentEvent
Consent Event (CONS) — a voluntary corporate action where an issuer seeks approval  from security holders to amend the terms of an outstanding instrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent. | 
**ConsentType** | **string** | The type of consent solicitation.                Supported string (enumeration) values are: [ChangeInTerms, DueAndPayable]. Available values: ChangeInTerms, DueAndPayable. | 
**RecordDate** | **DateTimeOffset** | The entitlement determination date. | [optional] 
**ResponseDeadline** | **DateTimeOffset** | The last date to submit instructions. | [optional] 
**MarketDeadline** | **DateTimeOffset** | The issuer-set outer deadline. Must be greater than or equal to ResponseDeadline. | [optional] 
**EarlyResponseDeadline** | **DateTimeOffset?** | Deadline for early consent. Required when a CONY-early CashOfferElection is offered.  Must be earlier than ResponseDeadline. | [optional] 
**PaymentDate** | **DateTimeOffset?** | Date on which the consent fee is paid. Required when any CashOfferElection is offered. | [optional] 
**CashOfferElections** | [**List&lt;CashOfferElection&gt;**](CashOfferElection.md) | List of possible cash offer elections for this event. Each tier (CONY-standard, CONY-early)  is modelled as a separate entry; the election carries the per-unit fee rate and currency. | [optional] 
**LapseElections** | [**List&lt;LapseElection&gt;**](LapseElection.md) | List of possible lapse elections for this event (NOAC). | [optional] 
**ConsentGrantedElections** | [**List&lt;ConsentGrantedElection&gt;**](ConsentGrantedElection.md) | List of possible consent-granted elections for this event (CONY), each optionally carrying a consent fee. | [optional] 
**ConsentDeniedElections** | [**List&lt;ConsentDeniedElection&gt;**](ConsentDeniedElection.md) | List of possible consent-denied elections for this event (CONN). | [optional] 
**AbstainElections** | [**List&lt;AbstainElection&gt;**](AbstainElection.md) | List of possible abstain elections for this event (ABST). | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string consentType = "consentType";
List<CashOfferElection> cashOfferElections = new List<CashOfferElection>();
List<LapseElection> lapseElections = new List<LapseElection>();
List<ConsentGrantedElection> consentGrantedElections = new List<ConsentGrantedElection>();
List<ConsentDeniedElection> consentDeniedElections = new List<ConsentDeniedElection>();
List<AbstainElection> abstainElections = new List<AbstainElection>();

ConsentEvent consentEventInstance = new ConsentEvent(
    consentType: consentType,
    recordDate: recordDate,
    responseDeadline: responseDeadline,
    marketDeadline: marketDeadline,
    earlyResponseDeadline: earlyResponseDeadline,
    paymentDate: paymentDate,
    cashOfferElections: cashOfferElections,
    lapseElections: lapseElections,
    consentGrantedElections: consentGrantedElections,
    consentDeniedElections: consentDeniedElections,
    abstainElections: abstainElections);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
