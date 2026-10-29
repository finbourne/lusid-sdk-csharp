# Lusid.Sdk.Model.CapitalCallEvent
A call of committed capital on a CapitalInterest: the fund draws down the amount from the investor's  unfunded commitment, moving it to funded capital.                The total amount may optionally be broken down into slots (investment, managementFee, otherFee,  partnershipExpense, organisationalCost, recall, equalisationInterest, latePaymentInterest). When any  slot amount is supplied the slot amounts must sum to the total and one transaction is booked per  populated slot; otherwise a single legacy drawdown transaction is booked for the total.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent, GlobalLoanFacilityReinitialisationEvent, InvestorLoanFacilityReinitialisationEvent, CapitalCallReceiptEvent, RecallableCapitalExpiryEvent, CapitalInterestTransferEvent, FacilityDrawEvent, FacilityRepaymentEvent, FacilityInterestEvent, FacilityCommitmentFeeEvent, InstalmentCallEvent, DepositInterestCapitalisationEvent, PartialRedemptionWithoutReductionOfNominalValueEvent. | 
**Date** | **DateTimeOffset** | The date the capital call takes effect. | [optional] 
**Amount** | **decimal** | The total amount of committed capital called. Must be positive. When slot amounts are  supplied they must sum to this total. | 
**InvestmentAmount** | **decimal?** | The part of the call that funds investments. Optional slot; must not be negative. | [optional] 
**ManagementFeeAmount** | **decimal?** | The part of the call that pays management fees. Optional slot; must not be negative. | [optional] 
**OtherFeeAmount** | **decimal?** | The part of the call that pays other fees. Optional slot; must not be negative. | [optional] 
**PartnershipExpenseAmount** | **decimal?** | The part of the call that pays partnership expenses. Optional slot; must not be negative. | [optional] 
**OrganisationalCostAmount** | **decimal?** | The part of the call that pays organisational costs. Optional slot; must not be negative. | [optional] 
**RecallAmount** | **decimal?** | The part of the call that re-draws previously distributed recallable capital. Optional slot; must not be negative. | [optional] 
**EqualisationInterestAmount** | **decimal?** | The part of the call that is equalisation interest. Optional slot; must not be negative. | [optional] 
**LatePaymentInterestAmount** | **decimal?** | The part of the call that is late payment interest. Optional slot; must not be negative. | [optional] 
**OutsideCommitmentSlots** | **List&lt;string&gt;** | The slots (names without the Amount suffix, e.g. \&quot;managementFee\&quot;) called outside the commitment,  so that they do not reduce the uncalled commitment. When omitted, defaults to equalisationInterest  and latePaymentInterest. | [optional] 
**DealId** | **string** | The identifier of the deal the call relates to, if any. | [optional] 
**AllocationEventId** | **string** | The identifier of the allocation event the call relates to, if any. | [optional] 
**NoticeDate** | **DateTimeOffset?** | The date the call notice was issued, if known. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal amount = "amount";

List<string> outsideCommitmentSlots = new List<string>();
string dealId = "example dealId";
string allocationEventId = "example allocationEventId";

CapitalCallEvent capitalCallEventInstance = new CapitalCallEvent(
    date: date,
    amount: amount,
    investmentAmount: investmentAmount,
    managementFeeAmount: managementFeeAmount,
    otherFeeAmount: otherFeeAmount,
    partnershipExpenseAmount: partnershipExpenseAmount,
    organisationalCostAmount: organisationalCostAmount,
    recallAmount: recallAmount,
    equalisationInterestAmount: equalisationInterestAmount,
    latePaymentInterestAmount: latePaymentInterestAmount,
    outsideCommitmentSlots: outsideCommitmentSlots,
    dealId: dealId,
    allocationEventId: allocationEventId,
    noticeDate: noticeDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
