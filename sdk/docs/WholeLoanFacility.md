# Lusid.Sdk.Model.WholeLoanFacility
Whole Loan Facility. A loan facility wholly funded by a single lender: it shares the contractual terms of a  LoanFacility, but ownership is not shared pro-rata across investors. Like a LoanFacility, this is a lightweight  instrument; the state of the facility is carried by the holding rather than by the instrument itself.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | Available values: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo, ToBeAnnounced, VolatilitySwap, ToBeAnnouncedOption, CommodityForward, BondOption, CdsOption, CommodityCalendarSwap, BondForward, PreferredShare, CapitalInterest, WholeLoanFacility. | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**MaturityDate** | **DateTimeOffset** | The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it. | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**InitialCommitment** | **decimal** | The initial commitment for the whole loan facility. | 
**LoanType** | **string** | LoanType for this facility. The facility can either be a revolving or a  term loan. Available values: Revolver, TermLoan. | 
**Schedules** | [**List&lt;Schedule&gt;**](Schedule.md) | Repayment schedules for the facility. | 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";decimal initialCommitment = "initialCommitment";

string loanType = "loanType";
List<Schedule> schedules = new List<Schedule>();
TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();


WholeLoanFacility wholeLoanFacilityInstance = new WholeLoanFacility(
    startDate: startDate,
    maturityDate: maturityDate,
    domCcy: domCcy,
    initialCommitment: initialCommitment,
    loanType: loanType,
    schedules: schedules,
    timeZoneConventions: timeZoneConventions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
