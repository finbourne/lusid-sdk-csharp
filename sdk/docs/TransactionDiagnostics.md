# Lusid.Sdk.Model.TransactionDiagnostics
Represents a set of diagnostics per transaction, where applicable.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionDisplayName** | **string** |  | 
**ErrorDetails** | **List&lt;string&gt;** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string transactionDisplayName = "transactionDisplayName";
List<string> errorDetails = new List<string>();

TransactionDiagnostics transactionDiagnosticsInstance = new TransactionDiagnostics(
    transactionDisplayName: transactionDisplayName,
    errorDetails: errorDetails);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
