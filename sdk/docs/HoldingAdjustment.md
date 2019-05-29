
# Lusid.Sdk.Model.HoldingAdjustment

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers | [optional] 
**InstrumentUid** | **string** | LUSID&#39;s internal unique instrument identifier, resolved from the instrument identifiers | 
**SubHoldingKeys** | [**List&lt;PerpetualProperty&gt;**](PerpetualProperty.md) | Key fields to uniquely index the sub holdings of a instrument | [optional] 
**Properties** | [**List&lt;PerpetualProperty&gt;**](PerpetualProperty.md) | Arbitrary properties to store with the holding | [optional] 
**TaxLots** | [**List&lt;TargetTaxLot&gt;**](TargetTaxLot.md) | 1 or more quantity amounts | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

