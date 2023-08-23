# Lusid.Sdk.Model.Package
A structure used to describe the structure of an order or orders that make up a non-trivial trade.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**OrderIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Related order ids. | 
**OrderInstructionIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Related order instruction ids. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this execution. | [optional] 
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

