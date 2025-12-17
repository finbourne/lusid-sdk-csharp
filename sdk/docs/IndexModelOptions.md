# Lusid.Sdk.Model.IndexModelOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelOptionsType** | **string** | The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, CdsModelOptions | 
**PortfolioScaling** | **string** | The available values are: Sum, AbsoluteSum, Unity | 
**LookthroughPortfolioRelationshipId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string portfolioScaling = "portfolioScaling";
ResourceId? lookthroughPortfolioRelationshipId = new ResourceId();


IndexModelOptions indexModelOptionsInstance = new IndexModelOptions(
    portfolioScaling: portfolioScaling,
    lookthroughPortfolioRelationshipId: lookthroughPortfolioRelationshipId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
