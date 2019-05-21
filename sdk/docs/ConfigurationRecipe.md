# Lusid.Sdk.Model.ConfigurationRecipe
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | User given string name (code) to identify the recipe. | 
**Market** | [**MarketContext**](MarketContext.md) | The market configuration that defines where market data used in processing a request is loaded from and how it is resolved. | [optional] 
**Pricing** | [**PricingContext**](PricingContext.md) | The pricing configuration that defines which pricing library is used to price a given instrument and what models and preferences are used with those. | [optional] 
**Aggregation** | [**AggregationContext**](AggregationContext.md) | The aggregation configuration that defines how results are amalgamated and what logic to follow when applying sql-like rules. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

