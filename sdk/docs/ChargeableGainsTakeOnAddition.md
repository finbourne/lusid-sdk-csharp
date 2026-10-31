# Lusid.Sdk.Model.ChargeableGainsTakeOnAddition
One acquisition added to a taken-on 1982 holding since 31 March 1982, carried as its own record inside the holding

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTimeOffset** |  | 
**Cost** | **decimal** |  | 
**Indexation** | **decimal** |  | 
**PaidCost** | **decimal?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal cost = "cost";
decimal indexation = "indexation";


ChargeableGainsTakeOnAddition chargeableGainsTakeOnAdditionInstance = new ChargeableGainsTakeOnAddition(
    date: date,
    cost: cost,
    indexation: indexation,
    paidCost: paidCost);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
