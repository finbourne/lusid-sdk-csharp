# Lusid.Sdk.Model.ExecutionSetRequest
A request to create or update multiple Executions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Requests** | [**List&lt;ExecutionRequest&gt;**](ExecutionRequest.md) | A collection of ExecutionRequests. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ExecutionRequest> requests = new List<ExecutionRequest>();

ExecutionSetRequest executionSetRequestInstance = new ExecutionSetRequest(
    requests: requests);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
