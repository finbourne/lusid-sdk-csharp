# Lusid.Sdk.Model.BlockAndOrders

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Block** | [**Block**](Block.md) |  | 
**Orders** | [**List&lt;Order&gt;**](Order.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

Block block = new Block();
List<Order> orders = new List<Order>();

BlockAndOrders blockAndOrdersInstance = new BlockAndOrders(
    block: block,
    orders: orders);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
