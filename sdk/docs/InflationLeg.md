# Lusid.Sdk.Model.InflationLeg
LUSID representation of an Inflation Leg.  This leg instrument is part of the InflationSwap instrument, but can also be used as a standalone instrument.  The implementation supports the following inflation leg types:  * Zero Coupon inflation leg (CPI Leg), with a single payment at maturity.  * Year on Year inflation leg  * LPI Swap Leg (capped and floored YoY)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**MaturityDate** | **DateTimeOffset** | The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates that may well be observed or set prior to the maturity date, but refer to a termination date beyond it. | 
**FlowConventions** | [**FlowConventions**](FlowConventions.md) |  | 
**BaseCPI** | **decimal?** | Optional BaseCPI, if specified it will be used in place of BaseCPI(StartDate).  This should not be required for standard inflation swaps. | [optional] 
**CalculationType** | **string** | The calculation type.  ZeroCoupon is used for CPILegs where there is a single payment at maturity of  Notional * (CPI(T) / CPI(T0) - 1)  where CPI(T0) is the BaseCPI of this leg  YearOnYear is used for YoY and LPI swap legs where there is a series of annual payments  Notional * dayCount * (CPI(t) / CPI(t-1) - 1)  If a cap and floor is added to this it becomes an LPI swap leg.  Compounded is used for inflation swap legs where there is a series of annual payments  Notional * dayCount * (CPI(t) / CPI(T0) - 1)  i.e. the BaseCPI is used every year. These swaps are not as common as CPI or    Supported string (enumeration) values are: [ZeroCoupon, YearOnYear, Compounded]. | 
**CapRate** | **decimal?** | Optional cap, needed for LPI Legs or CPI Legs with Caps | [optional] 
**FloorRate** | **decimal?** | Optional floor, needed for LPI Legs or CPI Legs with Floors. | [optional] 
**InflationIndexConventions** | [**InflationIndexConventions**](InflationIndexConventions.md) |  | 
**Notional** | **decimal** | The notional | 
**PayReceive** | **string** | PayReceive flag for the inflation leg.  This field is optional and defaults to Pay.    Supported string (enumeration) values are: [Pay, Receive]. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

