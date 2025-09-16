# Lusid.Sdk.Model.InterestRateSwaption
LUSID representation of an Interest Rate Swaption.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**PayOrReceiveFixed** | **string** | Pay or Receive the fixed leg of the underlying swap.    Supported string (enumeration) values are: [Pay, Receive]. | 
**Premium** | [**Premium**](Premium.md) |  | [optional] 
**DeliveryMethod** | **string** | How does the option settle    Supported string (enumeration) values are: [Cash, Physical]. | 
**Swap** | [**InterestRateSwap**](InterestRateSwap.md) |  | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 
**Underlying** | [**LusidInstrument**](LusidInstrument.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string payOrReceiveFixed = "payOrReceiveFixed";
Premium? premium = new Premium();

string deliveryMethod = "deliveryMethod";
InterestRateSwap? swap = new InterestRateSwap();

TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();

LusidInstrument? underlying = new LusidInstrument();


InterestRateSwaption interestRateSwaptionInstance = new InterestRateSwaption(
    startDate: startDate,
    payOrReceiveFixed: payOrReceiveFixed,
    premium: premium,
    deliveryMethod: deliveryMethod,
    swap: swap,
    timeZoneConventions: timeZoneConventions,
    underlying: underlying);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
