# Lusid.Sdk.Model.BlockSetRequest
A request to create or update multiple Blocks.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Requests** | [**List&lt;BlockRequest&gt;**](BlockRequest.md) | A collection of BlockRequests. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<BlockRequest> requests = new List<BlockRequest>();

BlockSetRequest blockSetRequestInstance = new BlockSetRequest(
    requests: requests);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
