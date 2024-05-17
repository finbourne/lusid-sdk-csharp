# Lusid.Sdk.Model.QueryApplicableInstrumentEventsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WindowStart** | **DateTimeOffset** | The start date of the window. | 
**WindowEnd** | **DateTimeOffset** | The end date of the window. | 
**EffectiveAt** | **DateTimeOffset** | The Effective date that splits query window into two parts: factual period and forecast period | 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The set of portfolios and portfolio groups to which the instrument events must belong. | 
**ForecastingRecipeId** | [**ResourceId**](ResourceId.md) |  | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

