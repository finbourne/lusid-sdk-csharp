# Lusid.Sdk.Model.PreferredShare
LUSID representation of a preferred (preference) share: an equity-classified security that pays an  intrinsic, schedule-driven dividend of DividendRate x ParValue. The schedule is perpetual unless a  MaturityDate is supplied, in which case the share redeems at par on that date.  It carries Bond's shape rather than Equity's - StartDate, MaturityDate and FlowConventions are real,  settable properties - but its dividend is a flat amount per period rather than a day-count-weighted  coupon, and its schedule can be open ended.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption, CdsOption, CommodityCalendarSwap, BondForward, PreferredShare. | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is the first dividend accrual start date. | 
**MaturityDate** | **DateTimeOffset** | The redemption date of a dated series. Omit it for a perpetual, which is the default: there is  no sentinel date for the client to supply, and a distant date such as one in the year 9999 is  taken literally and schedules a par redemption on it. | [optional] 
**FlowConventions** | [**FlowConventions**](FlowConventions.md) |  | 
**Identifiers** | [**PreferredShareAllOfIdentifiers**](PreferredShareAllOfIdentifiers.md) |  | [optional] 
**DomCcy** | **string** | The domestic currency of the instrument. It is the currency of the dividends and of ParValue. | 
**CallSchedule** | [**OptionalitySchedule**](OptionalitySchedule.md) |  | [optional] 
**CfiCode** | **string** | The ISO 10962 CFI code, if the client stores one. Free text, not validated against the standard. | [optional] 
**ConversionSchedule** | [**BondConversionSchedule**](BondConversionSchedule.md) |  | [optional] 
**DividendRate** | **decimal** | The fixed annualised dividend rate applied to ParValue, so 0.06 is 6%. A scalar for the life of  the share: there is no rate reset, so a fixed-to-floating preferred carries the rate for the  current period and is re-upserted at each reset. | 
**FirstDividendDate** | **DateTimeOffset?** | Anchors a short or long first dividend period. Omitted means no stub. | [optional] 
**IsCumulative** | **bool** | Whether a missed dividend accumulates as arrears rather than being forfeited. The client must  state it; there is no default. | 
**LotSize** | **int** | The minimum number of shares that can be traded at once. Microstructure only: it has no effect  on valuation or on cash flows. Defaults to 1. | [optional] 
**ParValue** | **decimal** | The liquidation preference per share. It is the base for the dividend, for the call strike and  for the redemption amount. It is not a price multiplier. | 

```csharp
using Lusid.Sdk.Model;
using System;

FlowConventions flowConventions = new FlowConventions();
PreferredShareAllOfIdentifiers? identifiers = new PreferredShareAllOfIdentifiers();

string domCcy = "domCcy";
OptionalitySchedule? callSchedule = new OptionalitySchedule();

string cfiCode = "example cfiCode";
BondConversionSchedule? conversionSchedule = new BondConversionSchedule();
decimal dividendRate = "dividendRate";

bool isCumulative = //"True";decimal parValue = "parValue";


PreferredShare preferredShareInstance = new PreferredShare(
    startDate: startDate,
    maturityDate: maturityDate,
    flowConventions: flowConventions,
    identifiers: identifiers,
    domCcy: domCcy,
    callSchedule: callSchedule,
    cfiCode: cfiCode,
    conversionSchedule: conversionSchedule,
    dividendRate: dividendRate,
    firstDividendDate: firstDividendDate,
    isCumulative: isCumulative,
    lotSize: lotSize,
    parValue: parValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
