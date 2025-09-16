# Lusid.Sdk.Model.ReconciliationSideConfiguration
Specification for one side of a valuations/positions scheduled reconciliation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**EffectiveAt** | **DateTimeOffset?** |  | [optional] 
**AsAt** | **DateTimeOffset?** |  | [optional] 
**Currency** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? recipeId = new ResourceId();

string currency = "example currency";

ReconciliationSideConfiguration reconciliationSideConfigurationInstance = new ReconciliationSideConfiguration(
    recipeId: recipeId,
    effectiveAt: effectiveAt,
    asAt: asAt,
    currency: currency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
