# Lusid.Sdk.Model.InterestPaymentEvent
Interest Payment event (INTR). A cash distribution of interest from a debt issuer to its noteholders,  carrying a per-unit absolute interest rate on each CashElection. Supports Mandatory  (single declared election) and MandatoryWithChoices (one election per offered currency) participation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent. | 
**RecordDate** | **DateTimeOffset** | The record-date cut-off determining entitlement. Required. Map from the vendor RecordDate (NOT the  ExDate sentinel). | [optional] 
**PaymentDate** | **DateTimeOffset** | The date the interest is paid to noteholders. Required. Also the effective date of the event. | [optional] 
**ResponseDeadline** | **DateTimeOffset?** | The holder-instruction deadline. Required for MandatoryWithChoices; must be null for Mandatory. | [optional] 
**MarketDeadline** | **DateTimeOffset?** | The market-organisation deadline. Required for MandatoryWithChoices; must be null for Mandatory. | [optional] 
**AnnouncementDate** | **DateTimeOffset?** | The date the event was announced by the issuer. Optional. | [optional] 
**CashElections** | [**List&lt;CashElection&gt;**](CashElection.md) | The cash elections for this event. For Mandatory participation a single declared election is supplied  with IsDeclared, IsDefault and IsChosen all true; for MandatoryWithChoices one entry per offered  currency is supplied, with exactly one declared, one default and one chosen. Every election carries a  per-unit absolute (signed) DividendRate and an ExchangeRate of 1. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<CashElection> cashElections = new List<CashElection>();

InterestPaymentEvent interestPaymentEventInstance = new InterestPaymentEvent(
    recordDate: recordDate,
    paymentDate: paymentDate,
    responseDeadline: responseDeadline,
    marketDeadline: marketDeadline,
    announcementDate: announcementDate,
    cashElections: cashElections);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
