# Lusid.Sdk.Model.HoldingAdjustment
The target holdings.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | A set of instrument identifiers that can resolve the holding adjustment to a unique instrument. | [optional] 
**InstrumentScope** | **string** | The scope of the instrument that the holding adjustment is in. | [optional] 
**InstrumentUid** | **string** | The unique Lusid Instrument Id (LUID) of the instrument that the holding adjustment is in. | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The set of unique transaction properties and associated values stored with the holding adjustment transactions automatically created by LUSID. Each property will be from the &#39;Transaction&#39; domain. | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The set of unique holding properties and associated values stored with the target holding. Each property will be from the &#39;Holding&#39; domain. | [optional] 
**TaxLots** | [**List&lt;TargetTaxLot&gt;**](TargetTaxLot.md) | The tax-lots that together make up the target holding. | 
**Currency** | **string** | The Holding currency. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

