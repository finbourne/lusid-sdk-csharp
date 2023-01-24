# Lusid.Sdk.Model.SequenceDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Increment** | **long** | The Resource Id of the sequence definition | 
**MinValue** | **long** | The minimum value of the sequence | 
**MaxValue** | **long** | The maximum value of the sequence | 
**Start** | **long** | The start value of the sequence | 
**Value** | **long?** | The last used value of the sequence | [optional] 
**Cycle** | **bool** | Indicates if the sequence would start from minimun value once it reaches maximum value. If set to false, a failure would return if the sequence reaches maximum value. | 
**Pattern** | **string** | The pattern to be used to generate next values in the sequence. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

