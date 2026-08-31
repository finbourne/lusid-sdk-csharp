# Lusid.Sdk.Model.CommodityCalendarSwap
LUSID representation of an OTC bilateral commodity calendar swap.  The swap is a strip of periodic commodity forwards struck at a single strike, cash-settled at each  period end against a calendar-average commodity price, with the position amortising as each period  settles. Its present value is Quantity x Price, where the price is supplied externally pre-netted  (the calendar average minus strike) via the quote store. LUSID calculates no analytics for this  instrument, and it can only be priced by lookup pricing. The periodic settlement schedule is  currently stored and validated only; only the maturity lifecycle event is generated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption, CdsOption, CommodityCalendarSwap, BondForward. | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**Strike** | **decimal?** | Agreed price per unit at trade inception. Reference only - not used in the market value  calculation, which consumes the pre-netted price from the quote store. | [optional] 
**CommodityCalendarSchedule** | [**CommodityCalendarSchedule**](CommodityCalendarSchedule.md) |  | 
**DeliveryType** | **string** | Whether the swap settles in cash or through physical delivery of the underlying.  Only cash settlement is supported.                Supported string (enumeration) values are: [Cash, Physical]. Available values: Cash, Physical. | 
**QuantityPerPeriod** | **decimal** | The notional commodity quantity referenced by each settlement period. The initial holding is  this quantity multiplied by the number of periods, stepping down by this quantity as each  period settles. | 
**Underlying** | [**LusidInstrument**](LusidInstrument.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";
CommodityCalendarSchedule commodityCalendarSchedule = new CommodityCalendarSchedule();
string deliveryType = "deliveryType";decimal quantityPerPeriod = "quantityPerPeriod";

LusidInstrument? underlying = new LusidInstrument();


CommodityCalendarSwap commodityCalendarSwapInstance = new CommodityCalendarSwap(
    domCcy: domCcy,
    strike: strike,
    commodityCalendarSchedule: commodityCalendarSchedule,
    deliveryType: deliveryType,
    quantityPerPeriod: quantityPerPeriod,
    underlying: underlying);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
