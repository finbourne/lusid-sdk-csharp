# Lusid.Sdk.Model.FlexibleRepoCashFlowEvent
Definition of FlexibleRepoCashFlowEvent which represents a cash transfer as part of a repo contract modelled  as a FlexibleRepo, either as part of the purchase leg or repurchase leg, or any early closure.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. The available values are: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent | 
**SettlementDate** | **DateTimeOffset** | Date that the cash payment settles. This is a required field. | [optional] 
**EntitlementDate** | **DateTimeOffset** | Date the recipient of the cash payment is entitled to receive the cash. This is a required field. | [optional] 
**Currency** | **string** | Currency of the payment. This is a required field. | 
**CashFlowPerUnit** | **decimal?** | Amount of cash to be paid per unit of the instrument.  This amount is signed to indicate direction of the payment, i.e. as part of the purchase leg vs the repurchase leg.  This field is optional. If not specified, the system will not generate a virtual transaction for this event. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "currency";

FlexibleRepoCashFlowEvent flexibleRepoCashFlowEventInstance = new FlexibleRepoCashFlowEvent(
    settlementDate: settlementDate,
    entitlementDate: entitlementDate,
    currency: currency,
    cashFlowPerUnit: cashFlowPerUnit);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
