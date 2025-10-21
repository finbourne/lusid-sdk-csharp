# Lusid.Sdk.Model.RunCheckRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LusidEntityDataset** | [**LusidEntityDataset**](LusidEntityDataset.md) |  | [optional] 
**LimitIndividualBreachesPerRule** | **int** | The maximum number of individual breaches to return per rule. Defaults to 100 if not specified. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

LusidEntityDataset? lusidEntityDataset = new LusidEntityDataset();


RunCheckRequest runCheckRequestInstance = new RunCheckRequest(
    lusidEntityDataset: lusidEntityDataset,
    limitIndividualBreachesPerRule: limitIndividualBreachesPerRule);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
