# Lusid.Sdk.Model.CapitalInterestTransferEvent
The movement of a proportion of a CapitalInterest line's capital balances from one line to another.  The source (Out) side moves every balance by the fraction; the destination (In) side receives the  amounts given on the event. Mode distinguishes a genuine transfer between investors from a correction  of a mis-booked position.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent, GlobalLoanFacilityReinitialisationEvent, InvestorLoanFacilityReinitialisationEvent, CapitalCallReceiptEvent, RecallableCapitalExpiryEvent, CapitalInterestTransferEvent, FacilityDrawEvent, FacilityRepaymentEvent, FacilityInterestEvent, FacilityCommitmentFeeEvent, InstalmentCallEvent, DepositInterestCapitalisationEvent. | 
**Date** | **DateTimeOffset** | The date the transfer takes effect. | [optional] 
**Direction** | **string** | Which side of the transfer this event books: &#39;Out&#39; on the source line or &#39;In&#39; on the destination line. Available values: Out, In. | 
**Fraction** | **decimal** | The fraction of the source line being transferred. Must be greater than zero and at most one;  a fraction of one moves the whole line. | 
**FromLineId** | **string** | The identifier of the line the balances move from. | 
**ToLineId** | **string** | The identifier of the line the balances move to. | 
**Mode** | **string** | &#39;Transfer&#39; for a genuine transfer between investors or &#39;Correction&#39; for a backdated fix of a  mis-booked position. Defaults to &#39;Transfer&#39;. Available values: Transfer, Correction. | [optional] 
**ToPortfolioId** | **string** | The identifier of the portfolio holding the destination line, if different from the source. | [optional] 
**ConsiderationAmount** | **decimal?** | The consideration paid for the transferred interest, if any. Must not be negative. | [optional] 
**ConsiderationCurrency** | **string** | The currency of the consideration, if any. | [optional] 
**ConsiderationRecordOnly** | **bool?** | True when the consideration is recorded for information only and does not settle. | [optional] 
**Reason** | **string** | The reason for the transfer, if given: &#39;TaxStatusChange&#39;, &#39;Redomicile&#39;, &#39;SecondaryBuyerIneligible&#39;,  &#39;BenefitPlanLimit&#39;, &#39;WrongVehicleAtClose&#39;, &#39;AffiliateTransfer&#39;, &#39;Regulatory&#39;, &#39;VehicleMergerOrClosure&#39;,  &#39;NomineeUnwind&#39; or &#39;BlockerOrAivElection&#39;. Available values: None, TaxStatusChange, Redomicile, SecondaryBuyerIneligible, BenefitPlanLimit, WrongVehicleAtClose, AffiliateTransfer, Regulatory, VehicleMergerOrClosure, NomineeUnwind, BlockerOrAivElection. | [optional] 
**Scope** | **string** | &#39;Whole&#39; to move the whole line or &#39;Deal&#39; to move only one deal&#39;s balances. &#39;Deal&#39; is only allowed  with reason &#39;BlockerOrAivElection&#39;. Defaults to &#39;Whole&#39;. Available values: Whole, Deal. | [optional] 
**DealId** | **string** | The identifier of the deal the transfer relates to, if any. | [optional] 
**TaxTreatmentAcknowledged** | **bool?** | Acknowledges that the tax treatment of a blocker or AIV election has been reviewed. Required to be  true when the reason is &#39;BlockerOrAivElection&#39;. | [optional] 
**CommittedCapitalAmount** | **decimal?** | The committed capital received by the destination line. Used on the &#39;In&#39; side only; must not be negative. | [optional] 
**CalledCommitmentAmount** | **decimal?** | The called part of the commitment received by the destination line, which lowers its uncalled commitment. Used on the &#39;In&#39; side only; must not be negative. | [optional] 
**PaidInCapitalAmount** | **decimal?** | The paid-in capital received by the destination line. Used on the &#39;In&#39; side only; must not be negative. | [optional] 
**ReturnedCapitalAmount** | **decimal?** | The returned capital received by the destination line. Used on the &#39;In&#39; side only; must not be negative. | [optional] 
**RecallableCapitalAmount** | **decimal?** | The recallable capital received by the destination line. Used on the &#39;In&#39; side only; must not be negative. | [optional] 
**NonRecallableCapitalAmount** | **decimal?** | The non-recallable capital received by the destination line. Used on the &#39;In&#39; side only; must not be negative. | [optional] 
**FundedCapitalAmount** | **decimal?** | The funded capital received by the destination line, for a line whose drawdowns were booked against the stored funded balance rather than paid-in capital. Used on the &#39;In&#39; side only; must not be negative. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string direction = "direction";decimal fraction = "fraction";

string fromLineId = "fromLineId";
string toLineId = "toLineId";
string mode = "example mode";
string toPortfolioId = "example toPortfolioId";
string considerationCurrency = "example considerationCurrency";
bool? considerationRecordOnly = //"True";
string reason = "example reason";
string scope = "example scope";
string dealId = "example dealId";
bool? taxTreatmentAcknowledged = //"True";

CapitalInterestTransferEvent capitalInterestTransferEventInstance = new CapitalInterestTransferEvent(
    date: date,
    direction: direction,
    fraction: fraction,
    fromLineId: fromLineId,
    toLineId: toLineId,
    mode: mode,
    toPortfolioId: toPortfolioId,
    considerationAmount: considerationAmount,
    considerationCurrency: considerationCurrency,
    considerationRecordOnly: considerationRecordOnly,
    reason: reason,
    scope: scope,
    dealId: dealId,
    taxTreatmentAcknowledged: taxTreatmentAcknowledged,
    committedCapitalAmount: committedCapitalAmount,
    calledCommitmentAmount: calledCommitmentAmount,
    paidInCapitalAmount: paidInCapitalAmount,
    returnedCapitalAmount: returnedCapitalAmount,
    recallableCapitalAmount: recallableCapitalAmount,
    nonRecallableCapitalAmount: nonRecallableCapitalAmount,
    fundedCapitalAmount: fundedCapitalAmount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
