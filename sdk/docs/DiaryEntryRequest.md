# Lusid.Sdk.Model.DiaryEntryRequest
The request to add a diary entry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the diary entry. | [optional] 
**Status** | **string** | The status of the diary entry. Defaults to &#39;Undefined&#39;. | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective time of the diary entry. | 
**QueryAsAt** | **DateTimeOffset?** | The query time of the diary entry. Defaults to latest. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Properties to add to the diary entry. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

