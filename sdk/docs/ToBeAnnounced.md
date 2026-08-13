# Lusid.Sdk.Model.ToBeAnnounced
LUSID representation of a TBA (To Be Announced) forward contract for generic agency mortgage-backed securities.  Valued as Quantity x Price via EOD quote lookup; carries no coupon cashflows, accrual or factor.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption. | 
**StartDate** | **DateTimeOffset** | The trade inception date of the TBA. | 
**MaturityDate** | **DateTimeOffset** | The contractual settlement date of the TBA (e.g. the agency&#39;s announced settlement date for the month). | 
**DomCcy** | **string** | The domestic currency of the TBA. | 
**Agency** | **string** | The issuing agency of the underlying generic collateral, e.g. \&quot;FNMA\&quot;, \&quot;FHLMC\&quot;, \&quot;GNMA\&quot;.  Note this property does not impact valuation. From a LUSID analytics perspective, it is purely informational. | [optional] 
**Coupon** | **decimal?** | The stated coupon rate of the underlying generic collateral, e.g. 3.0, 4.5.  Note this property does not impact valuation - there are no coupon cash flows on the TBA itself.  From a LUSID analytics perspective, it is purely informational. | [optional] 
**Tenor** | **string** | The tenor of the underlying generic collateral, e.g. \&quot;30Y\&quot;, \&quot;15Y\&quot;.  Note this property does not impact valuation. From a LUSID analytics perspective, it is purely informational. | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 
**TradingConventions** | [**TradingConventions**](TradingConventions.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";
string agency = "example agency";
string tenor = "example tenor";
TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();

TradingConventions? tradingConventions = new TradingConventions();


ToBeAnnounced toBeAnnouncedInstance = new ToBeAnnounced(
    startDate: startDate,
    maturityDate: maturityDate,
    domCcy: domCcy,
    agency: agency,
    coupon: coupon,
    tenor: tenor,
    timeZoneConventions: timeZoneConventions,
    tradingConventions: tradingConventions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
