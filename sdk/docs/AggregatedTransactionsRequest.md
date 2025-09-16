# Lusid.Sdk.Model.AggregatedTransactionsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FromTransactionDate** | **DateTimeOffset** |  | 
**ToTransactionDate** | **DateTimeOffset** |  | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The set of portfolio or portfolio group identifiers containing the relevant transactions. | [optional] 
**AsAt** | **DateTimeOffset?** |  | [optional] 
**Metrics** | [**List&lt;AggregateSpec&gt;**](AggregateSpec.md) |  | 
**GroupBy** | **List&lt;string&gt;** |  | [optional] 
**Filters** | [**List&lt;PropertyFilter&gt;**](PropertyFilter.md) |  | [optional] 
**Sort** | [**List&lt;OrderBySpec&gt;**](OrderBySpec.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? portfolioId = new ResourceId();

List<PortfolioEntityId> portfolioEntityIds = new List<PortfolioEntityId>();
List<AggregateSpec> metrics = new List<AggregateSpec>();
List<string> groupBy = new List<string>();
List<PropertyFilter> filters = new List<PropertyFilter>();
List<OrderBySpec> sort = new List<OrderBySpec>();

AggregatedTransactionsRequest aggregatedTransactionsRequestInstance = new AggregatedTransactionsRequest(
    fromTransactionDate: fromTransactionDate,
    toTransactionDate: toTransactionDate,
    portfolioId: portfolioId,
    portfolioEntityIds: portfolioEntityIds,
    asAt: asAt,
    metrics: metrics,
    groupBy: groupBy,
    filters: filters,
    sort: sort);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
