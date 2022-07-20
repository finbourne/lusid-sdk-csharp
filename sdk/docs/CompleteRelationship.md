# Lusid.Sdk.Model.CompleteRelationship
Representation of a relationship containing details of source and target entities, and both outward and inward descriptions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Version** | [**Version**](Version.md) |  | [optional] 
**RelationshipDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**SourceEntity** | [**RelatedEntity**](RelatedEntity.md) |  | 
**TargetEntity** | [**RelatedEntity**](RelatedEntity.md) |  | 
**OutwardDescription** | **string** | Description of the relationship based on relationship definition&#39;s outward description. | 
**InwardDescription** | **string** | Description of the relationship based on relationship definition&#39;s inward description. | 
**EffectiveFrom** | **DateTimeOffset** | The effective datetime from which the relationship is valid. | [optional] 
**EffectiveUntil** | **DateTimeOffset** | The effective datetime to which the relationship is valid until. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

