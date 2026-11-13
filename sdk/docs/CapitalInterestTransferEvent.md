# Lusid.Sdk.Model.CapitalInterestTransferEvent
The movement of a proportion of a CapitalInterest line's capital balances from one line to another.  The source (Out) side moves every balance by the fraction; the destination (In) side receives the  amounts given on the event. Mode distinguishes a genuine transfer between investors from a correction  of a mis-booked position. The portfolio-currency twin amounts (PaidInCapitalPortfolioCcyAmount,  ReturnedCapitalPortfolioCcyAmount and ExcessCapitalReturnedPortfolioCcyAmount) are not derived from the  commitment-currency amounts: an In side carries the source line's share of each twin balance, as the Out side  gives it up, and a client-maintained transaction type configuration must include the ...PortfolioCcy twin  movements for the twins to move at all.  The supported way to move an interest between partners is a Transfer allocation event (eventType Transfer on  the allocation events endpoint), which derives both sides from the register, plans and books them together  and posts to the general ledger and the capital account. Direct Out/In pairs upserted as instrument events  remain for migrations: they move register balances only, post nothing to the general ledger or the capital  account, and are validated as a pair. An In side must have an Out side for the same lines on the same date, in  the same request or already on the source, and its amounts must equal what that Out side moves, balance by  balance, the excess capital returned and the portfolio-currency twins included; otherwise the request is  refused naming the balance and both events, and nothing is written. One Out side has one In side: a second In  side for the same lines on the same date is refused, and so is an In side whose Out side shares its source line  and date with another Out side, in the request or already on the source, because the engine applies  same-instant transfers in entry order and the second moves what the first left; book transfers out of one  line at distinct instants. The source line must already be on the register when the pair is upserted; a line  whose history arrives in the same request is refused as not on the register.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent, GlobalLoanFacilityReinitialisationEvent, InvestorLoanFacilityReinitialisationEvent, CapitalCallReceiptEvent, RecallableCapitalExpiryEvent, CapitalInterestTransferEvent, FacilityDrawEvent, FacilityRepaymentEvent, FacilityInterestEvent, FacilityCommitmentFeeEvent, InstalmentCallEvent, DepositInterestCapitalisationEvent, PartialRedemptionWithoutReductionOfNominalValueEvent, StripBondCashflowEvent, CapitalisationEvent, SharesPremiumDividendEvent, CashDistributionFromNonEligibleSecuritiesSalesEvent, InflationIndexationEvent. | 
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
**FundedCapitalAmount** | **decimal?** | The funded capital received by the destination line beyond its paid-in capital: the share of what the source line holds as a stored funded balance, from drawdowns booked against funded capital rather than paid-in capital. Paid-in capital already funds the destination, so for a line funded through paid-in capital this is zero or omitted; a figure here equal to the paid-in would fund the destination twice and is refused. Used on the &#39;In&#39; side only; must not be negative. | [optional] 
**ExcessCapitalReturnedAmount** | **decimal?** | The cumulative excess capital returned that the destination line takes over from the source line. Used on the &#39;In&#39; side only; must not be negative. | [optional] 
**PaidInCapitalPortfolioCcyAmount** | **decimal?** | The paid-in capital the destination line takes over, already in the portfolio&#39;s base currency: the source line&#39;s PaidInCapitalPortfolioCcy balance share, accumulated at historical rates, not a spot conversion of PaidInCapitalAmount. Used on the &#39;In&#39; side only; must not be negative. An In side carries the source line&#39;s share of PaidInCapitalPortfolioCcy, as the Out side gives it up, and is refused when it omits a share the source line carries, and the transaction type configuration must include the PaidInCapitalPortfolioCcy movement for the twin to move. | [optional] 
**ReturnedCapitalPortfolioCcyAmount** | **decimal?** | The returned capital the destination line takes over, already in the portfolio&#39;s base currency at the source line&#39;s historical rates. Used on the &#39;In&#39; side only; must not be negative. An In side carries the source line&#39;s share of ReturnedCapitalPortfolioCcy, as the Out side gives it up, and is refused when it omits a share the source line carries, and the transaction type configuration must include the ReturnedCapitalPortfolioCcy movement for the twin to move. | [optional] 
**ExcessCapitalReturnedPortfolioCcyAmount** | **decimal?** | The cumulative excess capital returned that the destination line takes over, already in the portfolio&#39;s base currency at the source line&#39;s historical rates. Used on the &#39;In&#39; side only; must not be negative. An In side carries the source line&#39;s share of ExcessCapitalReturnedPortfolioCcy, as the Out side gives it up, and is refused when it omits a share the source line carries, and the transaction type configuration must include the ExcessCapitalReturnedPortfolioCcy movement for the twin to move. | [optional] 
**RecalledCapitalAmount** | **decimal?** | The cumulative recalled capital that the destination line takes over, in the commitment currency. Used on the &#39;In&#39; side only; must not be negative. An In side carries the source line&#39;s share of RecalledCapital, as the Out side gives it up, and is refused when it omits a share the source line carries, and the transaction type configuration must include the RecalledCapital movement for the balance to move. | [optional] 

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
    fundedCapitalAmount: fundedCapitalAmount,
    excessCapitalReturnedAmount: excessCapitalReturnedAmount,
    paidInCapitalPortfolioCcyAmount: paidInCapitalPortfolioCcyAmount,
    returnedCapitalPortfolioCcyAmount: returnedCapitalPortfolioCcyAmount,
    excessCapitalReturnedPortfolioCcyAmount: excessCapitalReturnedPortfolioCcyAmount,
    recalledCapitalAmount: recalledCapitalAmount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
