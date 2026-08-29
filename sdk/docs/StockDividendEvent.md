# Lusid.Sdk.Model.StockDividendEvent
A payment to shareholders that consists of additional shares rather than cash.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentEventType** | **string** | The Type of Event. Available values: TransitionEvent, InformationalEvent, OpenEvent, CloseEvent, StockSplitEvent, BondDefaultEvent, CashDividendEvent, AmortisationEvent, CashFlowEvent, ExerciseEvent, ResetEvent, TriggerEvent, RawVendorEvent, InformationalErrorEvent, BondCouponEvent, DividendReinvestmentEvent, AccumulationEvent, BondPrincipalEvent, DividendOptionEvent, MaturityEvent, FxForwardSettlementEvent, ExpiryEvent, ScripDividendEvent, StockDividendEvent, ReverseStockSplitEvent, CapitalDistributionEvent, SpinOffEvent, MergerEvent, FutureExpiryEvent, SwapCashFlowEvent, SwapPrincipalEvent, CreditPremiumCashFlowEvent, CdsCreditEvent, CdxCreditEvent, MbsCouponEvent, MbsPrincipalEvent, BonusIssueEvent, MbsPrincipalWriteOffEvent, MbsInterestDeferralEvent, MbsInterestShortfallEvent, TenderEvent, CallOnIntermediateSecuritiesEvent, IntermediateSecuritiesDistributionEvent, OptionExercisePhysicalEvent, OptionExerciseCashEvent, ProtectionPayoutCashFlowEvent, TermDepositInterestEvent, TermDepositPrincipalEvent, EarlyRedemptionEvent, FutureMarkToMarketEvent, AdjustGlobalCommitmentEvent, ContractInitialisationEvent, DrawdownEvent, LoanInterestRepaymentEvent, UpdateDepositAmountEvent, LoanPrincipalRepaymentEvent, DepositInterestPaymentEvent, DepositCloseEvent, LoanFacilityContractRolloverEvent, RepurchaseOfferEvent, RepoPartialClosureEvent, RepoCashFlowEvent, FlexibleRepoInterestPaymentEvent, FlexibleRepoCashFlowEvent, FlexibleRepoCollateralEvent, ConversionEvent, FlexibleRepoPartialClosureEvent, FlexibleRepoFullClosureEvent, CapletFloorletCashFlowEvent, EarlyCloseOutEvent, DepositRollEvent, ConsentEvent, DrawingEvent, CapitalGainsDistributionEvent, ExchangeOfferEvent, DutchAuctionEvent, WorthlessEvent, PutRedemptionEvent, LoanFacilityDelayedCompensationPaymentEvent, InterestPaymentEvent, PriorityIssueEvent, ClassActionEvent, BankruptcyEvent, LiquidationPaymentEvent, PartialDefeasanceEvent, SecurityWriteOffEvent, WarrantsExerciseEvent, PariPassuEvent, ChangeEvent, PikBondCouponEvent, PikBondCashCouponEvent, PikBondInterestCapitalisationEvent, PikBondPrincipalEvent, DelistingEvent, PikBondInterestEvent, CommodityForwardCashSettlementEvent, PaymentInKindEvent, CommodityForwardPhysicalSettlementEvent, CancelSwapEvent, BondOptionTerminationEvent, TerminationEvent, CommodityCalendarSwapCashFlowEvent, DepositSweepEvent. | 
**AnnouncementDate** | **DateTimeOffset?** | Date on which the dividend was announced / declared. | [optional] 
**ExDate** | **DateTimeOffset** | The first business day on which the dividend is not owed to the buying party.  Typically this is T-1 from the RecordDate. | [optional] 
**PaymentDate** | **DateTimeOffset** | The date the company pays out dividends to shareholders. | [optional] 
**RecordDate** | **DateTimeOffset?** | Date you have to be the holder of record in order to participate in the tender. | [optional] 
**FractionalUnitsCashPrice** | **decimal?** | The cash price paid in lieu of fractionalUnits. | [optional] 
**FractionalUnitsCashCurrency** | **string** | The currency of the cash paid in lieu of fractionalUnits. | [optional] 
**FractionalUnitsRoundingConvention** | **string** | The convention used to round the fractional units entitlement. Defaults to Floor. Available values: Floor, Ceiling, RoundHalfUp, RoundHalfDown, RoundToDecimalPlaces, BuyUp, BankerRounding. | [optional] 
**FractionalUnitsDecimalPlaces** | **int?** | The number of decimal places to round to when FractionalUnitsRoundingConvention is RoundToDecimalPlaces. | [optional] 
**UnitsRatio** | [**UnitsRatio**](UnitsRatio.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string fractionalUnitsCashCurrency = "example fractionalUnitsCashCurrency";
string fractionalUnitsRoundingConvention = "example fractionalUnitsRoundingConvention";
UnitsRatio unitsRatio = new UnitsRatio();

StockDividendEvent stockDividendEventInstance = new StockDividendEvent(
    announcementDate: announcementDate,
    exDate: exDate,
    paymentDate: paymentDate,
    recordDate: recordDate,
    fractionalUnitsCashPrice: fractionalUnitsCashPrice,
    fractionalUnitsCashCurrency: fractionalUnitsCashCurrency,
    fractionalUnitsRoundingConvention: fractionalUnitsRoundingConvention,
    fractionalUnitsDecimalPlaces: fractionalUnitsDecimalPlaces,
    unitsRatio: unitsRatio);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
