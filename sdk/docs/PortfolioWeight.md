# Lusid.Sdk.Model.PortfolioWeight
Represents a portfolio and its target allocation weight.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**Weight** | **decimal** | The relative weight of the Portfolio compared to the other Portfolios specified, used to determine the allocation split between Portfolios when there are no Orders within the Block to allocate to. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();decimal weight = "weight";


PortfolioWeight portfolioWeightInstance = new PortfolioWeight(
    portfolioId: portfolioId,
    weight: weight);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
