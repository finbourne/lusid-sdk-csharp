# Lusid.Sdk.Model.ConfigurationRecipe
The Configuration or Calculation Recipe controls how LUSID processes a given request.  This can be used to change where market data used in pricing is loaded from and in what order, or which model is used to  price a given instrument as well as how aggregation will process the produced results.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope used when updating or inserting the Configuration Recipe. | 
**Code** | **string** | User given string name (code) to identify the recipe. | 
**Market** | [**MarketContext**](MarketContext.md) |  | [optional] 
**Pricing** | [**PricingContext**](PricingContext.md) |  | [optional] 
**Aggregation** | [**AggregationContext**](AggregationContext.md) |  | [optional] 
**Description** | **string** | User can assign a description to understand more humanly the recipe. | [optional] 
**Holding** | [**HoldingContext**](HoldingContext.md) |  | [optional] 
**Translation** | [**TranslationContext**](TranslationContext.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

