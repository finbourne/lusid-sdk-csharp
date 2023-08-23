# Lusid.Sdk.Model.QueryCashFlowsRequest
Query for cashflows from one or more portfolios

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset?** | The time of the system at which to query for cashflows. | [optional] 
**WindowStart** | **DateTimeOffset** | The start date of the window. | 
**WindowEnd** | **DateTimeOffset** | The end date of the window. | 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The set of portfolios and portfolio groups to which the instrument events must belong. | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**EffectiveAt** | **DateTimeOffset** | The Effective date used in the valuation of the cashflows. | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

