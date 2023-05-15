# Lusid.Sdk.Model.GetReferencePortfolioConstituentsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveFrom** | **DateTimeOffset** |  | 
**WeightType** | **string** | The available values are: Static, Floating, Periodical | 
**PeriodType** | **string** | The available values are: Daily, Weekly, Monthly, Quarterly, Annually | [optional] 
**PeriodCount** | **int?** |  | [optional] 
**Constituents** | [**List&lt;ReferencePortfolioConstituent&gt;**](ReferencePortfolioConstituent.md) | Set of constituents (instrument/weight pairings) | 
**Href** | **string** | The Uri that returns the same result as the original request,  but may include resolved as at time(s). | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

