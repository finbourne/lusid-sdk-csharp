# Lusid.Sdk.Model.BondOption
LUSID representation of an OTC bilateral option (call or put) on a single mastered cash bond  (Bond, ComplexBond or InflationLinkedBond). Quote-driven valuation with an upfront premium;  European exercise only, cash-settled in the current scope (physical settlement is future work).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption. | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**Strike** | **decimal** | The strike as a clean price, percent of par (real/unindexed for a linker). | 
**ContractSize** | **decimal** | The face amount per contract (e.g. 1,000,000). Together with the per-100 clean-price strike this  turns the strike and payoff into money: strikePerUnit &#x3D; strike / 100 * contractSize. | 
**DeliveryType** | **string** | How does the option settle. Only Cash is supported for a BondOption.                Supported string (enumeration) values are: [Cash, Physical]. | 
**ExerciseDates** | **List&lt;DateTimeOffset&gt;** | The exercise dates; exactly one entry, equal to the expiry date (European only in scope). | 
**ExerciseType** | **string** | Type of optionality that is present. Only European is supported for a BondOption.                Supported string (enumeration) values are: [European, Bermudan, American]. | [optional] 
**ExpiryDate** | **DateTimeOffset** | This is the date when the option expires, i.e. the LAST exercise date of the option.  The property is internal, we may change it in the future (think about Bermuda options). | 
**OptionType** | **string** | Type of optionality for the option.                Supported string (enumeration) values are: [Call, Put]. | 
**Premium** | [**Premium**](Premium.md) |  | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 
**TradingConventions** | [**TradingConventions**](TradingConventions.md) |  | [optional] 
**Underlying** | [**LusidInstrument**](LusidInstrument.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";decimal strike = "strike";
decimal contractSize = "contractSize";

string deliveryType = "deliveryType";
List<DateTimeOffset> exerciseDates = new List<DateTimeOffset>();
string exerciseType = "example exerciseType";
string optionType = "optionType";
Premium? premium = new Premium();

TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();

TradingConventions? tradingConventions = new TradingConventions();

LusidInstrument underlying = new LusidInstrument();

BondOption bondOptionInstance = new BondOption(
    startDate: startDate,
    domCcy: domCcy,
    strike: strike,
    contractSize: contractSize,
    deliveryType: deliveryType,
    exerciseDates: exerciseDates,
    exerciseType: exerciseType,
    expiryDate: expiryDate,
    optionType: optionType,
    premium: premium,
    timeZoneConventions: timeZoneConventions,
    tradingConventions: tradingConventions,
    underlying: underlying);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
