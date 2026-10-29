# Lusid.Sdk.Model.FundDistributionEvent
A distribution from the fund to the holder of a CapitalInterest. A recallable distribution restores  unfunded capital (the fund may call it again); a non-recallable distribution permanently returns capital.                The total amount may optionally be broken down into slots by character (returnOfCapital, realisedGain,  dividend, interest, otherIncome, carryPaid, withholding, returnOfExcess). When any slot amount is supplied  the slot amounts must sum to the total, one transaction is booked per populated slot, and the recallable  portion of each of the five capital/income characters is given by its matching Recallable amount.  Without slots a single legacy distribution transaction is booked for the total, recallable according  to isRecallable.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent, GlobalLoanFacilityReinitialisationEvent, InvestorLoanFacilityReinitialisationEvent, CapitalCallReceiptEvent, RecallableCapitalExpiryEvent, CapitalInterestTransferEvent, FacilityDrawEvent, FacilityRepaymentEvent, FacilityInterestEvent, FacilityCommitmentFeeEvent, InstalmentCallEvent, DepositInterestCapitalisationEvent, PartialRedemptionWithoutReductionOfNominalValueEvent. | 
**Date** | **DateTimeOffset** | The date the distribution takes effect. | [optional] 
**Amount** | **decimal** | The total amount distributed. Must be positive. When slot amounts are supplied they must sum to this total. | 
**IsRecallable** | **bool** | Legacy flag, used only when no slot amount is supplied: true when the fund may recall the whole  distributed amount, so the distribution restores unfunded capital rather than permanently returning  it. Defaults to false. Must not be combined with slot amounts. | [optional] 
**ReturnOfCapitalAmount** | **decimal?** | The part of the distribution that returns capital. Optional slot; must not be negative. | [optional] 
**RealisedGainAmount** | **decimal?** | The part of the distribution that is realised gain. Optional slot; must not be negative. | [optional] 
**DividendAmount** | **decimal?** | The part of the distribution that is dividend income. Optional slot; must not be negative. | [optional] 
**InterestAmount** | **decimal?** | The part of the distribution that is interest income. Optional slot; must not be negative. | [optional] 
**OtherIncomeAmount** | **decimal?** | The part of the distribution that is other income. Optional slot; must not be negative. | [optional] 
**ReturnOfCapitalRecallableAmount** | **decimal?** | The recallable portion of returnOfCapitalAmount. Optional; must not exceed returnOfCapitalAmount. | [optional] 
**RealisedGainRecallableAmount** | **decimal?** | The recallable portion of realisedGainAmount. Optional; must not exceed realisedGainAmount. | [optional] 
**DividendRecallableAmount** | **decimal?** | The recallable portion of dividendAmount. Optional; must not exceed dividendAmount. | [optional] 
**InterestRecallableAmount** | **decimal?** | The recallable portion of interestAmount. Optional; must not exceed interestAmount. | [optional] 
**OtherIncomeRecallableAmount** | **decimal?** | The recallable portion of otherIncomeAmount. Optional; must not exceed otherIncomeAmount. | [optional] 
**CarryPaidAmount** | **decimal?** | The part of the distribution that is carried interest paid to the general partner. Optional slot; must not be negative. | [optional] 
**WithholdingAmount** | **decimal?** | The part of the distribution withheld for tax (a deemed distribution). Optional slot; must not be negative. | [optional] 
**ReturnOfExcessAmount** | **decimal?** | The part of the distribution that returns capital called in excess. Optional slot; must not be negative. | [optional] 
**RecallableUntil** | **DateTimeOffset?** | The date until which the recallable portions may be recalled, if limited. Must not precede the distribution date. | [optional] 
**DealId** | **string** | The identifier of the deal the distribution relates to, if any. | [optional] 
**AllocationEventId** | **string** | The identifier of the allocation event the distribution relates to, if any. | [optional] 
**WaterfallTier** | **string** | The waterfall tier the distribution was paid under, if any. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal amount = "amount";

bool isRecallable = //"True";
string dealId = "example dealId";
string allocationEventId = "example allocationEventId";
string waterfallTier = "example waterfallTier";

FundDistributionEvent fundDistributionEventInstance = new FundDistributionEvent(
    date: date,
    amount: amount,
    isRecallable: isRecallable,
    returnOfCapitalAmount: returnOfCapitalAmount,
    realisedGainAmount: realisedGainAmount,
    dividendAmount: dividendAmount,
    interestAmount: interestAmount,
    otherIncomeAmount: otherIncomeAmount,
    returnOfCapitalRecallableAmount: returnOfCapitalRecallableAmount,
    realisedGainRecallableAmount: realisedGainRecallableAmount,
    dividendRecallableAmount: dividendRecallableAmount,
    interestRecallableAmount: interestRecallableAmount,
    otherIncomeRecallableAmount: otherIncomeRecallableAmount,
    carryPaidAmount: carryPaidAmount,
    withholdingAmount: withholdingAmount,
    returnOfExcessAmount: returnOfExcessAmount,
    recallableUntil: recallableUntil,
    dealId: dealId,
    allocationEventId: allocationEventId,
    waterfallTier: waterfallTier);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
