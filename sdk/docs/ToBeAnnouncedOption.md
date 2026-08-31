# Lusid.Sdk.Model.ToBeAnnouncedOption
LUSID representation of an OTC option on a ToBeAnnounced (TBA) forward contract.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption, CdsOption, CommodityCalendarSwap, BondForward. | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**ExpiryDate** | **DateTimeOffset** | The date on which the option expires, i.e. the last exercise date of the option. | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**OptionType** | **string** | Type of optionality for the option.                Supported string (enumeration) values are: [Call, Put]. | 
**Strike** | **decimal** | The strike of the option. | 
**DeliveryType** | **string** | Is the option cash settled or physical delivery of the underlying TBA.                Supported string (enumeration) values are: [Cash, Physical]. | 
**Underlying** | [**MasteredInstrument**](MasteredInstrument.md) |  | 
**ExerciseType** | **string** | Type of optionality that is present; European only in this scope.                Supported string (enumeration) values are: [European]. | 
**Premium** | [**Premium**](Premium.md) |  | 
**DeliveryDays** | **int** | Number of business days between exercise date and settlement of the option payoff or underlying.  Defaults to 0 if not set. | [optional] 
**BusinessDayConvention** | **string** | Business day convention for option exercise date to settlement date calculation.  Default value: F. Available values: NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing, Nearest, Invalid. | [optional] 
**SettlementCalendars** | **List&lt;string&gt;** | Holiday calendar for option exercise date to settlement date calculation. | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 
**TradingConventions** | [**TradingConventions**](TradingConventions.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";
string optionType = "optionType";decimal strike = "strike";

string deliveryType = "deliveryType";
MasteredInstrument underlying = new MasteredInstrument();
string exerciseType = "exerciseType";
Premium premium = new Premium();
string businessDayConvention = "example businessDayConvention";
List<string> settlementCalendars = new List<string>();
TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();

TradingConventions? tradingConventions = new TradingConventions();


ToBeAnnouncedOption toBeAnnouncedOptionInstance = new ToBeAnnouncedOption(
    startDate: startDate,
    expiryDate: expiryDate,
    domCcy: domCcy,
    optionType: optionType,
    strike: strike,
    deliveryType: deliveryType,
    underlying: underlying,
    exerciseType: exerciseType,
    premium: premium,
    deliveryDays: deliveryDays,
    businessDayConvention: businessDayConvention,
    settlementCalendars: settlementCalendars,
    timeZoneConventions: timeZoneConventions,
    tradingConventions: tradingConventions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
