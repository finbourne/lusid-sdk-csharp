# Lusid.Sdk.Model.CapitalCallReceiptEvent
The investor's payment against a capital call on a CapitalInterest. Booked separately from the call  because it arrives on a later date and may come in instalments; each populated slot books its own  receipt transaction so an unpaid fee never short-pays the deal.                The total amount may optionally be broken down into the same slots as the call (investment,  managementFee, otherFee, partnershipExpense, organisationalCost, recall, equalisationInterest,  latePaymentInterest). When any slot amount is supplied the slot amounts must sum to the total and  one transaction is booked per populated slot; otherwise a single receipt transaction is booked for  the total.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent, GlobalLoanFacilityReinitialisationEvent, InvestorLoanFacilityReinitialisationEvent, CapitalCallReceiptEvent, RecallableCapitalExpiryEvent, CapitalInterestTransferEvent, FacilityDrawEvent, FacilityRepaymentEvent, FacilityInterestEvent, FacilityCommitmentFeeEvent. | 
**Date** | **DateTimeOffset** | The date the receipt is paid. | [optional] 
**Amount** | **decimal** | The total amount paid against the call. Must be positive. When slot amounts are supplied they  must sum to this total. | 
**CallEventId** | **string** | The identifier of the capital call event this receipt pays. | 
**InvestmentAmount** | **decimal?** | The part of the receipt that pays the investment slot of the call. Optional slot; must not be negative. | [optional] 
**ManagementFeeAmount** | **decimal?** | The part of the receipt that pays the management fee slot of the call. Optional slot; must not be negative. | [optional] 
**OtherFeeAmount** | **decimal?** | The part of the receipt that pays the other fee slot of the call. Optional slot; must not be negative. | [optional] 
**PartnershipExpenseAmount** | **decimal?** | The part of the receipt that pays the partnership expense slot of the call. Optional slot; must not be negative. | [optional] 
**OrganisationalCostAmount** | **decimal?** | The part of the receipt that pays the organisational cost slot of the call. Optional slot; must not be negative. | [optional] 
**RecallAmount** | **decimal?** | The part of the receipt that pays the recall slot of the call. Optional slot; must not be negative. | [optional] 
**EqualisationInterestAmount** | **decimal?** | The part of the receipt that pays the equalisation interest slot of the call. Optional slot; must not be negative. | [optional] 
**LatePaymentInterestAmount** | **decimal?** | The part of the receipt that pays the late payment interest slot of the call. Optional slot; must not be negative. | [optional] 
**OutsideCommitmentSlots** | **List&lt;string&gt;** | The slots (names without the Amount suffix, e.g. \&quot;managementFee\&quot;) that were called outside the  commitment, so that paying them does not move paid-in capital. When omitted, defaults to  equalisationInterest and latePaymentInterest. | [optional] 
**DealId** | **string** | The identifier of the deal the receipt relates to, if any. | [optional] 
**AllocationEventId** | **string** | The identifier of the allocation event the receipt relates to, if any. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal amount = "amount";

string callEventId = "callEventId";
List<string> outsideCommitmentSlots = new List<string>();
string dealId = "example dealId";
string allocationEventId = "example allocationEventId";

CapitalCallReceiptEvent capitalCallReceiptEventInstance = new CapitalCallReceiptEvent(
    date: date,
    amount: amount,
    callEventId: callEventId,
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
    allocationEventId: allocationEventId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
