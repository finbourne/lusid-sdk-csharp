# Lusid.Sdk.Model.DeleteRelationshipRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceEntityId** | **Dictionary&lt;string, string&gt;** | The identifier of the source entity of the relationship to be deleted. | 
**TargetEntityId** | **Dictionary&lt;string, string&gt;** | The identifier of the target entity of the relationship to be deleted. | 
**EffectiveFrom** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The effective date of the relationship to be deleted | [optional] 
**EffectiveUntil** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The effective datetime until which the relationship will be deleted. If not supplied the deletion will be permanent. | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

