# Lusid.Sdk.Model.ChangeEvent
Change event (CHAN) — a reorganisation in which an instrument's certificates, name, or  terms are changed. Holders of record on the record date have their positions converted  automatically to the new instrument at a fixed 1:1 ratio on the payment date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent. | 
**RecordDate** | **DateTimeOffset** | The record date — the eligibility cutoff. Holders of record on this date enter the  change. | [optional] 
**PaymentDate** | **DateTimeOffset** | The payment date — the date the change fires and the paired StockMovement  transactions land. | [optional] 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 
**ChangeType** | **string** | The nature of the change — one of \&quot;Certificates\&quot;, \&quot;Name\&quot;, or \&quot;Terms\&quot;. Available values: Certificates, Name, Terms. | 
**TermTarget** | **string** | The target of a terms change — one of \&quot;InstrumentDefinitionField\&quot; or  \&quot;InstrumentProperty\&quot;. Only applicable when ChangeType is \&quot;Terms\&quot;. Available values: InstrumentDefinitionField, InstrumentProperty. | [optional] 
**TermTargetIdentifier** | **string** | The identifier of the term target being changed. Must be paired with TermTarget. | [optional] 
**AdditionalInformation** | **string** | Free-text additional information describing the change. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

NewInstrument newInstrument = new NewInstrument();
UnitsRatio unitsRatio = new UnitsRatio();
string changeType = "changeType";
string termTarget = "example termTarget";
string termTargetIdentifier = "example termTargetIdentifier";
string additionalInformation = "example additionalInformation";

ChangeEvent changeEventInstance = new ChangeEvent(
    recordDate: recordDate,
    paymentDate: paymentDate,
    newInstrument: newInstrument,
    unitsRatio: unitsRatio,
    changeType: changeType,
    termTarget: termTarget,
    termTargetIdentifier: termTargetIdentifier,
    additionalInformation: additionalInformation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
