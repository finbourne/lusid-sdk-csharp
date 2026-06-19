# Lusid.Sdk.Model.DutchAuctionEvent
Dutch Auction Event (DTCH) — a voluntary corporate action with price-discovery, proration,  and per-holder bid audit. Tri-modal: CASH (uniform clearing-price cash buyback via  TenderOfferElection), SECU (clean security-for-security exchange via SecurityOfferElection),  or CASE (security exchange with signed per-unit cash settlement via CashAndSecurityOfferElection).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent. | 
**PaymentDate** | **DateTimeOffset** | Settlement date for both the security and cash legs of the auction. | [optional] 
**MarketDeadlineDate** | **DateTimeOffset** | Issuer or acquirer instruction deadline. | [optional] 
**Currency** | **string** | Event settlement currency (ISO 4217). | 
**TenderOfferElections** | [**List&lt;TenderOfferElection&gt;**](TenderOfferElection.md) | List of possible TenderOfferElections for this event. Populated on the CASH path (Count &#x3D;&#x3D; 1);  empty on the SECU and CASE paths. | [optional] 
**SecurityOfferElections** | [**List&lt;SecurityOfferElection&gt;**](SecurityOfferElection.md) | List of possible SecurityOfferElections for this event. Populated on the SECU path (Count &#x3D;&#x3D; 1);  empty on the CASH and CASE paths. | [optional] 
**CashAndSecurityOfferElections** | [**List&lt;CashAndSecurityOfferElection&gt;**](CashAndSecurityOfferElection.md) | List of possible CashAndSecurityOfferElections for this event. Populated on the CASE path  (Count &#x3D;&#x3D; 1); empty on the CASH and SECU paths. | [optional] 
**LapseElections** | [**List&lt;LapseElection&gt;**](LapseElection.md) | List of possible LapseElections for this event. Required on all three paths (Count &#x3D;&#x3D; 1).  Allows the holder to opt out of the offer (NOAC). | [optional] 
**ResponseDeadlineDate** | **DateTimeOffset?** | Account-servicer response deadline. Defaults to MarketDeadlineDate when not supplied.  When provided, must be on or before MarketDeadlineDate. | [optional] 
**EarlyResponseDeadline** | **DateTimeOffset?** | Early-participation deadline. When provided, must be on or before ResponseDeadlineDate. | [optional] 
**ExDate** | **DateTimeOffset?** | The ex date of the event. Optional; carried for cross-event consistency. | [optional] 
**RecordDate** | **DateTimeOffset?** | The record date of the event. Optional and not required by AMI-SeCo for DTCH  (the event is instruction-driven via QINS, not record-date-driven). | [optional] 
**AnnouncementDate** | **DateTimeOffset?** | Public announcement date of the auction. Optional. | [optional] 
**TargetQuantity** | **decimal?** | Total quantity of securities sought by the issuer or acquirer. Optional. | [optional] 
**ProrationRate** | **decimal** | Proportional adjustment applied to the security and cash legs on all paths.  Must be in (0, 1]. | [optional] 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | [optional] 
**FractionalUnitsCashPrice** | **decimal?** | Cash-in-lieu price per fractional unit on the SECU and CASE paths.  Null indicates round-down disposition of fractional remainders.  Distinct from the CASE path&#39;s main cash settlement (which lives on CashAndSecurityOfferElection). | [optional] 
**FractionalUnitsCashCurrency** | **string** | Currency of the cash-in-lieu paid on fractional remainders on the SECU and CASE paths.  Required when FractionalUnitsCashPrice is non-null. | [optional] 
**BidPrice** | **decimal?** | Per-holder bid price submitted at instruction time. Audit-only; no calculation impact. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "currency";
List<TenderOfferElection> tenderOfferElections = new List<TenderOfferElection>();
List<SecurityOfferElection> securityOfferElections = new List<SecurityOfferElection>();
List<CashAndSecurityOfferElection> cashAndSecurityOfferElections = new List<CashAndSecurityOfferElection>();
List<LapseElection> lapseElections = new List<LapseElection>();decimal? prorationRate = "example prorationRate";
NewInstrument? newInstrument = new NewInstrument();

string fractionalUnitsCashCurrency = "example fractionalUnitsCashCurrency";

DutchAuctionEvent dutchAuctionEventInstance = new DutchAuctionEvent(
    paymentDate: paymentDate,
    marketDeadlineDate: marketDeadlineDate,
    currency: currency,
    tenderOfferElections: tenderOfferElections,
    securityOfferElections: securityOfferElections,
    cashAndSecurityOfferElections: cashAndSecurityOfferElections,
    lapseElections: lapseElections,
    responseDeadlineDate: responseDeadlineDate,
    earlyResponseDeadline: earlyResponseDeadline,
    exDate: exDate,
    recordDate: recordDate,
    announcementDate: announcementDate,
    targetQuantity: targetQuantity,
    prorationRate: prorationRate,
    newInstrument: newInstrument,
    fractionalUnitsCashPrice: fractionalUnitsCashPrice,
    fractionalUnitsCashCurrency: fractionalUnitsCashCurrency,
    bidPrice: bidPrice);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
