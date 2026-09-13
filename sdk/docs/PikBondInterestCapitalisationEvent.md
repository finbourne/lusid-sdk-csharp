# Lusid.Sdk.Model.PikBondInterestCapitalisationEvent
Definition of a PIK Bond Interest Capitalisation Event  This is an event that describes the capitalised (paid-in-kind) portion of a coupon period on a  Payment-in-Kind ComplexBond, whereby the coupon amount is added to the bond's current face.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent. | 
**ExDate** | **DateTimeOffset** | The ex date (entitlement date) of the coupon | [optional] 
**PaymentDate** | **DateTimeOffset** | The payment date of the coupon | [optional] 
**Currency** | **string** | The currency in which the coupon is denominated | 
**CouponPerUnit** | **decimal?** | The capitalised coupon amount per unit of the held bond&#39;s current face. Never rounded. | [optional] 
**FaceRoundingConvention** | **string** | How the face credited to a holding is rounded once CouponPerUnit has been scaled by the holding&#39;s  current face. Defaults to null, which leaves it unrounded. Carried from the bond&#39;s PikSchedule; the  per-unit coupon itself is never rounded. BuyUp is one of the available values but is rejected for  this event: a capitalisation has no cash leg to fund the next whole unit from. Available values: Floor, Ceiling, RoundHalfUp, RoundHalfDown, RoundToDecimalPlaces, BuyUp, BankerRounding. | [optional] 
**FaceRoundingDecimalPlaces** | **int?** | The number of decimal places the credited face is rounded to. Required when  FaceRoundingConvention is RoundToDecimalPlaces and not permitted otherwise. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "currency";
string faceRoundingConvention = "example faceRoundingConvention";

PikBondInterestCapitalisationEvent pikBondInterestCapitalisationEventInstance = new PikBondInterestCapitalisationEvent(
    exDate: exDate,
    paymentDate: paymentDate,
    currency: currency,
    couponPerUnit: couponPerUnit,
    faceRoundingConvention: faceRoundingConvention,
    faceRoundingDecimalPlaces: faceRoundingDecimalPlaces);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
