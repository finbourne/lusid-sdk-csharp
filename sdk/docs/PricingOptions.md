
# Lusid.Sdk.Model.PricingOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelSelection** | [**ModelSelection**](ModelSelection.md) |  | [optional] 
**UseInstrumentTypeToDeterminePricer** | **bool?** | If true then use the instrument type to set the default instrument pricer  This applies where no more specific set of overrides are provided on a per-vendor and instrument basis. | [optional] 
**AllowAnyInstrumentsWithSecUidToPriceOffLookup** | **bool?** | By default, one would not expect to price and exotic instrument, i.e. an instrument with a complicated  instrument definition simply through looking up a price as there should be a better way of evaluating it.  To override that behaviour and allow lookup for a price from the instrument identifier(s), set this to true. | [optional] 
**AllowPartiallySuccessfulEvaluation** | **bool?** | If true then a failure in task evaluation doesn&#39;t cause overall failure.  results will be returned where they succeeded and annotation elsewhere | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

