
# Lusid.Sdk.Model.Portfolio

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specifc Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Type** | **string** | The type of the portfolio. | 
**DisplayName** | **string** | The name of the portfolio. | 
**Description** | **string** | The long form description of the portfolio. | [optional] 
**Created** | **DateTimeOffset?** | The effective datetime at which the portfolio was created. No transactions or constituents can be added to the portfolio before this date. | 
**ParentPortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Version** | [**Version**](Version.md) |  | [optional] 
**IsDerived** | **bool?** | Whether or not this is a derived portfolio. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The requested portfolio properties. These will be from the &#39;Portfolio&#39; domain. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

