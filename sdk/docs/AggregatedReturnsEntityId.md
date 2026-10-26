# Lusid.Sdk.Model.AggregatedReturnsEntityId
Identifies an entity whose aggregated (time-weighted) returns are calculated: its scope, code and  type. Mirrors the valuation endpoint's entity identifier. Supports the `Portfolio` and  `PortfolioGroup` entity types.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** |  | 
**Code** | **string** |  | 
**EntityType** | **string** | Available values: Portfolio, PortfolioGroup. | 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string entityType = "entityType";

AggregatedReturnsEntityId aggregatedReturnsEntityIdInstance = new AggregatedReturnsEntityId(
    scope: scope,
    code: code,
    entityType: entityType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
