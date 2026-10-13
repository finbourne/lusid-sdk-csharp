# Lusid.Sdk.Model.FeeSizeTier

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LowerBound** | **decimal** |  | 
**UpperBound** | **decimal?** |  | [optional] 
**Rate** | **decimal** |  | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal lowerBound = "lowerBound";
decimal rate = "rate";


FeeSizeTier feeSizeTierInstance = new FeeSizeTier(
    lowerBound: lowerBound,
    upperBound: upperBound,
    rate: rate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
