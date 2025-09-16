# Lusid.Sdk.Model.OrderBreachHistory

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**OrderId** | [**ResourceId**](ResourceId.md) |  | 
**RunId** | [**ResourceId**](ResourceId.md) |  | 
**BreachesByRule** | **Dictionary&lt;string, List&lt;OrderRuleBreach&gt;&gt;** | Compliance rule breaches associations with the order and run. | [optional] 
**AsAt** | **DateTimeOffset** | The asAt datetime at which the order breach was created in LUSID. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
ResourceId orderId = new ResourceId();
ResourceId runId = new ResourceId();
Dictionary<string, List<OrderRuleBreach>> breachesByRule = new Dictionary<string, List<OrderRuleBreach>>();

OrderBreachHistory orderBreachHistoryInstance = new OrderBreachHistory(
    id: id,
    orderId: orderId,
    runId: runId,
    breachesByRule: breachesByRule,
    asAt: asAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
