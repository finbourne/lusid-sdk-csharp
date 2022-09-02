# Lusid.Sdk.Model.ExchangeTradedOption
LUSID representation of an Exchange Traded Option.  Including, but not limited to, Equity Options, Bond Options, Index Options, Future Options, and Interest Rate Options.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**ContractDetails** | [**ExchangeTradedOptionContractDetails**](ExchangeTradedOptionContractDetails.md) |  | 
**Contracts** | **decimal** | The number of contracts held. | 
**RefSpotPrice** | **decimal** | The reference spot price for the option at which the contract was entered into. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

