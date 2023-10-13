# Lusid.Sdk.Model.ForwardRateAgreementAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StartDate** | **DateTimeOffset** | The settlement date of the FRA | 
**MaturityDate** | **DateTimeOffset** | The final maturity date of the instrument. This means the last date on which the instruments makes a payment of any amount.  For the avoidance of doubt, that is not necessarily prior to its last sensitivity date for the purposes of risk; e.g. instruments such as  Constant Maturity Swaps (CMS) often have sensitivities to rates beyond their last payment date. | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**FixingDate** | **DateTimeOffset** | The date at which the rate to be paid, the reference rate, is confirmed/observed. | 
**FraRate** | **decimal** | The rate at which the FRA is traded. | 
**Notional** | **decimal** | The amount for which the FRA is traded. | 
**IndexConvention** | [**IndexConvention**](IndexConvention.md) |  | [optional] 
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

