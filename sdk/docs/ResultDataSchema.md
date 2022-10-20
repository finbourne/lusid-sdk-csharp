# Lusid.Sdk.Model.ResultDataSchema
The shape and type of the returned data. The AddressSchema gives information about the requested keys,  including the return type, links to further documentation, lifecycle status and removal date if they are  deprecated.                Note: the NodeValueSchema and PropertySchema fields have been deprecated. Please use the AddressSchema instead.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**NodeValueSchema** | [**Dictionary&lt;string, FieldSchema&gt;**](FieldSchema.md) | This has been deprecated. Please use AddressSchema instead. | [optional] 
**PropertySchema** | [**Dictionary&lt;string, FieldSchema&gt;**](FieldSchema.md) | This has been deprecated. Please use AddressSchema instead. | [optional] 
**AddressSchema** | [**Dictionary&lt;string, AddressDefinition&gt;**](AddressDefinition.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

