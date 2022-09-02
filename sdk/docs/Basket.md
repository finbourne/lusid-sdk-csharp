# Lusid.Sdk.Model.Basket
LUSID representation of a basket of instruments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond | 
**BasketName** | [**BasketIdentifier**](BasketIdentifier.md) |  | 
**BasketType** | **string** | What contents does the basket have. The validation will check that the instrument types contained match those expected.    Supported string (enumeration) values are: [Bonds, Credits, Equities, EquitySwap]. | 
**WeightedInstruments** | [**WeightedInstruments**](WeightedInstruments.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

