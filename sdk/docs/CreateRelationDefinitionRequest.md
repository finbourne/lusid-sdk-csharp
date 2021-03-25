
# Lusid.Sdk.Model.CreateRelationDefinitionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope that the relation exists in. | 
**Code** | **string** | The code of the relation. Together with the scope this uniquely defines the relation. | 
**SourceEntityDomain** | **string** | The entity domain of the source entity object must be, allowed values are \&quot;Portfolio\&quot; and \&quot;Person\&quot; | 
**TargetEntityDomain** | **string** | The entity domain of the target entity object must be, allowed values are \&quot;Portfolio\&quot; and \&quot;Person\&quot; | 
**DisplayName** | **string** | The display name of the relation. | 
**OutwardDescription** | **string** | The description to relate source entity object and target entity object. | 
**InwardDescription** | **string** | The description to relate target entity object and source entity object. | 
**LifeTime** | **string** | Describes how the relations can change over time, allowed values are \&quot;Perpetual\&quot; and \&quot;TimeVariant\&quot; | [optional] 
**ConstraintStyle** | **string** | Describes the uniqueness and cardinality for relations with a specific source entity object and relations under this definition. Allowed values are \&quot;Property\&quot; and \&quot;Collection\&quot;, defaults to \&quot;Collection\&quot; if not specified. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

