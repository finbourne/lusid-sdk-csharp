# Lusid.Sdk.Model.OrderInstructionSetRequest
A request to create or update multiple OrderInstructions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Requests** | [**List&lt;OrderInstructionRequest&gt;**](OrderInstructionRequest.md) | A collection of OrderInstructionRequests. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<OrderInstructionRequest> requests = new List<OrderInstructionRequest>();

OrderInstructionSetRequest orderInstructionSetRequestInstance = new OrderInstructionSetRequest(
    requests: requests);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
