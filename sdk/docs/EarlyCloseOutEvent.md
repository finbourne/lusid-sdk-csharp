# Lusid.Sdk.Model.EarlyCloseOutEvent
Early close out event - Ending an OTC instrument early.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent | 
**CloseOutAmount** | **decimal** | The amount to be closed out early. Required. Must be strictly positive. | 
**CloseOutCcy** | **string** | The currency corresponding to the amount to be closed out early. Required. | 
**CloseOutToOtherRate** | **decimal?** | The rate between close out amount and other amount. Optional. If provided, must be strictly positive. | [optional] 
**EffectiveDate** | **DateTimeOffset** | The date of the event. | [optional] 
**OtherAmount** | **decimal?** | The other amount to be closed out early. Optional. If provided, must be strictly positive. | [optional] 
**OtherCcy** | **string** | The currency corresponding to the other amount to be closed out early. Optional. | [optional] 
**OtherToCloseOutRate** | **decimal?** | The rate between other amount and close out amount. Optional. If provided, must be strictly positive. | [optional] 
**SettlementCcy** | **string** | The settlement currency. Required. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal closeOutAmount = "closeOutAmount";

string closeOutCcy = "closeOutCcy";
string otherCcy = "example otherCcy";
string settlementCcy = "settlementCcy";

EarlyCloseOutEvent earlyCloseOutEventInstance = new EarlyCloseOutEvent(
    closeOutAmount: closeOutAmount,
    closeOutCcy: closeOutCcy,
    closeOutToOtherRate: closeOutToOtherRate,
    effectiveDate: effectiveDate,
    otherAmount: otherAmount,
    otherCcy: otherCcy,
    otherToCloseOutRate: otherToCloseOutRate,
    settlementCcy: settlementCcy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
