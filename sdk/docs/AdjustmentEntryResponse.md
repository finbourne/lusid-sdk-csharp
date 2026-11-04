# Lusid.Sdk.Model.AdjustmentEntryResponse
A single adjustments entry on a virtual transaction override record: the fields it changes and its status.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Adjustment** | [**AdjustmentDefinitionResponse**](AdjustmentDefinitionResponse.md) |  | [optional] 
**Status** | **string** | Whether this entry&#39;s target virtual transaction id still matches one the event currently generates. Available values: Applied, Orphaned, Superseded. | [optional] 
**VirtualTransactionId** | **string** | The id of the virtual transaction this entry targets, as it appears in the requested portfolio. Null when the entry targets no virtual transaction the requested portfolio currently generates. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

AdjustmentDefinitionResponse? adjustment = new AdjustmentDefinitionResponse();

string status = "example status";
string virtualTransactionId = "example virtualTransactionId";

AdjustmentEntryResponse adjustmentEntryResponseInstance = new AdjustmentEntryResponse(
    adjustment: adjustment,
    status: status,
    virtualTransactionId: virtualTransactionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
