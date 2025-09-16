# Lusid.Sdk.Model.SweepBlocksResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, ResourceId&gt;**](ResourceId.md) | The identifiers of blocks which have been successfully swept, indexed by ephemeral request-lived id. | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The identifiers of blocks that could not be swept, along with a reason for their failure. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, ResourceId> values = new Dictionary<string, ResourceId>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();

SweepBlocksResponse sweepBlocksResponseInstance = new SweepBlocksResponse(
    values: values,
    failed: failed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
