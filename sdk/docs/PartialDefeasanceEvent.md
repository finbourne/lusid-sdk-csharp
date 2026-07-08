# Lusid.Sdk.Model.PartialDefeasanceEvent
Partial Defeasance event (PDEF). A mandatory notification that a bond issuer has escrow-funded  (defeased) a portion of an outstanding issue. No cash flows to holders at this event; the position  is marked pre-refunded and its effective maturity is updated to the future call date carried in  ActualPayDate. The actual cash and position retirement arrive later via a separate  mandatory call event. Supports a Partial Pre-Refunding variant (PPRE).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent. | 
**RefundedFraction** | **decimal** | The issue-level fraction allocated to the refunded (pre-refunded / escrowed) portion. Strictly  in the half-open interval (0, 1]; the non-refunded fraction is the derived complement. This is a  required field. | 
**EffectiveDate** | **DateTimeOffset** | The date the defeasance status takes effect on the position. This is a required field. | [optional] 
**ActualPayDate** | **DateTimeOffset** | The future call date when the bond will actually be retired, used to update the position&#39;s  effective maturity in analytics. Must be on or after EffectiveDate. This is a  required field. | [optional] 
**RefundedInstrument** | [**NewInstrument**](NewInstrument.md) |  | [optional] 
**NewSecuritiesIndicator** | **string** | Optional audit field preserving the wire-side codeword used for the refunded portion.  Supported string (enumeration) values are: [REFU, DEFE]. Both encodings carry identical semantics. Available values: REFU, DEFE. | [optional] 
**AdditionalBusinessProcess** | **string** | Optional variant indicator. Supported string (enumeration) values are: [PPRE]. Absence (null)  encodes the default Partial Defeasance variant. Available values: PPRE. | [optional] 
**LotteryDate** | **DateTimeOffset?** | Optional. The wire&#39;s lottery date; null when the wire carried a sentinel value. | [optional] 
**PublicationDate** | **DateTimeOffset?** | Optional informational date identifying when the defeasance was publicly noticed. | [optional] 
**RecordDate** | **DateTimeOffset?** | Optional. The wire&#39;s record date; typically null for a notification event with no distribution. | [optional] 
**AnnouncementDate** | **DateTimeOffset?** | Optional informational announcement date; null when not provided. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal refundedFraction = "refundedFraction";

NewInstrument? refundedInstrument = new NewInstrument();

string newSecuritiesIndicator = "example newSecuritiesIndicator";
string additionalBusinessProcess = "example additionalBusinessProcess";

PartialDefeasanceEvent partialDefeasanceEventInstance = new PartialDefeasanceEvent(
    refundedFraction: refundedFraction,
    effectiveDate: effectiveDate,
    actualPayDate: actualPayDate,
    refundedInstrument: refundedInstrument,
    newSecuritiesIndicator: newSecuritiesIndicator,
    additionalBusinessProcess: additionalBusinessProcess,
    lotteryDate: lotteryDate,
    publicationDate: publicationDate,
    recordDate: recordDate,
    announcementDate: announcementDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
