# Lusid.Sdk.Model.RelatedEntity
Information about the other related entity in the relationship

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The type of the entity. | 
**EntityId** | **Dictionary&lt;string, string&gt;** | The identifier of the other related entity in the relationship. It contains &#39;scope&#39; and &#39;code&#39; as keys for identifiers of a Portfolio or Portfolio Group, or &#39;idTypeScope&#39;, &#39;idTypeCode&#39;, &#39;code&#39; as keys for identifiers of a Person or Legal entity, or &#39;scope&#39;, &#39;identifierType&#39;, &#39;identifierValue&#39; as keys for identifiers of an Instrument | 
**DisplayName** | **string** | The display name of the entity. | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The properties of the entity. This field is empty until further notice. | [optional] 
**Scope** | **string** | The scope of the identifier | [optional] 
**LusidUniqueId** | [**LusidUniqueId**](LusidUniqueId.md) |  | [optional] 
**Identifiers** | [**List&lt;EntityIdentifier&gt;**](EntityIdentifier.md) | The identifiers of the related entity in the relationship. | 
**Href** | **string** | The link to the entity. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

