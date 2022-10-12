# Lusid.Sdk.Model.ValuationRequest
Specification object for the parameters of a valuation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**AsAt** | **DateTimeOffset?** | The asAt date to use | [optional] 
**Metrics** | [**List&lt;AggregateSpec&gt;**](AggregateSpec.md) | The set of specifications to calculate or retrieve during the valuation and present in the results. For example:  AggregateSpec(&#39;Valuation/PV&#39;,&#39;Sum&#39;) for returning the PV (present value) of holdings  AggregateSpec(&#39;Holding/default/Units&#39;,&#39;Sum&#39;) for returning the units of holidays  AggregateSpec(&#39;Instrument/default/LusidInstrumentId&#39;,&#39;Value&#39;) for returning the Lusid Instrument identifier | 
**GroupBy** | **List&lt;string&gt;** | The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping  that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out. | [optional] 
**Filters** | [**List&lt;PropertyFilter&gt;**](PropertyFilter.md) | A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement.  For example, filter a set of values within a given range or matching a particular value. | [optional] 
**Sort** | [**List&lt;OrderBySpec&gt;**](OrderBySpec.md) | A (possibly empty/null) set of specifications for how to order the results. | [optional] 
**ReportCurrency** | **string** | Three letter ISO currency string indicating what currency to report in for ReportCurrency denominated queries.  If not present, then the currency of the relevant portfolio will be used in its place. | [optional] 
**EquipWithSubtotals** | **bool** | Flag directing the Valuation call to populate the results with subtotals of aggregates. | [optional] 
**ReturnResultAsExpandedTypes** | **bool** | For complex results or financially meaningful results,  there is a need for a result to contain metadata about its currency and/or units  or to have a more complicated 1D or 2D structure | [optional] 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The set of portfolio or portfolio group identifier(s) that is to be valued. | 
**ValuationSchedule** | [**ValuationSchedule**](ValuationSchedule.md) |  | 
**MarketDataOverrides** | [**MarketDataOverrides**](MarketDataOverrides.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

