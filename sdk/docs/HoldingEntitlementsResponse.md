# Lusid.Sdk.Model.HoldingEntitlementsResponse
The holding entitlements that were upserted, and the failures for those that could not be.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, HoldingEntitlement&gt;**](HoldingEntitlement.md) | The collection of successfully upserted entitlements | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) | The collection of error information for entitlements that could not be upserted | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, HoldingEntitlement> values = new Dictionary<string, HoldingEntitlement>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();

HoldingEntitlementsResponse holdingEntitlementsResponseInstance = new HoldingEntitlementsResponse(
    values: values,
    failed: failed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
