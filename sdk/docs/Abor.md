# Lusid.Sdk.Model.Abor
An Abor entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Abor. | [optional] 
**Description** | **string** | The description for the Abor. | [optional] 
**PortfolioIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The list with the portfolio ids which are part of the Abor. Note: These must all have the same base currency. | 
**AborConfigurationId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Abor. | [optional] 
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**BaseCurrency** | **string** | The base currency of the abor based on contained portfolio base currencies. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

