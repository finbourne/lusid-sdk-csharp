# Lusid.Sdk.Model.PlacementSetRequest
A request to create or update multiple Placements.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Requests** | [**List&lt;PlacementRequest&gt;**](PlacementRequest.md) | A collection of PlacementRequests. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<PlacementRequest> requests = new List<PlacementRequest>();

PlacementSetRequest placementSetRequestInstance = new PlacementSetRequest(
    requests: requests);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
