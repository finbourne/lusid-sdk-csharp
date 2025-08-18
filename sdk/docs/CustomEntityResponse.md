# Lusid.Sdk.Model.CustomEntityResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**EntityType** | **string** | The type of custom entity this is. | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**StagedModifications** | [**StagedModificationsInfo**](StagedModificationsInfo.md) |  | [optional] 
**DisplayName** | **string** | A display label for the custom entity. | 
**Description** | **string** | A description of the custom entity. | [optional] 
**Identifiers** | [**List&lt;CustomEntityId&gt;**](CustomEntityId.md) | The identifiers the custom entity will be upserted with. | 
**Fields** | [**List&lt;CustomEntityField&gt;**](CustomEntityField.md) | The fields that decorate the custom entity. | 
**Relationships** | [**List&lt;Relationship&gt;**](Relationship.md) | A set of relationships associated to the custom entity. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties that decorate the custom entity. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

