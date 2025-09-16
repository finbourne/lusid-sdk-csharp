# Lusid.Sdk.Model.FlexibleDeposit
LUSID flexible deposit instrument. Represents the basic building block of a bank account  structure that can handle deferred interest payments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**MaturityDate** | **DateTimeOffset** | The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it. | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**Schedules** | [**List&lt;Schedule&gt;**](Schedule.md) | Repayment schedules for the deposit instrument. | 
**TradingConventions** | [**TradingConventions**](TradingConventions.md) |  | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";
List<Schedule> schedules = new List<Schedule>();
TradingConventions? tradingConventions = new TradingConventions();

TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();


FlexibleDeposit flexibleDepositInstance = new FlexibleDeposit(
    startDate: startDate,
    maturityDate: maturityDate,
    domCcy: domCcy,
    schedules: schedules,
    tradingConventions: tradingConventions,
    timeZoneConventions: timeZoneConventions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
