# Lusid.Sdk.Model.TransactionTemplateSpecification

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | Available values: Internal, TransitionEvent, CouponEvent, OpenEvent, CloseEvent, BondDefaultEvent, CashDividendEvent, StockSplitEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, Unknown, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent. | 
**SupportedInstrumentTypes** | **List&lt;string&gt;** |  | 
**SupportedParticipationTypes** | **List&lt;string&gt;** |  | 
**SupportedElectionTypes** | [**List&lt;ElectionSpecification&gt;**](ElectionSpecification.md) |  | 
**SupportedTemplateFields** | [**List&lt;TemplateField&gt;**](TemplateField.md) |  | 
**EligibilityCalculation** | [**EligibilityCalculation**](EligibilityCalculation.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentEventType = "instrumentEventType";
List<string> supportedInstrumentTypes = new List<string>();
List<string> supportedParticipationTypes = new List<string>();
List<ElectionSpecification> supportedElectionTypes = new List<ElectionSpecification>();
List<TemplateField> supportedTemplateFields = new List<TemplateField>();
EligibilityCalculation eligibilityCalculation = new EligibilityCalculation();

TransactionTemplateSpecification transactionTemplateSpecificationInstance = new TransactionTemplateSpecification(
    instrumentEventType: instrumentEventType,
    supportedInstrumentTypes: supportedInstrumentTypes,
    supportedParticipationTypes: supportedParticipationTypes,
    supportedElectionTypes: supportedElectionTypes,
    supportedTemplateFields: supportedTemplateFields,
    eligibilityCalculation: eligibilityCalculation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
