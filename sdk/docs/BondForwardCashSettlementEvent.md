# Lusid.Sdk.Model.BondForwardCashSettlementEvent
Cash settlement of a BondForward at its settlement date:  the forward closes against a single net payment of the clean price difference, and no bond changes  hands. Unlike a commodity forward the underlying is a mastered, quoted instrument, so LUSID computes  the settlement amount from the underlying's quote rather than taking a pre-netted figure; a supplied  referencePrice wins and the quote is not consulted.  Accrued does not enter the payoff, by cancellation rather than entitlement: both sides of the  difference accrue to the same date, so the accrued is identical on each and drops out.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent. | 
**AgreedCleanPrice** | **decimal** | The agreed price, percent of par, carried from the definition. | 
**ContractSize** | **decimal** | Face amount per unit, carried from the definition. It scales the payoff, so it is rejected where it  differs from the instrument&#39;s own value. | 
**MaturityDate** | **DateTimeOffset** | The forward&#39;s contractual settlement date, on which the price difference fixes. | [optional] 
**ReferencePrice** | **decimal?** | The underlying&#39;s clean price, percent of par, at the settlement date. Null resolves from the  underlying&#39;s quote; a supplied value wins and the quote is not consulted. | [optional] 
**SettlementAmountPerUnit** | **decimal?** | Output only: the net settlement per unit, computed from the reference price, the agreed price and  the contract size. A supplied value is overwritten. Negative is valid and means the holder pays. | [optional] 
**SettlementCurrency** | **string** | Currency the net amount settles in, being the forward&#39;s domestic currency. | 
**SettlementDate** | **DateTimeOffset?** | The date the net payment settles. Null means the maturity date; cash-settled forwards commonly pay  a day or two after the price fixes. Rejected where earlier than the maturity date. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal agreedCleanPrice = "agreedCleanPrice";
decimal contractSize = "contractSize";

string settlementCurrency = "settlementCurrency";

BondForwardCashSettlementEvent bondForwardCashSettlementEventInstance = new BondForwardCashSettlementEvent(
    agreedCleanPrice: agreedCleanPrice,
    contractSize: contractSize,
    maturityDate: maturityDate,
    referencePrice: referencePrice,
    settlementAmountPerUnit: settlementAmountPerUnit,
    settlementCurrency: settlementCurrency,
    settlementDate: settlementDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
