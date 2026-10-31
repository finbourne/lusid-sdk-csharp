# Lusid.Sdk.Model.StripBondCashflowEvent
A StripBond's receipt of one (payment date, ex date) pair of its parent's flows: the coupons of an  interest-only strip, the principal paydowns of a principal-only one. The cash per unit of original face is the  parent's amount over its initial notional. The booking splits that cash into income and return of capital by  the strip's effective yield. The three outputs the split needs, effectiveYield, accountingChoice and isFinal,  are filled from the recipe's StripBondModelOptions and the market when omitted, and a supplied value wins for  each. A posted event under the generated id replaces the generated one.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent, GlobalLoanFacilityReinitialisationEvent, InvestorLoanFacilityReinitialisationEvent, CapitalCallReceiptEvent, RecallableCapitalExpiryEvent, CapitalInterestTransferEvent, FacilityDrawEvent, FacilityRepaymentEvent, FacilityInterestEvent, FacilityCommitmentFeeEvent, InstalmentCallEvent, DepositInterestCapitalisationEvent, PartialRedemptionWithoutReductionOfNominalValueEvent, StripBondCashflowEvent, CapitalisationEvent. | 
**ExDate** | **DateTimeOffset** | The parent flow&#39;s ex-date, the record-date boundary: a lot settled on or after it is not entitled. Required. | [optional] 
**PaymentDate** | **DateTimeOffset** | The payment date. Required. | [optional] 
**Currency** | **string** | The parent&#39;s payment currency. Required. | 
**CashFlowPerUnit** | **decimal** | The strip&#39;s cash per unit of original face on this date: the summed parent amount divided by the parent&#39;s  initial notional. Required. | 
**PaymentsPerYear** | **int** | The parent&#39;s payments per year, 12 for a monthly parent. The nominal annual yield over this is the  periodic yield a receipt is split on. Required. | 
**EffectiveYield** | **decimal?** | The nominal annual yield applied, as a decimal (0.23646524 for 23.646524%). Optional: filled from the  accounting choice when omitted, 0 under CostRecovery, the strip&#39;s EffectiveYield quote at the ex-date under  QuotedYield, left empty under CashAsReceived, which uses no yield. A supplied value wins. | [optional] 
**AccountingChoice** | **string** | The accounting choice the split uses. Optional: filled from the recipe&#39;s StripBondModelOptions when omitted,  CostRecovery when there are none. A supplied value wins.                Supported string (enumeration) values are: [CostRecovery, QuotedYield, CashAsReceived]. Available values: CostRecovery, QuotedYield, CashAsReceived. | [optional] 
**IsFinal** | **bool?** | Whether the parent&#39;s notional after this payment is zero, so this is the strip&#39;s last payment and the  position closes. Optional: filled from the parent&#39;s populated pool factor at the payment date when omitted,  or its maturity for a parent without one. A supplied value wins. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "currency";decimal cashFlowPerUnit = "cashFlowPerUnit";

string accountingChoice = "example accountingChoice";
bool? isFinal = //"True";

StripBondCashflowEvent stripBondCashflowEventInstance = new StripBondCashflowEvent(
    exDate: exDate,
    paymentDate: paymentDate,
    currency: currency,
    cashFlowPerUnit: cashFlowPerUnit,
    paymentsPerYear: paymentsPerYear,
    effectiveYield: effectiveYield,
    accountingChoice: accountingChoice,
    isFinal: isFinal);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
