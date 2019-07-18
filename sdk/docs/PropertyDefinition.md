
# Lusid.Sdk.Model.PropertyDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specifc Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Key** | **string** | The property key which uniquely identifies the property. The format for the property key is {domain}/{scope}/{code}, e.g. &#39;Portfolio/Manager/Id&#39;. | [optional] 
**ValueType** | **string** | The type of values that can be associated with this property. This is defined by the property&#39;s data type. | [optional] 
**ValueRequired** | **bool?** | Whether or not a value is always required for this property. | [optional] 
**DisplayName** | **string** | The display name of the property. | [optional] 
**DataTypeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**LifeTime** | **string** | Describes how the property&#39;s values can change over time. | [optional] 
**Type** | **string** | The type of the property. | [optional] 
**UnitSchema** | **string** | The units that can be associated with the property&#39;s values. This is defined by the property&#39;s data type. | [optional] 
**Domain** | **string** | The domain that the property exists in. | [optional] 
**Scope** | **string** | The scope that the property exists in. | [optional] 
**Code** | **string** | The code of the property. Together with the domain and scope this uniquely identifies the property. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

