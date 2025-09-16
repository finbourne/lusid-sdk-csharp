# Lusid.Sdk.Model.MoveOrdersToDifferentBlocksRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Requests** | [**List&lt;BlockAndOrderIdRequest&gt;**](BlockAndOrderIdRequest.md) | A collection of BlockAndOrderId. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<BlockAndOrderIdRequest> requests = new List<BlockAndOrderIdRequest>();

MoveOrdersToDifferentBlocksRequest moveOrdersToDifferentBlocksRequestInstance = new MoveOrdersToDifferentBlocksRequest(
    requests: requests);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
