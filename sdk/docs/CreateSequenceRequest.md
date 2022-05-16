# Lusid.Sdk.Model.CreateSequenceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code of the sequence definition to create | 
**Increment** | **long?** | The value to increment between each value in the sequence | [optional] 
**MinValue** | **long?** | The minimum value of the sequence | [optional] 
**MaxValue** | **long?** | The maximum value of the sequence | [optional] 
**Start** | **long?** | The start value of the sequence | [optional] 
**Cycle** | **bool** | Set to true to start the sequence over again when it reaches the end. Defaults to false if not provided. | [optional] 
**Pattern** | **string** | The pattern to be used to generate next values in the sequence. Defaults to null if not provided. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

