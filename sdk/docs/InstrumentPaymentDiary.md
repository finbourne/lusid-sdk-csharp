# Lusid.Sdk.Model.InstrumentPaymentDiary
A payment diary containing all the cashflows on a single instrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdType** | **string** | The identifier type of the instrument. | [optional] 
**InstrumentId** | **string** | The identifier for the instrument. | [optional] 
**InstrumentScope** | **string** | The scope of the instrument. | [optional] 
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Legs** | [**List&lt;InstrumentPaymentDiaryLeg&gt;**](InstrumentPaymentDiaryLeg.md) | Aggregated sets of Cashflows. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

