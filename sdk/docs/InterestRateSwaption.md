# Lusid.Sdk.Model.InterestRateSwaption
LUSID representation of an Interest Rate Swaption.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass | 
**StartDate** | **DateTimeOffset** | The start date of the instrument. This is normally synonymous with the trade-date. | 
**PayOrReceiveFixed** | **string** | True if on exercise the holder of the option enters the swap paying fixed, false if floating.    Supported string (enumeration) values are: [Pay, Receive]. | 
**Premium** | [**Premium**](Premium.md) |  | [optional] 
**DeliveryMethod** | **string** | How does the option settle    Supported string (enumeration) values are: [Cash, Physical]. | 
**Swap** | [**InterestRateSwap**](InterestRateSwap.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

