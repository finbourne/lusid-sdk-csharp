# Lusid.Sdk.Model.CdsOption
LUSID representation of an option on a single-name Credit Default Swap or a CDX/iTraxx index,  discriminated by the MasteredInstrumentType field of the referenced MasteredInstrument, which is derived  from the resolved type of the underlying. Referenced via a MasteredInstrument.  Quote-driven by default: it has no coupon or projected interim cashflow, its only cash movement being  the spot premium.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption, CdsOption, CommodityCalendarSwap, BondForward, PreferredShare. | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**Strike** | **decimal** | The strike of the option. | 
**BusinessDayConvention** | **string** | Business day convention for the maturity-to-settlement date calculation.  Default value: F.                Supported string (enumeration) values are: [NoAdjustment, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing, Nearest]. Default value: F. Available values: NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing, Nearest, Invalid. | [optional] [default to "F"]
**DeliveryDays** | **int** | Number of business days between the option maturity date and settlement, used to compute  OptionSettlementDate when not explicitly overridden. Defaults to 2 if not set. | [optional] [default to 2]
**DeliveryType** | **string** | Is the option cash settled or physical delivery of the underlying.                Supported string (enumeration) values are: [Cash, Physical]. Available values: Cash, Physical. | 
**ExerciseType** | **string** | Type of optionality that is present; European only in this scope.  Default value: European.                Supported string (enumeration) values are: [European, Bermudan, American]. Default value: European. Available values: None, European, Bermudan, American. | [optional] [default to "European"]
**Notional** | **decimal** | Fixed per-unit reference multiplier. Aggregate exposure &#x3D; Holding/Units x Notional; not a mutable total. | 
**OptionMaturityDate** | **DateTimeOffset** | The last exercise date of the option. | 
**OptionSettlementDate** | **DateTimeOffset?** | Explicit override of the option&#39;s settlement date. If not supplied, it is computed as a  business-day-adjusted delivery of DeliveryDays after OptionMaturityDate. | [optional] 
**OptionType** | **string** | The direction of the credit option: Payer or Receiver.                Supported string (enumeration) values are: [Payer, Receiver]. Available values: Payer, Receiver. | 
**Premium** | [**Premium**](Premium.md) |  | [optional] 
**SettlementCalendars** | **List&lt;string&gt;** | Holiday calendars for the maturity-to-settlement date calculation. | [optional] 
**Underlying** | [**MasteredInstrument**](MasteredInstrument.md) |  | [optional] 
**UnderlyingVersion** | **DateTimeOffset** | The AsAt timestamp of the underlying&#39;s definition at the time this option was written, pinning  lookups of the underlying&#39;s composition and terms independently of subsequent index rolls or re-upserts. | 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";decimal strike = "strike";

string businessDayConvention = "example businessDayConvention";
string deliveryType = "deliveryType";
string exerciseType = "example exerciseType";decimal notional = "notional";

string optionType = "optionType";
Premium? premium = new Premium();

List<string> settlementCalendars = new List<string>();
MasteredInstrument? underlying = new MasteredInstrument();


CdsOption cdsOptionInstance = new CdsOption(
    startDate: startDate,
    domCcy: domCcy,
    strike: strike,
    businessDayConvention: businessDayConvention,
    deliveryDays: deliveryDays,
    deliveryType: deliveryType,
    exerciseType: exerciseType,
    notional: notional,
    optionMaturityDate: optionMaturityDate,
    optionSettlementDate: optionSettlementDate,
    optionType: optionType,
    premium: premium,
    settlementCalendars: settlementCalendars,
    underlying: underlying,
    underlyingVersion: underlyingVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
