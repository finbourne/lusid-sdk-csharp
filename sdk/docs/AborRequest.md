# Lusid.Sdk.Model.AborRequest
The request used to create an Abor.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code given for the Abor. | 
**PortfolioIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The list with the portfolio ids which are part of the Abor. For now the only supported value is SinglePortfolio. | 
**Description** | **string** | The description for the Abor. | [optional] 
**AborConfig** | [**ResourceId**](ResourceId.md) |  | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Properties to add to the Abor. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

