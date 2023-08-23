# Lusid.Sdk.Model.PortfolioReturnBreakdown
A list of Composite Breakdowns.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**RateOfReturn** | **decimal** | The return number. | [optional] 
**OpeningMarketValue** | **decimal?** | The opening market value. | [optional] 
**ClosingMarketValue** | **decimal?** | The closing market value. | [optional] 
**Weight** | **decimal** | The weight of the constituent into the composite. | [optional] 
**ConstituentsInTheComposite** | **int** | The number of members in the Composite on the given day. | [optional] 
**ConstituentsMissing** | **int** | The number of the constituents which have a missing return on that day. | [optional] 
**Currency** | **string** | The currency of the portfolio. | [optional] 
**OpenFxRate** | **decimal** | The opening fxRate which is used in calculation. | [optional] 
**CloseFxRate** | **decimal** | The closing fxRate which is used in calculation. | [optional] 
**LocalRateOfReturn** | **decimal?** | The rate of return in the local currency. | [optional] 
**LocalOpeningMarketValue** | **decimal?** | The opening market value in the local currency. | [optional] 
**LocalClosingMarketValue** | **decimal?** | The closing market value in the local currency. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

