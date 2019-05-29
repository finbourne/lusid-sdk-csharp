
# Lusid.Sdk.Model.MarketContext

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MarketRules** | [**List&lt;MarketDataKeyRule&gt;**](MarketDataKeyRule.md) | The set of rules that define how to resolve particular use cases. These can be relatively general or specific in nature.  Nominally any number are possible and will be processed in order where applicable. However, there is evidently a potential  for increased computational cost where many rules must be applied to resolve data. Ensuring that portfolios are structured in  such a way as to reduce the number of rules required is therefore sensible. | [optional] 
**Suppliers** | [**MarketContextSuppliers**](MarketContextSuppliers.md) |  | [optional] 
**Options** | [**MarketOptions**](MarketOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

