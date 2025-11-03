# Lusid.Sdk.Model.CallOnIntermediateSecuritiesEvent
CallOnIntermediateSecuritiesEvent event (EXRI), representing an exercise on intermediate securities resulting from an intermediate securities distribution.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent | 
**ExpiryDate** | **DateTimeOffset** | The date on which the issue ends. | [optional] 
**PaymentDate** | **DateTimeOffset** | The payment date of the event. | [optional] 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 
**Price** | **decimal** | The price at which new units are purchased. | 
**ExerciseCurrency** | **string** | The currency of the exercise. | 
**OptionExerciseElections** | [**List&lt;OptionExerciseElection&gt;**](OptionExerciseElection.md) | Option exercise election for this event. | [optional] 
**LapseElections** | [**List&lt;LapseElection&gt;**](LapseElection.md) | Lapse election for this event. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

NewInstrument newInstrument = new NewInstrument();
UnitsRatio unitsRatio = new UnitsRatio();decimal price = "price";

string exerciseCurrency = "exerciseCurrency";
List<OptionExerciseElection> optionExerciseElections = new List<OptionExerciseElection>();
List<LapseElection> lapseElections = new List<LapseElection>();

CallOnIntermediateSecuritiesEvent callOnIntermediateSecuritiesEventInstance = new CallOnIntermediateSecuritiesEvent(
    expiryDate: expiryDate,
    paymentDate: paymentDate,
    newInstrument: newInstrument,
    unitsRatio: unitsRatio,
    price: price,
    exerciseCurrency: exerciseCurrency,
    optionExerciseElections: optionExerciseElections,
    lapseElections: lapseElections);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
