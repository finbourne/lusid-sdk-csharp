# Lusid.Sdk.Model.BondOptionTerminationEvent
Bond option termination — the underlying bond of a BondOption was redeemed early (called), which  terminates the option and settles its residual intrinsic value against the price the underlying was  actually called at. Posted against the option's own instrument by the feed or orchestration layer:  LUSID does not derive it from the underlying's own EarlyRedemptionEvent, because the corporate action  dependency graph is self-keyed by LUID.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent. | 
**TerminationDate** | **DateTimeOffset** | The date the option terminates, being the effective date of the underlying bond&#39;s early redemption. | [optional] 
**CallPrice** | **decimal** | The price the underlying bond was actually redeemed at, as a percentage of par. Must be supplied:  it comes from the underlying&#39;s own redemption and cannot be inferred from the option. | 
**SettlementCurrency** | **string** | The currency the residual settlement is paid in, being the option&#39;s domestic currency. | 
**DomCcy** | **string** | The domestic currency of the option. | 
**SettlementAmountPerUnit** | **decimal?** | The residual intrinsic value settled per contract. Computed by LUSID from the call price and the  option&#39;s strike and contract size, so it is not supplied on the request; zero is a legitimate value  when the option terminates worthless. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal callPrice = "callPrice";

string settlementCurrency = "settlementCurrency";
string domCcy = "domCcy";

BondOptionTerminationEvent bondOptionTerminationEventInstance = new BondOptionTerminationEvent(
    terminationDate: terminationDate,
    callPrice: callPrice,
    settlementCurrency: settlementCurrency,
    domCcy: domCcy,
    settlementAmountPerUnit: settlementAmountPerUnit);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
