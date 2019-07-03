
# Lusid.Sdk.Model.AdjustHoldingRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualPropertyValue&gt;**](PerpetualPropertyValue.md) | Key fields to uniquely index the sub holdings of a instrument | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualPropertyValue&gt;**](PerpetualPropertyValue.md) | Arbitrary properties to store with the holding | [optional] 
**TaxLots** | [**List&lt;TargetTaxLotRequest&gt;**](TargetTaxLotRequest.md) | 1 or more quantity amounts | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

