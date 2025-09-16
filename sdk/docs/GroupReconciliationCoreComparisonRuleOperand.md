# Lusid.Sdk.Model.GroupReconciliationCoreComparisonRuleOperand

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key of the value to compare | 
**Operation** | **string** | What to do with the value pointed to by the key, e.g. Sum. Only \&quot;Value is allowed for core rules\&quot; | 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
string operation = "operation";

GroupReconciliationCoreComparisonRuleOperand groupReconciliationCoreComparisonRuleOperandInstance = new GroupReconciliationCoreComparisonRuleOperand(
    key: key,
    operation: operation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
