# Lusid.Sdk.Model.AggregatedReturn
A list of Aggregated Returns.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveAt** | **DateTimeOffset** | The effectiveAt for the return. | 
**EndOfPeriod** | **DateTimeOffset** | The end of period date. For the monthly period this will be the Month End Date. | 
**OpeningMarketValue** | **decimal?** | The opening market value. | [optional] 
**ClosingMarketValue** | **decimal?** | The closing market value. | [optional] 
**MetricsValue** | **Dictionary&lt;string, decimal&gt;** | The value for the specified metric. | 
**Frequency** | **string** | Show the aggregated output returns on a Daily or Monthly period. | [optional] 
**CompositeMembers** | **int?** | The number of members in the Composite on the given day. | [optional] 
**CompositeMembersWithoutReturn** | [**List&lt;ResourceId&gt;**](ResourceId.md) | List containing Composite members which post no return on the given day. | [optional] 
**Warnings** | **List&lt;string&gt;** | List of the warnings about the calculation of the aggregated return. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

