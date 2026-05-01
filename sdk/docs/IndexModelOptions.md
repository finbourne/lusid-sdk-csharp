# Lusid.Sdk.Model.IndexModelOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelOptionsType** | **string** | Available values: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, CdsModelOptions. | 
**PortfolioScaling** | **string** | Available values: Sum, AbsoluteSum, Unity. | 
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
