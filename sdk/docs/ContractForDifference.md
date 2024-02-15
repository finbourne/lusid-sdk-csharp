# Lusid.Sdk.Model.ContractForDifference
LUSID representation of a Contract for Difference.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap, SimpleCashFlowLoan, TotalReturnSwap, InflationLeg, FundShareClass | 
**StartDate** | **DateTimeOffset** | The start date of the CFD. | 
**MaturityDate** | **DateTimeOffset** | The maturity date for the CFD. If CFDType is Futures, this should be set to be the maturity date of the underlying  future. If CFDType is Cash, this should not be set. | [optional] 
**Code** | **string** | The code of the underlying. | 
**ContractSize** | **decimal** | The size of the CFD contract, this should represent the total number of stocks that the CFD represents. | 
**PayCcy** | **string** | The currency that this CFD pays out, this can be different to the UnderlyingCcy. | 
**ReferenceRate** | **decimal** | The reference rate of the CFD, this can be set to 0 but not negative values.  This field is optional, if not set it will default to 0. | [optional] 
**Type** | **string** | The type of CFD.    Supported string (enumeration) values are: [Cash, Futures]. | 
**UnderlyingCcy** | **string** | The currency of the underlying | 
**UnderlyingIdentifier** | **string** | External market codes and identifiers for the CFD, e.g. RIC.    Supported string (enumeration) values are: [LusidInstrumentId, Isin, Sedol, Cusip, ClientInternal, Figi, RIC, QuotePermId, REDCode, BBGId, ICECode]. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

