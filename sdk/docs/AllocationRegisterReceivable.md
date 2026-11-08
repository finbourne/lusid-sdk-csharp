# Lusid.Sdk.Model.AllocationRegisterReceivable
What one register is owed on a booked capital call, across every record called on its lines.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Portfolio** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Called** | **decimal** | What was called on the register&#39;s lines. | [optional] 
**Received** | **decimal** | What has settled the register&#39;s lines so far. | [optional] 
**Outstanding** | **decimal** | What the register is still owed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? portfolio = new ResourceId();
decimal? called = "example called";decimal? received = "example received";decimal? outstanding = "example outstanding";

AllocationRegisterReceivable allocationRegisterReceivableInstance = new AllocationRegisterReceivable(
    portfolio: portfolio,
    called: called,
    received: received,
    outstanding: outstanding);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
