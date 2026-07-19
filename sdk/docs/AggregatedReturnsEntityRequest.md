# Lusid.Sdk.Model.AggregatedReturnsEntityRequest
The request body for the aggregated-returns (TWR) endpoint: the entity to calculate returns for, the  Returns entity that configures the calculation, the effective window, the metrics to calculate and the  period grid granularity. Supports a single `Portfolio` entity, the period `Return` metric and  a `Daily` grid.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | [**AggregatedReturnsEntityId**](AggregatedReturnsEntityId.md) |  | 
**ReturnsScope** | **string** |  | 
**ReturnsCode** | **string** |  | 
**Metrics** | [**List&lt;ReturnsMetric&gt;**](ReturnsMetric.md) |  | 
**Period** | **string** | Available values: Daily, Monthly. | [optional] 
**FromEffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) |  | [optional] 
**ToEffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) |  | [optional] 
**AsAt** | **DateTimeOffset?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

AggregatedReturnsEntityId entity = new AggregatedReturnsEntityId();
string returnsScope = "returnsScope";
string returnsCode = "returnsCode";
List<ReturnsMetric> metrics = new List<ReturnsMetric>();
string period = "example period";
DateTimeOrCutLabel fromEffectiveAt = "example fromEffectiveAt";
DateTimeOrCutLabel toEffectiveAt = "example toEffectiveAt";

AggregatedReturnsEntityRequest aggregatedReturnsEntityRequestInstance = new AggregatedReturnsEntityRequest(
    entity: entity,
    returnsScope: returnsScope,
    returnsCode: returnsCode,
    metrics: metrics,
    period: period,
    fromEffectiveAt: fromEffectiveAt,
    toEffectiveAt: toEffectiveAt,
    asAt: asAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
