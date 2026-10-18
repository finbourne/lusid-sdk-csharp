# Lusid.Sdk.Model.BatchAcceptMarginCallsResponse
The outcome of accepting several margin calls: those accepted, and those refused with the reason.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;MarginCall&gt;**](MarginCall.md) | The calls that were accepted. | 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The calls that could not be accepted, keyed by call id, with the reason. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<MarginCall> values = new List<MarginCall>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();

BatchAcceptMarginCallsResponse batchAcceptMarginCallsResponseInstance = new BatchAcceptMarginCallsResponse(
    values: values,
    failed: failed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
