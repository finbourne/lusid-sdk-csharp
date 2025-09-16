# Lusid.Sdk.Model.SpecificHoldingPricingInfo
Allows a user to specify fallbacks/overrides using Holding fields for sources that match a particular DependencySourceFilter.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DependencySourceFilter** | [**DependencySourceFilter**](DependencySourceFilter.md) |  | 
**Field** | **string** | The Holding field which the fallback/override should use to create a price quote. | 

```csharp
using Lusid.Sdk.Model;
using System;

DependencySourceFilter dependencySourceFilter = new DependencySourceFilter();
string field = "field";

SpecificHoldingPricingInfo specificHoldingPricingInfoInstance = new SpecificHoldingPricingInfo(
    dependencySourceFilter: dependencySourceFilter,
    field: field);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
