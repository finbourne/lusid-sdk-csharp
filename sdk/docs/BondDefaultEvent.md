# Lusid.Sdk.Model.BondDefaultEvent
Indicates when an issuer has defaulted on an obligation due to technical default, missed payments, or bankruptcy filing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent. | 
**EffectiveDate** | **DateTimeOffset** | The date the bond default occurred. | [optional] 
**DefaultReason** | **string** | Why the issuer defaulted, in the client&#39;s own words. Free text, with no effect on any calculation.  This field is optional. | [optional] 
**SuppressionDetails** | [**BondDefaultSuppressionDetails**](BondDefaultSuppressionDetails.md) |  | [optional] 
**SuppressionDetailsSpecified** | **bool?** | Whether SuppressionDetails was supplied at all, which an absent section and an empty one cannot  otherwise be told apart by when the percentages are read as separate columns. An absent section  suppresses coupons and principal outright; an empty one suppresses nothing.  Setting this to false while also supplying a percentage is contradictory. The percentages win and  the section is treated as present, because honouring the false would silently discard values the  caller explicitly sent. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string defaultReason = "example defaultReason";
BondDefaultSuppressionDetails? suppressionDetails = new BondDefaultSuppressionDetails();

bool? suppressionDetailsSpecified = //"True";

BondDefaultEvent bondDefaultEventInstance = new BondDefaultEvent(
    effectiveDate: effectiveDate,
    defaultReason: defaultReason,
    suppressionDetails: suppressionDetails,
    suppressionDetailsSpecified: suppressionDetailsSpecified);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
