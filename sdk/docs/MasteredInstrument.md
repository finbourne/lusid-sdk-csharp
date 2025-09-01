# Lusid.Sdk.Model.MasteredInstrument
LUSID representation of a reference to another instrument that has already been upserted (Mastered)

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass, FlexibleLoan, UnsettledCash, Cash, MasteredInstrument, LoanFacility, FlexibleDeposit, FlexibleRepo | 
**Identifiers** | **Dictionary&lt;string, string&gt;** | Dictionary of identifiers of the mastered instrument | 
**MasteredDomCcy** | **string** | DomCcy of the Instrument that Mastered Instrument points to - read only field | [optional] [readonly] 
**MasteredInstrumentType** | **string** | Type of the Instrument that Mastered Instrument points to - read only field | [optional] [readonly] 
**MasteredLusidInstrumentId** | **string** | Luid of the Instrument that Mastered Instrument points to - read only field | [optional] [readonly] 
**MasteredName** | **string** | Name of the Instrument that Mastered Instrument points to - read only field | [optional] [readonly] 
**MasteredScope** | **string** | Scope of the Instrument that Mastered Instrument points to - read only field | [optional] [readonly] 
**MasteredAssetClass** | **string** | Asset class of the underlying mastered instrument - read only field    Supported string (enumeration) values are: [InterestRates, FX, Inflation, Equities, Credit, Commodities, Money].  Defaults to \&quot;Unknown\&quot; if not set. | [optional] [readonly] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

