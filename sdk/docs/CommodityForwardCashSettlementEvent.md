# Lusid.Sdk.Model.CommodityForwardCashSettlementEvent
Cash settlement of a cash-delivery CommodityForward at maturity. The cash flow per unit is the  pre-netted settlement price (forward price minus strike) supplied externally via the quote store;  LUSID does not compute the difference itself. A negative cash flow per unit is valid and means the  position was out of the money at settlement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent. | 
**MaturityDate** | **DateTimeOffset** | The single settlement / maturity date of the forward. Required. | [optional] 
**DomCcy** | **string** | Settlement currency of the forward. Required. | 
**CashFlowPerUnit** | **decimal?** | The pre-netted settlement amount per unit (current forward price minus strike), supplied  externally via the quote store. Optional — absent until the settlement price has been loaded.  Negative when the position is out of the money. | [optional] 
**CashFlowAmount** | **decimal?** | The realised cash amount, calculated as CashFlowPerUnit multiplied by the eligible balance.  Optional — it needs holdings-level data so it is never populated by the instrument layer.  Carries the sign of CashFlowPerUnit. | [optional] 
**Strike** | **decimal?** | Agreed forward price at trade inception. Optional, and reference only — it is not used in the  settlement calculation; it is carried for auditability. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";

CommodityForwardCashSettlementEvent commodityForwardCashSettlementEventInstance = new CommodityForwardCashSettlementEvent(
    maturityDate: maturityDate,
    domCcy: domCcy,
    cashFlowPerUnit: cashFlowPerUnit,
    cashFlowAmount: cashFlowAmount,
    strike: strike);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
