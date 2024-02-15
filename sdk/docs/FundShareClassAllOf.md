# Lusid.Sdk.Model.FundShareClassAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ShortCode** | **string** | A short identifier, unique across a single fund, usually made up of the ShareClass components. Eg \&quot;A Accumulation Euro Hedged Class\&quot; could become \&quot;A Acc H EUR\&quot;. | 
**FundShareClassType** | **string** | The type of distribution that the ShareClass will calculate. Can be either &#39;Income&#39; or &#39;Accumulation&#39; - Income classes will pay out and Accumulation classes will retain their ShareClass attributable income.    Supported string (enumeration) values are: [Income, Accumulation]. | 
**DistributionPaymentType** | **string** | The tax treatment applied to any distributions calculated within the ShareClass. Can be either &#39;Net&#39; (Distribution Calculated net of tax) or &#39;Gross&#39; (Distribution calculated gross of tax).    Supported string (enumeration) values are: [Gross, Net]. | 
**Hedging** | **string** | A flag to indicate the ShareClass is operating currency hedging as a means to limit currency risk as part of it&#39;s investment strategy.    Supported string (enumeration) values are: [Invalid, None, ApplyHedging]. | 
**DomCcy** | **string** | The domestic currency of the instrument. | 
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

