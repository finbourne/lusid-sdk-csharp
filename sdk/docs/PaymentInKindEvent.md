# Lusid.Sdk.Model.PaymentInKindEvent
A Payment in Kind (PINK) event recording that a ComplexBond has paid a coupon in kind. Mandatory and  purely informational: it carries no entitlement and generates no cash flow, movements or transactions,  and leaves Units, current face, PV and accrual untouched. The accretion itself stays with the intrinsic  chain driven by the bond's PikSchedule.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent. | 
**ExDate** | **DateTimeOffset** | The first business day on which the in-kind coupon is not owed to the buying party. Anchors the  lifecycle; must be on or before PaymentDate. | [optional] 
**PaymentDate** | **DateTimeOffset** | The payment date of the in-kind coupon this marker records. | [optional] 
**AnnouncementDate** | **DateTimeOffset?** | Date on which the issuer announced the payment in kind. Optional and informational. | [optional] 
**RecordDate** | **DateTimeOffset?** | Date on which the holder of record is struck. Optional and informational; when supplied it must fall  on or between ExDate and PaymentDate. | [optional] 
**Currency** | **string** | Currency of the coupon that was paid in kind. Optional and informational. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "example currency";

PaymentInKindEvent paymentInKindEventInstance = new PaymentInKindEvent(
    exDate: exDate,
    paymentDate: paymentDate,
    announcementDate: announcementDate,
    recordDate: recordDate,
    currency: currency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
