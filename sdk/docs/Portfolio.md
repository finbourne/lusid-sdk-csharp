# Lusid.Sdk.Model.Portfolio
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | Link to retrieve the current entity | [optional] 
**Id** | [**ResourceId**](ResourceId.md) | Identifier for the portfolio | [optional] 
**Type** | **string** | The type of portfolio this is (e.g. Transaction Portfolio, Reference  Portfolio) | [optional] 
**DisplayName** | **string** | Display name of the portfolio | [optional] 
**Description** | **string** | Description of the portfolio | [optional] 
**Created** | **DateTimeOffset?** | Portfolio creation time in UTC | [optional] 
**ParentPortfolioId** | [**ResourceId**](ResourceId.md) | If this is a derived portfolio, the identifier of the portfolio from which it is derived | [optional] 
**Version** | [**Version**](Version.md) | The version of the portfolio | [optional] 
**IsDerived** | **bool?** |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

