# Lusid.Sdk.Model.TenderEvent
Tender Event (TEND).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent. | 
**AnnouncementDate** | **DateTimeOffset?** | The date the tender is announced. | [optional] 
**ExDate** | **DateTimeOffset** | The ex date (entitlement date) of the event. | [optional] 
**RecordDate** | **DateTimeOffset?** | Date you have to be the holder of record in order to participate in the tender. | [optional] 
**PaymentDate** | **DateTimeOffset** | The payment date of the event. | [optional] 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | 
**FractionalUnitsCashPrice** | **decimal?** | The cash price paid in lieu of fractionalUnits. | [optional] 
**FractionalUnitsCashCurrency** | **string** | The currency of the cash paid in lieu of fractionalUnits. | [optional] 
**SecurityOfferElections** | [**List&lt;SecurityOfferElection&gt;**](SecurityOfferElection.md) | List of possible SecurityOfferElections for this event. | [optional] 
**CashAndSecurityOfferElections** | [**List&lt;CashAndSecurityOfferElection&gt;**](CashAndSecurityOfferElection.md) | List of possible CashAndSecurityOfferElections for this event. | [optional] 
**CashOfferElections** | [**List&lt;CashOfferElection&gt;**](CashOfferElection.md) | List of possible CashOfferElections for this event. | [optional] 
**OfferType** | **string** | Informational ISO 20022 OfferTp indicator (e.g. \&quot;ACPR\&quot;). Optional. No calculation impact. | [optional] 
**AccruedInterestPerUnit** | **decimal?** | Optional per-unit accrued interest on the tendered face, from the last coupon date up to  (but excluding) PaymentDate. Bond instrument types only. If left empty, analytics-core  resolves it at event time from the bond&#39;s coupon schedule and market data. | [optional] 
**MinPieceSize** | **decimal?** | Bond-specific minimum instructable face amount. Optional. Must be strictly positive when set. | [optional] 
**MinIncrement** | **decimal?** | Bond-specific increment above MinPieceSize. Optional. When set, MinPieceSize must also be set.  Must be strictly positive. | [optional] 
**ProrationRate** | **decimal** | Proration applied when the offer is oversubscribed. Defaults to 1 if not set.  Must be greater than 0 and less than or equal to 1. | [optional] [default to 1D]
**ResponseDeadlineDate** | **DateTimeOffset?** | Account-servicer SLA deadline for holder instruction. Optional at the DTO layer;  required under Voluntary participation on bond instrument types. | [optional] 
**MarketDeadlineDate** | **DateTimeOffset?** | Offeror&#39;s-agent deadline for holder instruction. Optional at the DTO layer;  required under Voluntary participation on bond instrument types. | [optional] 
**EarlyResponseDeadline** | **DateTimeOffset?** | Optional early-tender deadline. When set, must be on or before ResponseDeadlineDate. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

NewInstrument newInstrument = new NewInstrument();
string fractionalUnitsCashCurrency = "example fractionalUnitsCashCurrency";
List<SecurityOfferElection> securityOfferElections = new List<SecurityOfferElection>();
List<CashAndSecurityOfferElection> cashAndSecurityOfferElections = new List<CashAndSecurityOfferElection>();
List<CashOfferElection> cashOfferElections = new List<CashOfferElection>();
string offerType = "example offerType";decimal? prorationRate = "example prorationRate";

TenderEvent tenderEventInstance = new TenderEvent(
    announcementDate: announcementDate,
    exDate: exDate,
    recordDate: recordDate,
    paymentDate: paymentDate,
    newInstrument: newInstrument,
    fractionalUnitsCashPrice: fractionalUnitsCashPrice,
    fractionalUnitsCashCurrency: fractionalUnitsCashCurrency,
    securityOfferElections: securityOfferElections,
    cashAndSecurityOfferElections: cashAndSecurityOfferElections,
    cashOfferElections: cashOfferElections,
    offerType: offerType,
    accruedInterestPerUnit: accruedInterestPerUnit,
    minPieceSize: minPieceSize,
    minIncrement: minIncrement,
    prorationRate: prorationRate,
    responseDeadlineDate: responseDeadlineDate,
    marketDeadlineDate: marketDeadlineDate,
    earlyResponseDeadline: earlyResponseDeadline);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
