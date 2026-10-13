# Lusid.Sdk.Model.CarryParameters

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CarryRate** | **decimal** |  | 
**PreferredReturnRate** | **decimal?** |  | [optional] 
**CatchUpRate** | **decimal?** |  | [optional] 
**WaterfallType** | **string** | Available values: WholeOfFund, DealByDeal. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal carryRate = "carryRate";

string waterfallType = "example waterfallType";

CarryParameters carryParametersInstance = new CarryParameters(
    carryRate: carryRate,
    preferredReturnRate: preferredReturnRate,
    catchUpRate: catchUpRate,
    waterfallType: waterfallType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
