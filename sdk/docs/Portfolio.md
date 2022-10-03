# Lusid.Sdk.Model.Portfolio
A list of portfolios.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Type** | **string** | The type of the portfolio. The available values are: Transaction, Reference, DerivedTransaction | 
**DisplayName** | **string** | The name of the portfolio. | 
**Description** | **string** | The long form description of the portfolio. | [optional] 
**Created** | **DateTimeOffset** | The effective datetime at which the portfolio was created. No transactions or constituents can be added to the portfolio before this date. | 
**ParentPortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Version** | [**Version**](Version.md) |  | [optional] 
**IsDerived** | **bool** | Whether or not this is a derived portfolio. | [optional] 
**BaseCurrency** | **string** | The base currency of the portfolio. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The requested portfolio properties. These will be from the &#39;Portfolio&#39; domain. | [optional] 
**InstrumentScopes** | **List&lt;string&gt;** | The instrument scope resolution strategy of this portfolio. | [optional] 
**AccountingMethod** | **string** | . The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst | [optional] 
**AmortisationMethod** | **string** | The amortisation method the portfolio is using in the calculation. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

