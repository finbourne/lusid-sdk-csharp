# Lusid.Sdk.Model.AllocationServiceRunResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> values = new List<ResourceId>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();

AllocationServiceRunResponse allocationServiceRunResponseInstance = new AllocationServiceRunResponse(
    values: values,
    failed: failed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
