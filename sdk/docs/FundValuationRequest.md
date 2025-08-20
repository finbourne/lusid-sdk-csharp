# Lusid.Sdk.Model.FundValuationRequest
Specification object for the parameters of a valuation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset?** | The asAt date to use. | [optional] 
**Metrics** | [**List&lt;AggregateSpec&gt;**](AggregateSpec.md) | The set of specifications to calculate or retrieve during the valuation and present in the results. For example: AggregateSpec(&#39;Valuation/PV&#39;,&#39;Sum&#39;) for returning the PV (present value) of holdings AggregateSpec(&#39;Holding/default/Units&#39;,&#39;Sum&#39;) for returning the units of holidays AggregateSpec(&#39;Instrument/default/LusidInstrumentId&#39;,&#39;Value&#39;) for returning the Lusid Instrument identifier | 
**GroupBy** | **List&lt;string&gt;** | The set of items by which to perform grouping. This primarily matters when one or more of the metric operators is a mapping that reduces set size, e.g. sum or proportion. The group-by statement determines the set of keys by which to break the results out. | [optional] 
**Filters** | [**List&lt;PropertyFilter&gt;**](PropertyFilter.md) | A set of filters to use to reduce the data found in a request. Equivalent to the &#39;where ...&#39; part of a Sql select statement. For example, filter a set of values within a given range or matching a particular value. | [optional] 
**Sort** | [**List&lt;OrderBySpec&gt;**](OrderBySpec.md) | A (possibly empty/null) set of specifications for how to order the results. | [optional] 
**EquipWithSubtotals** | **bool** | Flag directing the Valuation call to populate the results with subtotals of aggregates. | [optional] 
**ReturnResultAsExpandedTypes** | **bool** | Financially meaningful results can be presented as either simple flat types or more complex expanded types. For example, the present value (PV) of a holding could be represented either as a simple decimal (with currency implied) or as a decimal-currency pair. This flag allows either representation to be returned. In the PV example, the returned value would be the decimal-currency pair if this flag is true, or the decimal only if this flag is false. | [optional] 
**IncludeOrderFlow** | [**OrderFlowConfiguration**](OrderFlowConfiguration.md) |  | [optional] 
**FundValuationSchedule** | [**FundValuationSchedule**](FundValuationSchedule.md) |  | 
**MarketDataOverrides** | [**MarketDataOverrides**](MarketDataOverrides.md) |  | [optional] 
**CorporateActionSourceId** | [**ResourceId**](ResourceId.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

