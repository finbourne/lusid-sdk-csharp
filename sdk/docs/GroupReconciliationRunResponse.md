# Lusid.Sdk.Model.GroupReconciliationRunResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ReconciliationSummaries** | [**List&lt;GroupReconciliationSummary&gt;**](GroupReconciliationSummary.md) | One summary record for each of the \&quot;Holding\&quot; | \&quot;Transaction\&quot; | \&quot;Valuation\&quot; reconciliations performed | 

```csharp
using Lusid.Sdk.Model;
using System;

List<GroupReconciliationSummary> reconciliationSummaries = new List<GroupReconciliationSummary>();

GroupReconciliationRunResponse groupReconciliationRunResponseInstance = new GroupReconciliationRunResponse(
    reconciliationSummaries: reconciliationSummaries);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
