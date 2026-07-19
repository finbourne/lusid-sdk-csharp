# Lusid.Sdk.Model.WarrantsExerciseEvent
Warrants Exercise (EXWA) — the holder's election to exercise an outstanding warrant, paying the  strike and receiving the underlying security, or to let it lapse at zero proceeds. Elective  (Voluntary / MandatoryWithChoices) on EquityOption (EquityOptionType = Warrant) and SimpleInstrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent. | 
**PaymentDate** | **DateTimeOffset** | The DvP settlement date on which the strike is paid and the underlying is delivered.  Must be on or after PeriodOfActionEnd. | [optional] 
**PeriodOfActionStart** | **DateTimeOffset** | Start of the exercise window. | [optional] 
**PeriodOfActionEnd** | **DateTimeOffset** | End of the exercise window. | [optional] 
**ResponseDeadlineDate** | **DateTimeOffset?** | Holder response deadline. Required when participation is MandatoryWithChoices. | [optional] 
**MarketDeadlineDate** | **DateTimeOffset?** | Market deadline. Required when participation is MandatoryWithChoices. | [optional] 
**EarlyResponseDeadline** | **DateTimeOffset?** | Early response deadline. Optional; populated by some vendor wires. | [optional] 
**StrikePerUnit** | **decimal?** | Cash payable per warrant on exercise. Null-allowed on upsert if the warrant instrument resolves  a non-null EquityOption.Strike (instrument-level fallback applied later). If supplied, must be  strictly positive and accompanied by a StrikeCurrency. | [optional] 
**StrikeCurrency** | **string** | Currency of the strike (ISO 4217 3-letter code). Required if StrikePerUnit is non-null. | [optional] 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | [optional] 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | [optional] 
**FractionDisposition** | **string** | Handling of fractional underlying units. Defaults to round-down (RDDN) in the holdings engine when null.                Supported string (enumeration) values are: [RDDN, CINL]. Available values: RDDN, CINL. | [optional] 
**OptionExerciseElections** | [**List&lt;OptionExerciseElection&gt;**](OptionExerciseElection.md) | Option exercise elections for this event. At least one entry. | [optional] 
**LapseElections** | [**List&lt;LapseElection&gt;**](LapseElection.md) | Lapse elections for this event. Required when participation is MandatoryWithChoices or when the  issuer publishes a no-action default. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string strikeCurrency = "example strikeCurrency";
UnitsRatio? unitsRatio = new UnitsRatio();

NewInstrument? newInstrument = new NewInstrument();

string fractionDisposition = "example fractionDisposition";
List<OptionExerciseElection> optionExerciseElections = new List<OptionExerciseElection>();
List<LapseElection> lapseElections = new List<LapseElection>();

WarrantsExerciseEvent warrantsExerciseEventInstance = new WarrantsExerciseEvent(
    paymentDate: paymentDate,
    periodOfActionStart: periodOfActionStart,
    periodOfActionEnd: periodOfActionEnd,
    responseDeadlineDate: responseDeadlineDate,
    marketDeadlineDate: marketDeadlineDate,
    earlyResponseDeadline: earlyResponseDeadline,
    strikePerUnit: strikePerUnit,
    strikeCurrency: strikeCurrency,
    unitsRatio: unitsRatio,
    newInstrument: newInstrument,
    fractionDisposition: fractionDisposition,
    optionExerciseElections: optionExerciseElections,
    lapseElections: lapseElections);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
