# Lusid.Sdk.Model.OrderFlowConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IncludeEntityTypes** | **string** | Controls whether Orders and Allocations orders are included in the Portfolio valuation.  Valid values are  None (to account for Transactions only), Allocations (to include Allocations and Transactions) and  OrdersAndAllocations (to include Orders, Allocations and Transactions). | 

```csharp
using Lusid.Sdk.Model;
using System;

string includeEntityTypes = "includeEntityTypes";

OrderFlowConfiguration orderFlowConfigurationInstance = new OrderFlowConfiguration(
    includeEntityTypes: includeEntityTypes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
