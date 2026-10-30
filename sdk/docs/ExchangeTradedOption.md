# Lusid.Sdk.Model.ExchangeTradedOption
LUSID representation of an Exchange Traded Option.  Including, but not limited to, Equity Options, Bond Options, Index Options, Future Options, and Interest Rate Options.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption, CdsOption, CommodityCalendarSwap, BondForward, PreferredShare, CapitalInterest, WholeLoanFacility, StripBond. | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**ContractDetails** | [**ExchangeTradedOptionContractDetails**](ExchangeTradedOptionContractDetails.md) |  | 
**Contracts** | **decimal** | The number of contracts held. | 
**RefSpotPrice** | **decimal?** | The reference price at which the contract was entered into. Optional.  If omitted, the option has no reference price of its own.  Under ConstantTimeValueOfMoney, a holding with a notional cost (for example from Transaction/default/NotionalAmount) is then valued like a future, against its notional cost plus the variation margin settled to date.  A holding without a notional cost is then valued at its full market price.  If 0, the reference is taken from the holding&#39;s cost.  Any other value is used as given.  Writes through Luminesce that do not supply RefSpotPrice store 0. | [optional] 
**TradingConventions** | [**TradingConventions**](TradingConventions.md) |  | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ExchangeTradedOptionContractDetails contractDetails = new ExchangeTradedOptionContractDetails();decimal contracts = "contracts";

TradingConventions? tradingConventions = new TradingConventions();

TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();


ExchangeTradedOption exchangeTradedOptionInstance = new ExchangeTradedOption(
    startDate: startDate,
    contractDetails: contractDetails,
    contracts: contracts,
    refSpotPrice: refSpotPrice,
    tradingConventions: tradingConventions,
    timeZoneConventions: timeZoneConventions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
