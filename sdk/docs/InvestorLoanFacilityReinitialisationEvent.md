# Lusid.Sdk.Model.InvestorLoanFacilityReinitialisationEvent
Sets one investor's loan-facility position at tax lot granularity - contract balances, accrued interest and  cost - on lots a trade has already opened, where those are not simply the pro-rata share the trade derived  from the facility's global state. Every figure is an absolute target, not a delta.                Tax lot ids are only unique within a portfolio, and the event lives on a corporate action source that  several portfolios can share, so it names the portfolio it corrects.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent, GlobalLoanFacilityReinitialisationEvent, InvestorLoanFacilityReinitialisationEvent. | 
**ContractAllocations** | [**List&lt;LoanFacilityTaxLotAllocation&gt;**](LoanFacilityTaxLotAllocation.md) | Investor-level state per contract per tax lot - the balance, and the accrued interest on it where  that is stated rather than derived. Each entry names its own contract, so a tax lot holding a balance  on two contracts appears twice. May be omitted for a fully undrawn lot named in TaxLotStates. | [optional] 
**Date** | **DateTimeOffset** | Effective date of the reinitialisation. The tax lots it names must already have been opened, and  settled, by a trade dated no later than this. | [optional] 
**PortfolioScope** | **string** | Scope of the portfolio whose lots the event corrects. | 
**PortfolioCode** | **string** | Code of the portfolio whose lots the event corrects. | 
**TaxLotStates** | [**List&lt;LoanFacilityTaxLotState&gt;**](LoanFacilityTaxLotState.md) | Facility-level state per tax lot - cost, and the facility&#39;s own accrual on its undrawn amount. Keyed  on the tax lot alone, so a lot holding balances on several contracts has one entry here and one  ContractAllocation per contract. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<LoanFacilityTaxLotAllocation> contractAllocations = new List<LoanFacilityTaxLotAllocation>();
string portfolioScope = "portfolioScope";
string portfolioCode = "portfolioCode";
List<LoanFacilityTaxLotState> taxLotStates = new List<LoanFacilityTaxLotState>();

InvestorLoanFacilityReinitialisationEvent investorLoanFacilityReinitialisationEventInstance = new InvestorLoanFacilityReinitialisationEvent(
    contractAllocations: contractAllocations,
    date: date,
    portfolioScope: portfolioScope,
    portfolioCode: portfolioCode,
    taxLotStates: taxLotStates);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
