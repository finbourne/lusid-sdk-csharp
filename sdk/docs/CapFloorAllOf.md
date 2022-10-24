# Lusid.Sdk.Model.CapFloorAllOf

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CapFloorType** | **string** | Determine if it&#39;s CAP, FLOOR, or COLLAR.    Supported string (enumeration) values are: [Cap, Floor, Collar]. | 
**CapStrike** | **decimal** | Strike rate of the Cap. | 
**FloorStrike** | **decimal** | Strike rate of the Floor. | 
**IncludeFirstCaplet** | **bool** | Include first caplet flag. | 
**UnderlyingFloatingLeg** | [**FloatingLeg**](FloatingLeg.md) |  | 
**InstrumentType** | **string** | The available values are: QuotedSecurity, InterestRateSwap, FxForward, Future, ExoticInstrument, FxOption, CreditDefaultSwap, InterestRateSwaption, Bond, EquityOption, FixedLeg, FloatingLeg, BespokeCashFlowsLeg, Unknown, TermDeposit, ContractForDifference, EquitySwap, CashPerpetual, CapFloor, CashSettled, CdsIndex, Basket, FundingLeg, FxSwap, ForwardRateAgreement, SimpleInstrument, Repo, Equity, ExchangeTradedOption, ReferenceInstrument, ComplexBond, InflationLinkedBond, InflationSwap | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

