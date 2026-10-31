# Lusid.Sdk.Model.CapitalisationEvent
Capitalisation (CAPI, AMI-SeCo SCoRE section 4.10): an increase in the current principal of a debt instrument  without an increase in its nominal value, normally from incorporating due but unpaid interest into the  principal. A notified CAPI on a ComplexBond, recording the factor before (previousFactor) and after  (nextFactor) the event. Mandatory and purely informational: it generates no cash flow, movements or  transactions. The capitalisation itself is booked by the bond's PikSchedule.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent, GlobalLoanFacilityReinitialisationEvent, InvestorLoanFacilityReinitialisationEvent, CapitalCallReceiptEvent, RecallableCapitalExpiryEvent, CapitalInterestTransferEvent, FacilityDrawEvent, FacilityRepaymentEvent, FacilityInterestEvent, FacilityCommitmentFeeEvent, InstalmentCallEvent, DepositInterestCapitalisationEvent, PartialRedemptionWithoutReductionOfNominalValueEvent, StripBondCashflowEvent, CapitalisationEvent. | 
**EffectiveDate** | **DateTimeOffset** | The date the next factor applies (:98A::EFFD). Required. | [optional] 
**PaymentDate** | **DateTimeOffset?** | The payment date (:98A::PAYD). Optional and informational; it may fall before effectiveDate. | [optional] 
**RecordDate** | **DateTimeOffset?** | The record date (:98A::RDTE). Optional and informational; when supplied it must not fall after  effectiveDate. | [optional] 
**PreviousFactor** | **decimal?** | The factor, current principal per unit of nominal, in force before the event (:92A::PRFC). Optional, but  supplied together with nextFactor or not at all; greater than 0 when supplied. An event without the  factors is stored as economically incomplete. | [optional] 
**NextFactor** | **decimal?** | The factor, current principal per unit of nominal, in force from effectiveDate (:92A::NWFC). Optional, but  supplied together with previousFactor or not at all; not less than previousFactor when supplied. | [optional] 
**InterestRate** | **decimal?** | The annual interest rate capitalised, as a fraction, so 6 per cent is 0.06 (:92A::INTP). Optional and  informational; not negative when supplied. | [optional] 
**Currency** | **string** | The currency of the capitalised principal (:11A::DENO). Optional and informational. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "example currency";

CapitalisationEvent capitalisationEventInstance = new CapitalisationEvent(
    effectiveDate: effectiveDate,
    paymentDate: paymentDate,
    recordDate: recordDate,
    previousFactor: previousFactor,
    nextFactor: nextFactor,
    interestRate: interestRate,
    currency: currency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
