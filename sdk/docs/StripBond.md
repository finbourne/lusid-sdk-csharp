# Lusid.Sdk.Model.StripBond
A stripped bond: an entitlement to one side of a mastered parent bond's cash flows. An interest-only strip  receives the interest the parent pays, on a notional that runs down with the parent's principal; a  principal-only strip receives the parent's principal and none of its interest. The strip carries no schedule,  coupon or conventions of its own: it points at the parent through a MasteredInstrument and reads the parent's  cash flows, pool factor, dates and conventions from the parent's live definition, so a re-upsert of the parent  reaches every strip on it. One unit of a strip is one unit of the parent's original face.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption, CdsOption, CommodityCalendarSwap, BondForward, PreferredShare, CapitalInterest, WholeLoanFacility, StripBond. | 
**AllowNegativeYield** | **bool?** | Whether a negative effective yield books negative income. Null means false: a negative effective yield is  then applied as zero, so the whole receipt returns capital. | [optional] 
**StripType** | **string** | Which side of the parent&#39;s flows the strip receives: InterestOnly receives the parent&#39;s interest,  PrincipalOnly receives the parent&#39;s principal.                Supported string (enumeration) values are: [InterestOnly, PrincipalOnly]. Available values: InterestOnly, PrincipalOnly. | 
**TradingConventions** | [**TradingConventions**](TradingConventions.md) |  | [optional] 
**Underlying** | [**LusidInstrument**](LusidInstrument.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

bool? allowNegativeYield = //"True";
string stripType = "stripType";
TradingConventions? tradingConventions = new TradingConventions();

LusidInstrument underlying = new LusidInstrument();

StripBond stripBondInstance = new StripBond(
    allowNegativeYield: allowNegativeYield,
    stripType: stripType,
    tradingConventions: tradingConventions,
    underlying: underlying);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
