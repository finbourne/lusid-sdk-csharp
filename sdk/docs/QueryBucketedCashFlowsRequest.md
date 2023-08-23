# Lusid.Sdk.Model.QueryBucketedCashFlowsRequest
Query for bucketed cashflows from one or more portfolios.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset?** | The time of the system at which to query for bucketed cashflows. | [optional] 
**WindowStart** | **DateTimeOffset** | The start date of the window. | 
**WindowEnd** | **DateTimeOffset** | The end date of the window. | 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The set of portfolios and portfolio groups to which the instrument events must belong. | 
**EffectiveAt** | **DateTimeOffset** | The valuation (pricing) effective datetime or cut label (inclusive) at which to evaluate the cashflows | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**RoundingMethod** | **string** | When bucketing, there is not a unique way to allocate the bucket points. RoundingMethod Supported string (enumeration) values are: [RoundDown, RoundUp]. | 
**BucketingDates** | **List&lt;DateTimeOffset&gt;** | A list of dates to perform cashflow bucketing upon. If this is provided, the list of tenors for bucketing should be empty. | [optional] 
**BucketingTenors** | **List&lt;string&gt;** | A list of tenors to perform cashflow bucketing upon. If this is provided, the list of dates for bucketing should be empty. | [optional] 
**ReportCurrency** | **string** | Three letter ISO currency string indicating what currency to report in for ReportCurrency denominated queries. | 
**GroupBy** | **List&lt;string&gt;** | The set of address keys to use to group the bucketed cash flows. | [optional] 
**Addresses** | **List&lt;string&gt;** | The set of items that the user wishes to see in the results. If empty, will be defaulted to standard ones. | [optional] 
**EquipWithSubtotals** | **bool** | Flag directing the Valuation call to populate the results with subtotals of aggregates. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

