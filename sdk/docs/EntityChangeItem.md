# Lusid.Sdk.Model.EntityChangeItem
Defines a change that occured for an entity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAtModified** | **DateTimeOffset** | The date/time of the change. | 
**UserIdModified** | **string** | The unique identifier of the user that made the change. | 
**RequestIdModified** | **string** | The unique identifier of the request that the changes were part of. | 
**AsAtVersionNumber** | **int** | The version number for the entity (the entity was created at version 1). This may refer to the version number of a changed related entity, not a change for the entity itself. | 
**Action** | **string** | The action performed on the entity. | 
**ActionDescription** | **string** | Description of the action performed on the entity. | 
**AttributeName** | **string** | The name of the field or property that has been changed. | [optional] 
**PreviousValue** | **Object** | The value of the attribute prior to the change. | [optional] 
**NewValue** | **Object** | The value of the attribute following the change. | [optional] 
**EffectiveFrom** | **DateTimeOffset?** | The effective datetime from which the field&#39;s new value is valid. | [optional] 
**EffectiveUntil** | **DateTimeOffset?** | The effective datetime until which the field&#39;s new value is valid. | [optional] 
**Detail** | **Dictionary&lt;string, string&gt;** | Information about the particular instance of the ChangeItem (supplied information depends on the type of Action). | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

