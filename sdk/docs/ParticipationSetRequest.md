# Lusid.Sdk.Model.ParticipationSetRequest
A request to create or update multiple Participations.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Requests** | [**List&lt;ParticipationRequest&gt;**](ParticipationRequest.md) | A collection of ParticipationRequests. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ParticipationRequest> requests = new List<ParticipationRequest>();

ParticipationSetRequest participationSetRequestInstance = new ParticipationSetRequest(
    requests: requests);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
