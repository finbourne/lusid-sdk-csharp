
# Lusid.Sdk.Model.PricingContext

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelRules** | [**List&lt;VendorModelRule&gt;**](VendorModelRule.md) | The set of model rules that are available. There may be multiple rules for Vendors, but only one per model-instrument pair.  Which of these preference sets is used depends upon the model choice selection if specified, or failing that the global default model specification  in the options. | [optional] 
**ModelChoice** | [**Dictionary&lt;string, ModelSelection&gt;**](ModelSelection.md) | The choice of which model selection (vendor library, pricing model) to use in evaluation of a given instrument type. | [optional] 
**Options** | [**PricingOptions**](PricingOptions.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

