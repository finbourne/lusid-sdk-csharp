# Lusid.Sdk.Model.MarginCallReference
A pointer to a margin call in another run.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **string** | The run the referenced call belongs to. | 
**CallId** | **string** | The business key of the referenced call. | 

```csharp
using Lusid.Sdk.Model;
using System;

string runId = "runId";
string callId = "callId";

MarginCallReference marginCallReferenceInstance = new MarginCallReference(
    runId: runId,
    callId: callId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
