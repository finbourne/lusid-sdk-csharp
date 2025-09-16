# Lusid.Sdk.Model.FxOption
LUSID representation of an FX Option.  Including Vanilla, American, European, and Digital (Binary) options.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**DomAmount** | **decimal?** | The Amount of DomCcy that will be exchanged if the option is exercised.  This amount should be a positive number, with the Call/Put flag used to indicate direction.  The corresponding amount of FgnCcy that will be exchanged is this amount times the strike.  Note there is no rounding performed on this computed value.  This is an optional field, if not set the option ContractSize will default to 1. | [optional] 
**FgnCcy** | **string** | The foreign currency of the FX. | 
**FgnAmount** | **decimal?** | For a vanilla FxOption contract, FgnAmount cannot be set.  In case of a digital FxOption (IsPayoffDigital&#x3D;&#x3D;true)  a payoff (if the option is in the money) can be either  in domestic or in foreign currency - for the latter  FgnAmount must be set.  Note: It is invalid to have FgnAmount and DomAmount  at the same time. | [optional] 
**Strike** | **decimal?** | The strike of the option. | [optional] 
**Barriers** | [**List&lt;Barrier&gt;**](Barrier.md) | For a barrier option the list should not be empty. Up to two barriers are supported.  An option cannot be at the same time barrier- and touch-option.  One (or both) of the lists must be empty. | [optional] 
**ExerciseType** | **string** | Type of optionality that is present; European, American.    Supported string (enumeration) values are: [European, American].  Defaults to \&quot;European\&quot; if not set. | [optional] 
**IsCallNotPut** | **bool** | True if the option is a call, false if the option is a put. | 
**IsDeliveryNotCash** | **bool** | True if the option delivers the FX underlying, False if the option is settled in cash. | 
**IsPayoffDigital** | **bool** | By default IsPayoffDigital is false. If IsPayoffDigital&#x3D;true,  the option is &#39;digital&#39;, and the option payoff is 0 or 1 unit of currency,  instead of a vanilla CallPayoff&#x3D;max(spot-strike,0) or PutPayoff&#x3D;max(strike-spot,0). | [optional] 
**OptionMaturityDate** | **DateTimeOffset** | The maturity date of the option. | 
**OptionSettlementDate** | **DateTimeOffset** | The settlement date of the option. | 
**PayoutStyle** | **string** | PayoutStyle for touch options.                For options without touch optionality, payoutStyle should not be set.  For options with touch optionality (where the touches data has been set), payoutStyle must be defined and cannot be None.    Supported string (enumeration) values are: [Deferred, Immediate].  Defaults to \&quot;None\&quot; if not set. | [optional] 
**Premium** | [**Premium**](Premium.md) |  | [optional] 
**Touches** | [**List&lt;Touch&gt;**](Touch.md) | For a touch option the list should not be empty. Up to two touches are supported.  An option cannot be at the same time barrier- and touch-option.  One (or both) of the lists must be empty. | [optional] 
**TimeZoneConventions** | [**TimeZoneConventions**](TimeZoneConventions.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string domCcy = "domCcy";
string fgnCcy = "fgnCcy";
List<Barrier> barriers = new List<Barrier>();
string exerciseType = "example exerciseType";
bool isCallNotPut = //"True";
bool isDeliveryNotCash = //"True";
bool isPayoffDigital = //"True";
string payoutStyle = "example payoutStyle";
Premium? premium = new Premium();

List<Touch> touches = new List<Touch>();
TimeZoneConventions? timeZoneConventions = new TimeZoneConventions();


FxOption fxOptionInstance = new FxOption(
    startDate: startDate,
    domCcy: domCcy,
    domAmount: domAmount,
    fgnCcy: fgnCcy,
    fgnAmount: fgnAmount,
    strike: strike,
    barriers: barriers,
    exerciseType: exerciseType,
    isCallNotPut: isCallNotPut,
    isDeliveryNotCash: isDeliveryNotCash,
    isPayoffDigital: isPayoffDigital,
    optionMaturityDate: optionMaturityDate,
    optionSettlementDate: optionSettlementDate,
    payoutStyle: payoutStyle,
    premium: premium,
    touches: touches,
    timeZoneConventions: timeZoneConventions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
