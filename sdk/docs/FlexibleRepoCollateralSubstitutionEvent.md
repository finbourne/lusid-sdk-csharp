# Lusid.Sdk.Model.FlexibleRepoCollateralSubstitutionEvent
Event representing the substitution of collateral on a repurchase agreement booked as a FlexibleRepo.  One or more outgoing collateral instruments are returned by the Buyer and replaced by one or more incoming  collateral instruments provided by the Seller, without closing or modifying the repo itself.  The outgoing instruments are held on the repo until the settlement date and the incoming instruments from it,  in the units given on each CollateralIn entry. Optional flags allow deferral of the manufactured and cash  payments to repo maturity, and payment of the repo interest accrued to the entitlement date.  Specific to a FlexibleRepo instrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent, GlobalLoanFacilityReinitialisationEvent, InvestorLoanFacilityReinitialisationEvent, CapitalCallReceiptEvent, RecallableCapitalExpiryEvent, CapitalInterestTransferEvent, FacilityDrawEvent, FacilityRepaymentEvent, FacilityInterestEvent, FacilityCommitmentFeeEvent, InstalmentCallEvent, DepositInterestCapitalisationEvent, PartialRedemptionWithoutReductionOfNominalValueEvent, StripBondCashflowEvent, CapitalisationEvent, SharesPremiumDividendEvent, CashDistributionFromNonEligibleSecuritiesSalesEvent, InflationIndexationEvent, InterestPaymentWithPrincipalEvent, IncreaseInValueEvent, FlexibleRepoCollateralSubstitutionEvent. | 
**EntitlementDate** | **DateTimeOffset** | Required property.  The date on which the substitution takes effect. Must be on or before the settlement date.  This is a required field, unless otherwise supplied via \&quot;EventDateStamps\&quot; in  the instrument event upsert request. | [optional] 
**SettlementDate** | **DateTimeOffset** | Required property.  The date on which the collateral transfers settle: the outgoing instruments are held on the repo until this  date and the incoming instruments from it. Must be on or after the entitlement date and strictly before the  repo maturity date.  This is a required field, unless otherwise supplied via \&quot;EventDateStamps\&quot; in  the instrument event upsert request. | [optional] 
**CollateralOut** | [**List&lt;CollateralSubstitutionConstituent&gt;**](CollateralSubstitutionConstituent.md) | The collateral instruments being removed from the repo. If omitted, every collateral instrument held on the  repo on the settlement date is substituted in full. If provided, must contain at least one entry, each of an  instrument held on the repo from before the settlement date. | [optional] 
**CollateralIn** | [**List&lt;CollateralSubstitutionConstituent&gt;**](CollateralSubstitutionConstituent.md) | The collateral instruments being added to the repo. Must contain at least one entry. | 
**Amount** | **decimal?** | Not supported: must be omitted. Partial substitution of the outgoing collateral is not available; the amounts  are given on each CollateralOut and CollateralIn entry. | [optional] 
**AmountType** | **string** | Not supported: must be omitted. See Amount.  Supported string (enumeration) values are: [Percentage, Units]. Available values: Percentage, Units. | [optional] 
**AdjustCollateralUnits** | **bool** | Required property.  Must be false: the incoming collateral units are taken from the Amount on each CollateralIn entry.  Sizing the incoming units so that their market value matches the outgoing collateral (true) is not yet supported. | 
**DeferCashPayment** | **bool** | Only valid if AdjustCollateralUnits is false. If true, the residual cash payment is deferred to repo maturity.  Defaults to false. | [optional] 
**AccrueDeferredCashPayment** | **bool** | Only valid if DeferCashPayment is true. If true, the deferred cash payment accrues interest at the repo rate  until maturity. Defaults to false. | [optional] 
**PayAccruedRepoInterestAtSubstitution** | **bool** | If true, the repo interest accrued from the repo start date to the entitlement date is paid on the settlement  date, and repo interest resets and resumes from the entitlement date to maturity. Defaults to false. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<CollateralSubstitutionConstituent> collateralOut = new List<CollateralSubstitutionConstituent>();
List<CollateralSubstitutionConstituent> collateralIn = new List<CollateralSubstitutionConstituent>();
string amountType = "example amountType";
bool adjustCollateralUnits = //"True";
bool deferCashPayment = //"True";
bool accrueDeferredCashPayment = //"True";
bool payAccruedRepoInterestAtSubstitution = //"True";

FlexibleRepoCollateralSubstitutionEvent flexibleRepoCollateralSubstitutionEventInstance = new FlexibleRepoCollateralSubstitutionEvent(
    entitlementDate: entitlementDate,
    settlementDate: settlementDate,
    collateralOut: collateralOut,
    collateralIn: collateralIn,
    amount: amount,
    amountType: amountType,
    adjustCollateralUnits: adjustCollateralUnits,
    deferCashPayment: deferCashPayment,
    accrueDeferredCashPayment: accrueDeferredCashPayment,
    payAccruedRepoInterestAtSubstitution: payAccruedRepoInterestAtSubstitution);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
