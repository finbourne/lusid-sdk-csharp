
# Lusid.Sdk.Model.UpsertReferencePortfolioConstituentsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveFrom** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The first date from which the weights will apply | 
**WeightType** | **string** | The available values are: Static, Floating, Periodical | 
**PeriodType** | **string** | The available values are: Daily, Weekly, Monthly, Quarterly, Annually | [optional] 
**PeriodCount** | **int?** |  | [optional] 
**Constituents** | [**List&lt;ReferencePortfolioConstituentRequest&gt;**](ReferencePortfolioConstituentRequest.md) | Set of constituents (instrument/weight pairings) | 

[[Back to Model list]](../README.md#documentation-for-models)
[[Back to API list]](../README.md#documentation-for-api-endpoints)
[[Back to README]](../README.md)

