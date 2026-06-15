# Lusid.Sdk.Model.DrawingEvent
Mandatory partial bond redemption (DRAW) where the issuer lottery-selects specific bonds for early redemption.  The affected face amount (AFFB) is pre-determined externally from the vendor notification and supplied on the event.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent. | 
**PaymentDate** | **DateTimeOffset** | Date the cash actually flows for the drawn portion of the holding. | [optional] 
**EffectiveDate** | **DateTimeOffset** | Lottery Date (&#x3D; Record Date). Holdings are snapshotted at the close of this date to determine the affected balance. | [optional] 
**AffectedAmount** | **decimal** | Affected face amount (AFFB) — the lottery-selected portion of the holding that is redeemed. Must be strictly positive. | 
**PricePerUnit** | **decimal?** | Redemption price per unit (OFFR / 100). Clean price convention.  Optional: AFFB is typically known before the issuer publishes OFFR, so a null price is permitted on upsert. | [optional] 
**Currency** | **string** | Settlement currency for the redemption. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal affectedAmount = "affectedAmount";

string currency = "currency";

DrawingEvent drawingEventInstance = new DrawingEvent(
    paymentDate: paymentDate,
    effectiveDate: effectiveDate,
    affectedAmount: affectedAmount,
    pricePerUnit: pricePerUnit,
    currency: currency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
