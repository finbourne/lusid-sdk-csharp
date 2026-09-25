# Lusid.Sdk.Model.ExchangeOfferEvent
Exchange Offer Event (EXOF).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent. | 
**EffectiveDate** | **DateTimeOffset** |  | [optional] 
**SettlementDate** | **DateTimeOffset** |  | [optional] 
**EventSource** | **string** |  | 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | [optional] 
**CashOfferElections** | [**List&lt;CashOfferElection&gt;**](CashOfferElection.md) | List of possible CashOfferElections for this exchange offer event (CASH).    - The event requires at least one election of any type.    - If ParticipationType is Mandatory, CashOfferElection is not permitted.    - If ParticipationType is MandatoryWithChoices or Voluntary, at most one CashOfferElection may be supplied.    - Exactly one election on the event must be the default, and at most one may be chosen. | [optional] 
**SecurityOfferElections** | [**List&lt;SecurityOfferElection&gt;**](SecurityOfferElection.md) | List of possible SecurityOfferElections for this exchange offer event (SECU).    - The event requires at least one election of any type.    - Any number of SecurityOfferElections may be supplied.    - A NewInstrument is required on the event when this list is non-empty.    - Exactly one election on the event must be the default, and at most one may be chosen.    - If ParticipationType is Mandatory, the event must carry exactly one election in total; if MandatoryWithChoices, at least two. | [optional] 
**MixedLotConstituentsElections** | [**List&lt;MixedLotConstituentsElection&gt;**](MixedLotConstituentsElection.md) | List of possible MixedLotConstituentsElections for this exchange offer event.    - The event requires at least one election of any type.    - Any number of MixedLotConstituentsElections may be supplied, up to a limit of 100 entries.    - Exactly one election on the event must be the default, and at most one may be chosen.    - If ParticipationType is Mandatory, the event must carry exactly one election in total; if MandatoryWithChoices, at least two. | [optional] 
**LapseElections** | [**List&lt;LapseElection&gt;**](LapseElection.md) | List of possible LapseElections for this exchange offer event (NOAC).    - The event requires at least one election of any type.    - If ParticipationType is Mandatory, LapseElection is not permitted.    - If ParticipationType is MandatoryWithChoices, any number of LapseElections may be supplied, but none of them may be the default.    - If ParticipationType is Voluntary, at most one LapseElection may be supplied. | [optional] 
**CashAndSecurityOfferElections** | [**List&lt;CashAndSecurityOfferElection&gt;**](CashAndSecurityOfferElection.md) | List of possible CashAndSecurityOfferElections for this exchange offer event (CASE).    - The event requires at least one election of any type.    - Any number of CashAndSecurityOfferElections may be supplied.    - Exactly one election on the event must be the default, and at most one may be chosen.    - If ParticipationType is Mandatory, the event must carry exactly one election in total; if MandatoryWithChoices, at least two. | [optional] 
**ConsentAndExchangeElections** | [**List&lt;ConsentAndExchangeElection&gt;**](ConsentAndExchangeElection.md) | List of possible ConsentAndExchangeElections for this exchange offer event (CEXC).    - The event requires at least one election of any type.    - Any number of ConsentAndExchangeElections may be supplied.    - Exactly one election on the event must be the default, and at most one may be chosen.    - If ParticipationType is Mandatory, the event must carry exactly one election in total; if MandatoryWithChoices, at least two. | [optional] 
**AbstainElections** | [**List&lt;AbstainElection&gt;**](AbstainElection.md) | List of possible AbstainElections for this exchange offer event (ABST).    - The event requires at least one election of any type.    - Any number of AbstainElections may be supplied.    - Exactly one election on the event must be the default, and at most one may be chosen.    - If ParticipationType is Mandatory, the event must carry exactly one election in total; if MandatoryWithChoices, at least two. | [optional] 
**UnknownProceedsElections** | [**List&lt;UnknownProceedsElection&gt;**](UnknownProceedsElection.md) | List of possible UnknownProceedsElections for this exchange offer event (UNKNOWN).    - The event requires at least one election of any type.    - Any number of UnknownProceedsElections may be supplied.    - Exactly one election on the event must be the default, and at most one may be chosen.    - If ParticipationType is Mandatory, the event must carry exactly one election in total; if MandatoryWithChoices, at least two. | [optional] 
**MinPieceSize** | **decimal?** |  | [optional] 
**MinIncrement** | **decimal?** |  | [optional] 
**FractionalUnitsCashPrice** | **decimal?** |  | [optional] 
**FractionalUnitsCashCurrency** | **string** |  | [optional] 
**FractionalUnitsRoundingConvention** | **string** | The convention used to round the fractional units entitlement. Defaults to Floor. Available values: Floor, Ceiling, RoundHalfUp, RoundHalfDown, RoundToDecimalPlaces, BuyUp, BankerRounding. | [optional] 
**FractionalUnitsDecimalPlaces** | **int?** | The number of decimal places to round to when FractionalUnitsRoundingConvention is RoundToDecimalPlaces. | [optional] 
**InstructionReference** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string eventSource = "eventSource";
NewInstrument? newInstrument = new NewInstrument();

List<CashOfferElection> cashOfferElections = new List<CashOfferElection>();
List<SecurityOfferElection> securityOfferElections = new List<SecurityOfferElection>();
List<MixedLotConstituentsElection> mixedLotConstituentsElections = new List<MixedLotConstituentsElection>();
List<LapseElection> lapseElections = new List<LapseElection>();
List<CashAndSecurityOfferElection> cashAndSecurityOfferElections = new List<CashAndSecurityOfferElection>();
List<ConsentAndExchangeElection> consentAndExchangeElections = new List<ConsentAndExchangeElection>();
List<AbstainElection> abstainElections = new List<AbstainElection>();
List<UnknownProceedsElection> unknownProceedsElections = new List<UnknownProceedsElection>();
string fractionalUnitsCashCurrency = "example fractionalUnitsCashCurrency";
string fractionalUnitsRoundingConvention = "example fractionalUnitsRoundingConvention";
string instructionReference = "example instructionReference";

ExchangeOfferEvent exchangeOfferEventInstance = new ExchangeOfferEvent(
    effectiveDate: effectiveDate,
    settlementDate: settlementDate,
    eventSource: eventSource,
    newInstrument: newInstrument,
    cashOfferElections: cashOfferElections,
    securityOfferElections: securityOfferElections,
    mixedLotConstituentsElections: mixedLotConstituentsElections,
    lapseElections: lapseElections,
    cashAndSecurityOfferElections: cashAndSecurityOfferElections,
    consentAndExchangeElections: consentAndExchangeElections,
    abstainElections: abstainElections,
    unknownProceedsElections: unknownProceedsElections,
    minPieceSize: minPieceSize,
    minIncrement: minIncrement,
    fractionalUnitsCashPrice: fractionalUnitsCashPrice,
    fractionalUnitsCashCurrency: fractionalUnitsCashCurrency,
    fractionalUnitsRoundingConvention: fractionalUnitsRoundingConvention,
    fractionalUnitsDecimalPlaces: fractionalUnitsDecimalPlaces,
    instructionReference: instructionReference);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
