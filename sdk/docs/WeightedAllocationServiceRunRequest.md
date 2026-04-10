# Lusid.Sdk.Model.WeightedAllocationServiceRunRequest
The request body for the RunAllocationServiceWithWeights endpoint.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PlacementIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The set of Placement IDs to allocate. | 
**PortfolioWeights** | [**List&lt;PortfolioWeight&gt;**](PortfolioWeight.md) | The set of Portfolios and their associated weights to use for allocation. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> placementIds = new List<ResourceId>();
List<PortfolioWeight> portfolioWeights = new List<PortfolioWeight>();

WeightedAllocationServiceRunRequest weightedAllocationServiceRunRequestInstance = new WeightedAllocationServiceRunRequest(
    placementIds: placementIds,
    portfolioWeights: portfolioWeights);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
