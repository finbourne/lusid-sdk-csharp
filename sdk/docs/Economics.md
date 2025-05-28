# Lusid.Sdk.Model.Economics

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentScope** | **string** | The scope in which the instrument lies. | [optional] 
**LusidInstrumentId** | **string** | The unique Lusid Instrument Id (LUID) of the instrument that economics are for. | 
**SubHoldingKeys** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The sub-holding properties which identify the Economic. Each property will be from the &#39;Transaction&#39; domain. These are configured on a transaction portfolio. | [optional] 
**Buckets** | [**List&lt;Bucket&gt;**](Bucket.md) | Set of economic data related with each of the side impact of the transaction. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

