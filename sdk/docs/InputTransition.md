# Lusid.Sdk.Model.InputTransition
The input 'transition' within a corporate action, representing the singular input position

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**UnitsFactor** | **decimal** | The factor to scale units by | 
**CostFactor** | **decimal** | The factor to scale cost by | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal unitsFactor = "unitsFactor";
decimal costFactor = "costFactor";


InputTransition inputTransitionInstance = new InputTransition(
    unitsFactor: unitsFactor,
    costFactor: costFactor);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
