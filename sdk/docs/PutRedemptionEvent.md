# Lusid.Sdk.Model.PutRedemptionEvent
Put Redemption (BPUT) — early redemption of a bond at the holder's election under an  indenture-defined put option. Supports both Voluntary (the AMI-SeCo canonical shape) and  Mandatory (a deliberate market extension beyond SCoRE) participation on Bond, ComplexBond,  and InflationLinkedBond instruments. Cloned from RepurchaseOfferEvent (BIDS) and narrowed  to debt with a fixed event-level OfferPrice instead of a per-election holder-bid price.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent. | 
**PaymentDate** | **DateTimeOffset** | Settlement date for the cash + security legs of the put redemption. | [optional] 
**OfferPrice** | **decimal** | Put price per unit of face value (AMI-SeCo OFFR). Per-100 PRCT semantics —  &#x60;OfferPrice &#x3D; 100.00&#x60; means par; &#x60;97.50&#x60; means 97.5% of par. Must be strictly positive. | 
**Currency** | **string** | Settlement currency of the cash leg (ISO 4217 3-letter code). | 
**CashOfferElections** | [**List&lt;CashOfferElection&gt;**](CashOfferElection.md) | List of possible CashOfferElections. Exactly one entry per event in both Mandatory and Voluntary paths. | 
**LapseElections** | [**List&lt;LapseElection&gt;**](LapseElection.md) | List of possible LapseElections. Exactly one entry for Voluntary (NOAC default). Empty for Mandatory. | 
**MarketDeadlineDate** | **DateTimeOffset?** | Issuer / agent deadline for holder instructions. Required for Voluntary participation;  optional for Mandatory (no holder-deadline concept). | [optional] 
**ResponseDeadlineDate** | **DateTimeOffset?** | Account-servicer deadline. Defaults to MarketDeadlineDate when omitted.  If set, must be on or before MarketDeadlineDate. | [optional] 
**EarlyResponseDeadline** | **DateTimeOffset?** | Early-participation deadline. Rare on BPUT; carried for cross-event consistency.  If set, must be on or before ResponseDeadlineDate. | [optional] 
**ExDate** | **DateTimeOffset?** | AMI-SeCo §4.6 does not list this for BPUT; carried for cross-event consistency.  If set, must be on or before MarketDeadlineDate. | [optional] 
**AnnouncementDate** | **DateTimeOffset?** | Public announcement date. If set, must be on or before ExDate. | [optional] 
**AccruedInterestPerUnit** | **decimal?** | Per-unit accrued interest. Optional — loader / post-processor derives from the bond&#39;s coupon  schedule and day-count when not supplied. EconomicallyComplete enforces non-null for  accrual-bearing instruments via InstrumentTypeAccruesInterest. | [optional] 
**ProrationRate** | **decimal** | Issuer-side aggregate proration cap (AMI-SeCo PROR). Default 1.0; range (0, 1]. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal offerPrice = "offerPrice";

string currency = "currency";
List<CashOfferElection> cashOfferElections = new List<CashOfferElection>();
List<LapseElection> lapseElections = new List<LapseElection>();decimal? prorationRate = "example prorationRate";

PutRedemptionEvent putRedemptionEventInstance = new PutRedemptionEvent(
    paymentDate: paymentDate,
    offerPrice: offerPrice,
    currency: currency,
    cashOfferElections: cashOfferElections,
    lapseElections: lapseElections,
    marketDeadlineDate: marketDeadlineDate,
    responseDeadlineDate: responseDeadlineDate,
    earlyResponseDeadline: earlyResponseDeadline,
    exDate: exDate,
    announcementDate: announcementDate,
    accruedInterestPerUnit: accruedInterestPerUnit,
    prorationRate: prorationRate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
