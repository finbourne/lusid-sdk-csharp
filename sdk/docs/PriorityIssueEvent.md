# Lusid.Sdk.Model.PriorityIssueEvent
Priority Issue Event (PRIO) — a voluntary corporate action in which an issuer offers existing  security holders preferential rights to subscribe for new securities at a defined subscription  price before the offer is opened to the wider market. Holders may subscribe up to a basic  entitlement (SECU) and, where offered, apply for additional securities beyond the basic  entitlement (OVER, subject to proration). No instruction (NOAC) results in no transaction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent. | 
**AnnouncementDate** | **DateTimeOffset?** | Date on which the priority issue was announced. Optional, informational. | [optional] 
**ExDate** | **DateTimeOffset?** | First business day on which the security trades without the entitlement. Optional.  When not supplied, transaction-template generation falls back to RecordDate | [optional] 
**RecordDate** | **DateTimeOffset** | The entitlement determination date — holders of record on this date are eligible to subscribe. | [optional] 
**ResponseDeadline** | **DateTimeOffset** | The account-servicer instruction deadline. Must be less than or equal to MarketDeadline. | [optional] 
**MarketDeadline** | **DateTimeOffset** | The issuer-agent deadline. | [optional] 
**PaymentDate** | **DateTimeOffset** | Date on which cash is debited and the new securities are credited. | [optional] 
**SecuritySettlementDate** | **DateTimeOffset?** | Date the security leg settles when it differs from the cash leg. Optional.  When not supplied, transaction-template generation falls back to PaymentDate | [optional] 
**SubscriptionPrice** | **decimal** | The subscription price per new unit. Applies to both SECU and OVER subscriptions.  Must be greater than zero. | [optional] 
**SubscriptionCurrency** | **string** | Currency of the SubscriptionPrice. | [optional] 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | [optional] 
**ProrationRate** | **decimal?** | The proration rate applied to OVER subscriptions when the offer is oversubscribed.  Treated as 1 (full allocation) when not supplied. Must be greater than 0 and less than  or equal to 1. SECU basic entitlement is never prorated. | [optional] 
**FractionalUnitsCashPrice** | **decimal?** | Price per fractional unit used to compute cash-in-lieu for fractional entitlement remainders.  When not supplied, fractional residuals are discarded with no cash-in-lieu.  Forms an optional pair with FractionalUnitsCashCurrency — both must be supplied together. | [optional] 
**FractionalUnitsCashCurrency** | **string** | Currency of FractionalUnitsCashPrice. Required if and only if FractionalUnitsCashPrice is supplied. | [optional] 
**SecurityOfferElections** | [**List&lt;SecurityOfferElection&gt;**](SecurityOfferElection.md) | Security offer elections — exactly one entry keyed &#39;SECU&#39; (basic entitlement) and an optional  entry keyed &#39;OVER&#39; (over-subscription) when the issuer offers the over-subscription facility. | [optional] 
**LapseElections** | [**List&lt;LapseElection&gt;**](LapseElection.md) | Lapse elections — exactly one entry keyed &#39;NOAC&#39;, recording the holder&#39;s explicit no-action election. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal? subscriptionPrice = "example subscriptionPrice";
string subscriptionCurrency = "example subscriptionCurrency";
NewInstrument? newInstrument = new NewInstrument();

string fractionalUnitsCashCurrency = "example fractionalUnitsCashCurrency";
List<SecurityOfferElection> securityOfferElections = new List<SecurityOfferElection>();
List<LapseElection> lapseElections = new List<LapseElection>();

PriorityIssueEvent priorityIssueEventInstance = new PriorityIssueEvent(
    announcementDate: announcementDate,
    exDate: exDate,
    recordDate: recordDate,
    responseDeadline: responseDeadline,
    marketDeadline: marketDeadline,
    paymentDate: paymentDate,
    securitySettlementDate: securitySettlementDate,
    subscriptionPrice: subscriptionPrice,
    subscriptionCurrency: subscriptionCurrency,
    newInstrument: newInstrument,
    prorationRate: prorationRate,
    fractionalUnitsCashPrice: fractionalUnitsCashPrice,
    fractionalUnitsCashCurrency: fractionalUnitsCashCurrency,
    securityOfferElections: securityOfferElections,
    lapseElections: lapseElections);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
