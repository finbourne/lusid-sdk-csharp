# Lusid.Sdk.Model.IncreaseInValueEvent
Increase in Value Event (INCR) — an increase in the face value of a single security, with the number of  securities in circulation unchanged. No cash is paid. The data on the event chooses its shape: with no new  instrument and no units ratio only the par value changes and nothing is booked; with a new instrument at  1 for 1 the holding moves to the new ISIN like for like; with a new instrument and a units ratio above  1 for 1 the holding is split onto the new ISIN.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent, BondForwardCashSettlementEvent, BondForwardTerminationEvent, AmendCommitmentEvent, CapitalCallEvent, FundDistributionEvent, NavReportEvent, DividendSuspensionEvent, LoanInterestCapitalisationEvent, TotalReturnSwapCashFlowEvent, GlobalLoanFacilityReinitialisationEvent, InvestorLoanFacilityReinitialisationEvent, CapitalCallReceiptEvent, RecallableCapitalExpiryEvent, CapitalInterestTransferEvent, FacilityDrawEvent, FacilityRepaymentEvent, FacilityInterestEvent, FacilityCommitmentFeeEvent, InstalmentCallEvent, DepositInterestCapitalisationEvent, PartialRedemptionWithoutReductionOfNominalValueEvent, StripBondCashflowEvent, CapitalisationEvent, SharesPremiumDividendEvent, CashDistributionFromNonEligibleSecuritiesSalesEvent, InflationIndexationEvent, InterestPaymentWithPrincipalEvent, IncreaseInValueEvent. | 
**EffectiveDate** | **DateTimeOffset?** | The date the new par value applies. Required when only the par value changes; optional otherwise. | [optional] 
**AnnouncementDate** | **DateTimeOffset?** | The date the increase in value was announced. | [optional] 
**PreviousParValue** | **decimal?** | The par value per share before the event. Recorded only: it books nothing and writes no property. | [optional] 
**NewParValue** | **decimal?** | The par value per share after the event. Recorded only: it books nothing and writes no property. | [optional] 
**ParValueCurrency** | **string** | The currency of both par values. | [optional] 
**RecordDate** | **DateTimeOffset?** | The entitlement date where the holding moves to a new instrument at 1 for 1, when it is required.  Optional where the units ratio is above 1 for 1. Must be null when only the par value changes. | [optional] 
**ExDate** | **DateTimeOffset?** | The entitlement date where the units ratio is above 1 for 1, when it is required. Must be null otherwise. | [optional] 
**PaymentDate** | **DateTimeOffset?** | The date the holder receives the units. Required with a units ratio; must be null when only the par  value changes. | [optional] 
**NewInstrument** | [**NewInstrument**](NewInstrument.md) |  | [optional] 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | [optional] 
**ParValuePropertyKey** | **string** | The key of the instrument property that holds the par value, for example Instrument/Ops/ParValue. It is  left out of the copy of the old instrument&#39;s properties, so the new instrument keeps its own value.  Required where the holding moves to a new instrument at 1 for 1; must be null otherwise. | [optional] 
**CarryRelationships** | **string** | Whether, and in which direction, the old instrument&#39;s relationships are carried onto the new instrument  at 1 for 1: None, Outward or Both. When not supplied, the outward relationships are carried. Must be  null in every other shape. Available values: None, Outward, Both. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string parValueCurrency = "example parValueCurrency";
NewInstrument? newInstrument = new NewInstrument();

UnitsRatio? unitsRatio = new UnitsRatio();

string parValuePropertyKey = "example parValuePropertyKey";
string carryRelationships = "example carryRelationships";

IncreaseInValueEvent increaseInValueEventInstance = new IncreaseInValueEvent(
    effectiveDate: effectiveDate,
    announcementDate: announcementDate,
    previousParValue: previousParValue,
    newParValue: newParValue,
    parValueCurrency: parValueCurrency,
    recordDate: recordDate,
    exDate: exDate,
    paymentDate: paymentDate,
    newInstrument: newInstrument,
    unitsRatio: unitsRatio,
    parValuePropertyKey: parValuePropertyKey,
    carryRelationships: carryRelationships);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
