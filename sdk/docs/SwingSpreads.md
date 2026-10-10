# Lusid.Sdk.Model.SwingSpreads
The stored spreads a Single fund swings by, one set for each direction of net cashflow.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Inflow** | [**DirectionSpreads**](DirectionSpreads.md) |  | [optional] 
**Outflow** | [**DirectionSpreads**](DirectionSpreads.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DirectionSpreads? inflow = new DirectionSpreads();

DirectionSpreads? outflow = new DirectionSpreads();


SwingSpreads swingSpreadsInstance = new SwingSpreads(
    inflow: inflow,
    outflow: outflow);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
