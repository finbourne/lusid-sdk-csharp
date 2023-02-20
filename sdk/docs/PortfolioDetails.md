# Lusid.Sdk.Model.PortfolioDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**OriginPortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**Version** | [**Version**](Version.md) |  | 
**BaseCurrency** | **string** | The base currency of the transaction portfolio. | 
**CorporateActionSourceId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**SubHoldingKeys** | **List&lt;string&gt;** |  | [optional] 
**InstrumentScopes** | **List&lt;string&gt;** | The resolution strategy used to resolve instruments of transactions/holdings upserted to the transaction portfolio. | [optional] 
**AccountingMethod** | **string** | . The available values are: Default, AverageCost, FirstInFirstOut, LastInFirstOut, HighestCostFirst, LowestCostFirst | [optional] 
**AmortisationMethod** | **string** | The amortisation method the portfolio is using in the calculation. This can be &#39;NoAmortisation&#39;, &#39;StraightLine&#39; or &#39;EffectiveYield&#39;. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

