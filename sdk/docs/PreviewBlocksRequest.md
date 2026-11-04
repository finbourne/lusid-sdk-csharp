# Lusid.Sdk.Model.PreviewBlocksRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Orders** | [**List&lt;OrderRequest&gt;**](OrderRequest.md) | The orders to group into blocks. Properties in the Block domain are taken as the block&#39;s properties and form part of the grouping key. | 
**GroupingMode** | **string** | How orders are grouped. None: one block per order. SameSide: orders sharing instrument, side, type, time in force, price (for Limit and Stop), basis, date and block properties share a block. CrossSide: as SameSide but ignoring side, so opposing orders may net into one block, provided each portfolio&#39;s net for the instrument has the same sign as the block&#39;s first portfolio. Available values: None, SameSide, CrossSide. | [optional] 
**BlockId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<OrderRequest> orders = new List<OrderRequest>();
string groupingMode = "example groupingMode";
ResourceId? blockId = new ResourceId();


PreviewBlocksRequest previewBlocksRequestInstance = new PreviewBlocksRequest(
    orders: orders,
    groupingMode: groupingMode,
    blockId: blockId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
