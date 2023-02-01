# Lusid.Sdk.Model.ChangeHistory
A group of changes made by the same person at the same time.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UserId** | **string** | The unique identifier of the user that made the change. | 
**ModifiedAsAt** | **DateTimeOffset** | The date/time of the change. | 
**RequestId** | **string** | The unique identifier of the request that the changes were part of. | 
**Action** | **string** | The action performed on the transaction, either created, updated, or deleted. The available values are: Create, Update, Delete | 
**Changes** | [**List&lt;ChangeItem&gt;**](ChangeItem.md) | The collection of changes that were made. | 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

