# Lusid.Sdk.Model.PortfolioSearchResult
A list of portfolios.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Type** | **string** | The type of the portfolio. The available values are: Transaction, Reference, DerivedTransaction | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Description** | **string** | The long form description of the portfolio. | [optional] 
**DisplayName** | **string** | The name of the portfolio. | 
**IsDerived** | **bool** | Whether or not this is a derived portfolio. | [optional] [readonly] 
**Created** | **DateTimeOffset** | The effective datetime at which the portfolio was created. No transactions or constituents can be added to the portfolio before this date. | 
**ParentPortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**BaseCurrency** | **string** | The base currency of the portfolio. This will be an empty string for reference portfolios. | [optional] 
**Properties** | [**List&lt;Property&gt;**](Property.md) | The requested portfolio properties. These will be from the &#39;Portfolio&#39; domain. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

