# Lusid.Sdk.Model.InterestRateSwaption
LUSID representation of an Interest Rate Swaption.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption, CdsOption, CommodityCalendarSwap, BondForward. | 
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
**DomCcy** | **string** | The currency the option settles in.                Optional, and in almost all cases it should be left to default. If not specified, the currency of  the underlying swap is used, which for a cross-currency swap is the currency of its first leg.                A specified currency is taken as given and is not validated against the underlying swap, since  settling in another currency is rare but legitimate. Note that valuation of such a swaption is not  supported, as converting from the currency the swap is valued in needs an fx rate the instrument  does not define. | [optional] 
**ExerciseDate** | **DateTimeOffset?** | The date the option expires, and for European exercise the date it is exercised. For American  exercise it is the end of the window the option may be exercised in, so it should be set on the  instrument for the option to be exercisable up to the intended date.                If not specified, the start date of the underlying swap is used. | [optional] 
**ExerciseType** | **string** | Type of optionality that is present; European, American.                Supported string (enumeration) values are: [European, American].  Defaults to \&quot;European\&quot; if not set.                A European option is exercised on its exercise date, so its exercise event is generated with  that date already set. An American option may be exercised at any point up to that date, so the  date it is actually exercised on is supplied on the exercise event; set exerciseDate on the  instrument to open the window the event may fall in.                The swap delivered on exercise keeps the start date it was defined with, so exercising early  or late leaves it aged or forward-starting relative to the exercise. Keeping that swap  correct for the intended exercise is the responsibility of whoever defines it. In particular,  for an American physically settled swaption on a cross-currency underlying, neither the swap&#39;s  start date nor its fx notionals are determined at trade time, so amending the delivered swap  position after exercise is an operational step the client must carry out. | [optional] 
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
