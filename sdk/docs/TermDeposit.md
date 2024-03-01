# Lusid.Sdk.Model.TermDeposit
LUSID representation of a Term Deposit.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. For term deposits this is the start date of the interest calculation period. | 
**MaturityDate** | **DateTimeOffset** | The maturity date of the instrument. For term deposits this is the last date of the interest calculation period. | 
**ContractSize** | **decimal** | The principal amount of the term deposit. | 
**FlowConvention** | [**FlowConventions**](FlowConventions.md) |  | 
**Rate** | **decimal** | The fixed rate for the term deposit. Specified as a decimal, e.g 0.03 is meant to be 3% interest | 
**DomCcy** | **string** | The domestic currency of the instrument. This should be the same as the Currency set on the FlowConventions.  You do not need to populate this field for Term Deposits in LUSID as all functionality is driven by the Currency set on the FlowConventions.  LUSID will not store values saved on this field. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

