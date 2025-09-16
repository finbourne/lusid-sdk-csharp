# Lusid.Sdk.Model.LevelStep
Item which is stepped in level/quantity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTimeOffset** | The date from which the level should apply. | 
**Quantity** | **decimal** | The quantity which is applied. This might be an absolute, percentage, fractional or other value. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal quantity = "quantity";


LevelStep levelStepInstance = new LevelStep(
    date: date,
    quantity: quantity);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
