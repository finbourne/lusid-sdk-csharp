# Lusid.Sdk.Model.TotalReturnSwapCashFlowEvent
A scheduled exchange of a TotalReturnSwap: a funding-leg coupon or notional exchange, an asset income or  principal passed through on the asset leg, or a price-return reset of the asset leg. Component says  which. The amount is per unit of the swap as its cash flows are booked, signed negative when paid; it is  absent until the market data determining it has been published.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent. | 
**ExDate** | **DateTimeOffset** | The date the holding must be held on to be entitled to the flow. Required. | [optional] 
**PaymentDate** | **DateTimeOffset** | The date the flow pays. Required. | [optional] 
**Currency** | **string** | The currency the flow pays in. Required. | 
**Component** | **string** | Which exchange of the swap the flow settles. Required.                Supported string (enumeration) values are: [FundingPayment, FundingNotional, AssetIncome, AssetPrincipal, PriceReturn]. | 
**FlowType** | **string** | The type of the underlying cash flow the event settles. A component can gather several flow types  paying on one date (an asset-backed bond&#39;s coupon, interest deferral and interest shortfall are all  asset income), so the flow type is what tells them apart. Required.                Supported string (enumeration) values are: [Coupon, Notional, Premium, Principal, Protection, Cash, Dividend, Interest, PrincipalWriteOff, InterestDeferred, InterestShortfall, MarkToMarket, InterestInKind]. | 
**LegIdentifier** | **string** | The leg the flow belongs to. Required.                Supported string (enumeration) values are: [AssetLeg, FundingLeg]. | 
**PayReceive** | **string** | Whether the flow is paid or received from the holder&#39;s perspective. The amount is already signed  accordingly; this attributes an undetermined flow to its side. Required.                Supported string (enumeration) values are: [Pay, Receive]. | 
**CashFlowPerUnit** | **decimal?** | The signed amount per unit of the swap held on the ex date, negative when paid. Optional — absent  until determinable: a price-return reset needs its reset quotes, a floating funding payment its fixing. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "currency";
string component = "component";
string flowType = "flowType";
string legIdentifier = "legIdentifier";
string payReceive = "payReceive";

TotalReturnSwapCashFlowEvent totalReturnSwapCashFlowEventInstance = new TotalReturnSwapCashFlowEvent(
    exDate: exDate,
    paymentDate: paymentDate,
    currency: currency,
    component: component,
    flowType: flowType,
    legIdentifier: legIdentifier,
    payReceive: payReceive,
    cashFlowPerUnit: cashFlowPerUnit);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
