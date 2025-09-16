# Lusid.Sdk.Model.SweepBlocksRequest
A request to sweep specified blocks.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockIds** | [**Dictionary&lt;string, ResourceId&gt;**](ResourceId.md) | A dictionary mapping ephemeral identifiers, which live as long as the request, to specific blocks to sweep. | 
**LatestAllowableModificationTime** | **string** | Timestamp or cut label which the  block or related entities must not have been updated after. | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, ResourceId> blockIds = new Dictionary<string, ResourceId>();
string latestAllowableModificationTime = "latestAllowableModificationTime";

SweepBlocksRequest sweepBlocksRequestInstance = new SweepBlocksRequest(
    blockIds: blockIds,
    latestAllowableModificationTime: latestAllowableModificationTime);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
