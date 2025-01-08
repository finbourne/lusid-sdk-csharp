# Lusid.Sdk.Model.TransactionTypePropertyMapping

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyKey** | **string** | The key that uniquely identifies the property. It has the format {domain}/{scope}/{code} | 
**MapFrom** | **string** | The Property Key of the Property to map from | [optional] 
**SetTo** | **string** | A pointer to the Property being mapped from | [optional] 
**TemplateFrom** | **string** | The template that defines how the property value is constructed from transaction, instrument and portfolio details. | [optional] 
**Nullify** | **bool?** | Flag to unset the Property Key for the mapping | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

