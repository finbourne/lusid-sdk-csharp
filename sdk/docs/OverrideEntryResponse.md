# Lusid.Sdk.Model.OverrideEntryResponse
A single overrides entry on a virtual transaction override record: the replacement transaction(s) that  stand in for the overridden virtual transaction, plus its status and diagnostics.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Replacements** | [**List&lt;OverrideDefinitionResponse&gt;**](OverrideDefinitionResponse.md) | The replacement transactions that stand in for the overridden virtual transaction. | [optional] 
**Status** | **string** | Whether this entry&#39;s target virtual transaction id still matches one the event currently generates. Available values: Applied, Orphaned, Superseded. | [optional] 
**VirtualTransactionId** | **string** | The id of the virtual transaction this entry targets, as it appears in the requested portfolio. Null when the entry targets no virtual transaction the requested portfolio currently generates. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<OverrideDefinitionResponse> replacements = new List<OverrideDefinitionResponse>();
string status = "example status";
string virtualTransactionId = "example virtualTransactionId";

OverrideEntryResponse overrideEntryResponseInstance = new OverrideEntryResponse(
    replacements: replacements,
    status: status,
    virtualTransactionId: virtualTransactionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
