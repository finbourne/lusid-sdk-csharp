# Lusid.Sdk.Model.PortfolioGroupSearchResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the portfolio group. | 
**Description** | **string** | The long form description of the portfolio group. | [optional] 
**Created** | **DateTimeOffset** | The effective datetime at which the portfolio group was created. No portfolios or sub groups can be added to the group before this date. | [optional] 
**Portfolios** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The collection of resource identifiers for the portfolios contained in the portfolio group. | [optional] 
**SubGroups** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The collection of resource identifiers for the portfolio groups contained in the portfolio group as sub groups. | [optional] 
**Version** | [**Version**](Version.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

