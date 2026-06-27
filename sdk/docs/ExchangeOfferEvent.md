# Lusid.Sdk.Model.ExchangeOfferEvent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent. | 
**EffectiveDate** | **DateTimeOffset** |  | [optional] 
**SettlementDate** | **DateTimeOffset** |  | [optional] 
**EventSource** | **string** |  | 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | [optional] 
**CashOfferElections** | [**List&lt;CashOfferElection&gt;**](CashOfferElection.md) |  | [optional] 
**SecurityOfferElections** | [**List&lt;SecurityOfferElection&gt;**](SecurityOfferElection.md) |  | [optional] 
**MixedLotConstituentsElections** | [**List&lt;MixedLotConstituentsElection&gt;**](MixedLotConstituentsElection.md) |  | [optional] 
**LapseElections** | [**List&lt;LapseElection&gt;**](LapseElection.md) |  | [optional] 
**MinPieceSize** | **decimal?** |  | [optional] 
**MinIncrement** | **decimal?** |  | [optional] 
**FractionalUnitsCashPrice** | **decimal?** |  | [optional] 
**FractionalUnitsCashCurrency** | **string** |  | [optional] 
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
string fractionalUnitsCashCurrency = "example fractionalUnitsCashCurrency";
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
    minPieceSize: minPieceSize,
    minIncrement: minIncrement,
    fractionalUnitsCashPrice: fractionalUnitsCashPrice,
    fractionalUnitsCashCurrency: fractionalUnitsCashCurrency,
    instructionReference: instructionReference);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
