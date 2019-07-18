
# Lusid.Sdk.Model.AdjustHoldingRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | A set of instrument identifiers to use to resolve the holding adjustment to a unique instrument. | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualPropertyValue&gt;**](PerpetualPropertyValue.md) | Set of unique transaction properties and associated values to store with the holding adjustment transaction automatically created by LUSID. Each property must be from the &#39;Trade&#39; domain. | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualPropertyValue&gt;**](PerpetualPropertyValue.md) | Set of unique holding properties and associated values to store with the target holding. Each property must be from the &#39;Holding&#39; domain. | [optional] 
**TaxLots** | [**List&lt;TargetTaxLotRequest&gt;**](TargetTaxLotRequest.md) | The tax-lots that together make up the target holding. | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

