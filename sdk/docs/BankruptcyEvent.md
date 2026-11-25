# Lusid.Sdk.Model.BankruptcyEvent
A Bankruptcy (BRUP) event recording the legal status of a company unable to meet its financial  obligations. With no elections it is a pure informational marker, generating no transactions and  having no position impact. It may also carry a ballot: one CashOfferElection per option that pays  cash, one LapseElection per option that pays nothing, and one MixedLotConstituentsElection per option that  delivers new securities, cash, or both and removes the original position.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent, GlobalLoanFacilityReinitialisationEvent, InvestorLoanFacilityReinitialisationEvent, CapitalCallReceiptEvent, RecallableCapitalExpiryEvent, CapitalInterestTransferEvent, FacilityDrawEvent, FacilityRepaymentEvent, FacilityInterestEvent, FacilityCommitmentFeeEvent, InstalmentCallEvent, DepositInterestCapitalisationEvent, PartialRedemptionWithoutReductionOfNominalValueEvent, StripBondCashflowEvent, CapitalisationEvent, SharesPremiumDividendEvent, CashDistributionFromNonEligibleSecuritiesSalesEvent, InflationIndexationEvent, InterestPaymentWithPrincipalEvent, IncreaseInValueEvent. | 
**EffectiveDate** | **DateTimeOffset** | Date of the bankruptcy filing or court ruling. | [optional] 
**NotificationType** | **string** | Notification type: NEWM (new announcement), REPL (replacement/correction), or CANC (proceedings dismissed). Available values: NEWM, REPL, CANC. | 
**ClaimFilingDeadline** | **DateTimeOffset?** | Date by which creditors must file a proof of claim. Optional — null when not applicable.  If provided, overrides EffectiveDate as the settle date of the resulting virtual transactions. | [optional] 
**Narrative** | **string** | Free-text detail: court, jurisdiction, trustee, plan reference. Optional. | [optional] 
**PaymentDate** | **DateTimeOffset?** | Settlement date of the cash leg. Required when a CashOfferElection is offered, and accepted  but unused otherwise — inbound ballot notifications populate a pay date on pure votes that  settle no cash. | [optional] 
**CashOfferElections** | [**List&lt;CashOfferElection&gt;**](CashOfferElection.md) | One election per ballot option that pays cash, keyed \&quot;{OptionNumber}-{OptionCode}\&quot;, for  example \&quot;1-CASH\&quot;. Each election&#39;s CashOfferPrice is per eligible unit, not per 1000 of face.  Defaults to an empty list. | [optional] 
**LapseElections** | [**List&lt;LapseElection&gt;**](LapseElection.md) | One election per ballot option that pays nothing — consent granted with no fee, consent  denied, abstain, or no action — keyed \&quot;{OptionNumber}-{OptionCode}\&quot;, for example \&quot;6-NOAC\&quot;.  Keys are free-form because a real ballot carries CONY twice and CONN twice. Defaults to an  empty list. | [optional] 
**MixedLotConstituentsElections** | [**List&lt;MixedLotConstituentsElection&gt;**](MixedLotConstituentsElection.md) | List of possible mixed lot options for this event, if any. Each election removes the original position  and delivers one or more distinct new securities and/or cash legs of its own, each with its own  settlement date. The event has no event-level NewInstrument: every security constituent carries its own.  Defaults to an empty list. | [optional] 
**FractionalUnitsCashPrice** | **decimal?** | The cash price paid in lieu of fractional units. | [optional] 
**FractionalUnitsCashCurrency** | **string** | The currency of the cash paid in lieu of fractional units. | [optional] 
**FractionalUnitsRoundingConvention** | **string** | The convention used to round the fractional units entitlement. Defaults to Floor. BuyUp is not supported. Available values: Floor, Ceiling, RoundHalfUp, RoundHalfDown, RoundToDecimalPlaces, BuyUp, BankerRounding. | [optional] 
**FractionalUnitsDecimalPlaces** | **int?** | The number of decimal places to round to when FractionalUnitsRoundingConvention is RoundToDecimalPlaces. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string notificationType = "notificationType";
string narrative = "example narrative";
List<CashOfferElection> cashOfferElections = new List<CashOfferElection>();
List<LapseElection> lapseElections = new List<LapseElection>();
List<MixedLotConstituentsElection> mixedLotConstituentsElections = new List<MixedLotConstituentsElection>();
string fractionalUnitsCashCurrency = "example fractionalUnitsCashCurrency";
string fractionalUnitsRoundingConvention = "example fractionalUnitsRoundingConvention";

BankruptcyEvent bankruptcyEventInstance = new BankruptcyEvent(
    effectiveDate: effectiveDate,
    notificationType: notificationType,
    claimFilingDeadline: claimFilingDeadline,
    narrative: narrative,
    paymentDate: paymentDate,
    cashOfferElections: cashOfferElections,
    lapseElections: lapseElections,
    mixedLotConstituentsElections: mixedLotConstituentsElections,
    fractionalUnitsCashPrice: fractionalUnitsCashPrice,
    fractionalUnitsCashCurrency: fractionalUnitsCashCurrency,
    fractionalUnitsRoundingConvention: fractionalUnitsRoundingConvention,
    fractionalUnitsDecimalPlaces: fractionalUnitsDecimalPlaces);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
