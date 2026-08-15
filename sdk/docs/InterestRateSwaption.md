# Lusid.Sdk.Model.InterestRateSwaption
LUSID representation of an Interest Rate Swaption.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption, CdsOption, CommodityCalendarSwap. | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**PayOrReceiveFixed** | **string** | Pay or Receive the fixed leg of the underlying swap.    Supported string (enumeration) values are: [Pay, Receive]. | 
**Premium** | [**Premium**](Premium.md) |  | [optional] 
**DeliveryMethod** | **string** | How does the option settle    Supported string (enumeration) values are: [Cash, Physical]. | 
**Swap** | [**InterestRateSwap**](InterestRateSwap.md) |  | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 
**Underlying** | [**LusidInstrument**](LusidInstrument.md) |  | [optional] 
**DeliveryDays** | **int** | Number of business days between exercise date and settlement of the option payoff or underlying.                Defaults to 0. | [optional] 
**BusinessDayConvention** | **string** | Business day convention for option exercise date to settlement date calculation.  Default value: F. Available values: NoAdjustment, None, Previous, P, Following, F, ModifiedPrevious, MP, ModifiedFollowing, MF, HalfMonthModifiedFollowing, Nearest, Invalid. | [optional] 
**SettlementCalendars** | **List&lt;string&gt;** | Holiday calendars for option exercise date to settlement date calculation. | [optional] 
**DomCcy** | **string** | The currency the option settles in.                If not specified, the currency of the underlying swap is used. When specified it must be one of  the currencies of the underlying swap. | [optional] 
**ExerciseDate** | **DateTimeOffset?** | The date the option expires, and for European exercise the date it is exercised.                If not specified, the start date of the underlying swap is used. | [optional] 
**ExerciseType** | **string** | Type of optionality that is present; European, American.                Supported string (enumeration) values are: [European, American].  Defaults to \&quot;European\&quot; if not set.                A European option is exercised on its exercise date, so its exercise event is generated with  that date already set. An American option may be exercised at any point in its life, so it  carries no scheduled date and the exercise date is supplied on the exercise event instead.                The swap delivered on exercise keeps the start date it was defined with, so exercising early  or late leaves it aged or forward-starting relative to the exercise. Keeping that swap  correct for the intended exercise is the responsibility of whoever defines it. | [optional] 
**Strike** | **decimal?** | The rate the option strikes against.                May only be specified when the underlying swap has no single fixed leg, as otherwise that leg&#39;s  fixed rate is the strike. It must be specified when the underlying swap has two fixed legs, as  there is then no single rate to strike against. | [optional] 
**TradingConventions** | [**TradingConventions**](TradingConventions.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string payOrReceiveFixed = "payOrReceiveFixed";
Premium? premium = new Premium();

string deliveryMethod = "deliveryMethod";
InterestRateSwap? swap = new InterestRateSwap();

TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();

LusidInstrument? underlying = new LusidInstrument();

string businessDayConvention = "example businessDayConvention";
List<string> settlementCalendars = new List<string>();
string domCcy = "example domCcy";
string exerciseType = "example exerciseType";
TradingConventions? tradingConventions = new TradingConventions();


InterestRateSwaption interestRateSwaptionInstance = new InterestRateSwaption(
    startDate: startDate,
    payOrReceiveFixed: payOrReceiveFixed,
    premium: premium,
    deliveryMethod: deliveryMethod,
    swap: swap,
    timeZoneConventions: timeZoneConventions,
    underlying: underlying,
    deliveryDays: deliveryDays,
    businessDayConvention: businessDayConvention,
    settlementCalendars: settlementCalendars,
    domCcy: domCcy,
    exerciseDate: exerciseDate,
    exerciseType: exerciseType,
    strike: strike,
    tradingConventions: tradingConventions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
