# Lusid.Sdk.Model.ForwardRateAgreement
LUSID representation of a Forward Rate Agreement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo | 
**StartDate** | **DateTimeOffset** | The settlement date of the FRA | 
**MaturityDate** | **DateTimeOffset** | The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date. | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**FixingDate** | **DateTimeOffset** | The date at which the rate to be paid, the reference rate, is confirmed/observed. | 
**FraRate** | **decimal** | The rate at which the FRA is traded. | 
**Notional** | **decimal** | The amount for which the FRA is traded. | 
**IndexConvention** | [**IndexConvention**](IndexConvention.md) |  | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";decimal fraRate = "fraRate";
decimal notional = "notional";

IndexConvention? indexConvention = new IndexConvention();

TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();


ForwardRateAgreement forwardRateAgreementInstance = new ForwardRateAgreement(
    startDate: startDate,
    maturityDate: maturityDate,
    domCcy: domCcy,
    fixingDate: fixingDate,
    fraRate: fraRate,
    notional: notional,
    indexConvention: indexConvention,
    timeZoneConventions: timeZoneConventions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
