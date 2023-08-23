# Lusid.Sdk.Model.QueryInstrumentEventsRequest
Instrument event query.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset?** | The time of the system at which to query for bucketed cashflows. | [optional] 
**WindowStart** | **DateTimeOffset** | The start date of the window. | 
**WindowEnd** | **DateTimeOffset** | The end date of the window. | 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The set of portfolios and portfolio groups to which the instrument events must belong. | 
**EffectiveAt** | **DateTimeOffset** | The Effective date used in the valuation of the cashflows. | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**FilterInstrumentEvents** | **string** | Expression to filter the result set. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

