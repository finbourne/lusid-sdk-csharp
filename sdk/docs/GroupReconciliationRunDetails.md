# Lusid.Sdk.Model.GroupReconciliationRunDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CompletionStatus** | **string** | Provides the reconciliation completion status \&quot;Completed\&quot; | \&quot;FailedToComplete\&quot; | 
**ErrorDetail** | **string** | Error information if the reconciliation failed to complete | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string completionStatus = "completionStatus";
string errorDetail = "example errorDetail";

GroupReconciliationRunDetails groupReconciliationRunDetailsInstance = new GroupReconciliationRunDetails(
    completionStatus: completionStatus,
    errorDetail: errorDetail);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
