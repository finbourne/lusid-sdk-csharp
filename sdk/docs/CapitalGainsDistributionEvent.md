# Lusid.Sdk.Model.CapitalGainsDistributionEvent
Capital Gains Distribution event (CAPG). Distributes realised capital gains from a fund's asset sales  as a gross cash rate per eligible unit. Supports a currency-choice variant (CHOS) under  MandatoryWithChoices participation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent. | 
**PaymentDate** | **DateTimeOffset** | The date the cash distribution is paid to shareholders. Required. | [optional] 
**ExDate** | **DateTimeOffset** | The first business day on which the distribution is not owed to the buying party. Required. | [optional] 
**RecordDate** | **DateTimeOffset?** | The date positions are struck for entitlement. Optional. | [optional] 
**AnnouncementDate** | **DateTimeOffset?** | The date the event was announced. Optional. | [optional] 
**CashElections** | [**List&lt;CashElection&gt;**](CashElection.md) | The cash elections for this event. For Mandatory participation supply a single declared election;  for MandatoryWithChoices supply one per available currency, with IsDeclared set on the declared  option and IsChosen on the elected option. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<CashElection> cashElections = new List<CashElection>();

CapitalGainsDistributionEvent capitalGainsDistributionEventInstance = new CapitalGainsDistributionEvent(
    paymentDate: paymentDate,
    exDate: exDate,
    recordDate: recordDate,
    announcementDate: announcementDate,
    cashElections: cashElections);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
