# Lusid.Sdk.Model.RecResultDecisionGroup
The group-decision detail carried on every member of a FixAsGroup or ForceMatch decision.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupNumber** | **int** | Server-allocated, monotonic group number, unique within the RecResultSet and never reused. | 
**CoreRulesExcused** | **List&lt;string&gt;** | The ruleNames of the core rules excused by a ForceMatch. Identical on every group member; non-null only for ForceMatch. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> coreRulesExcused = new List<string>();

RecResultDecisionGroup recResultDecisionGroupInstance = new RecResultDecisionGroup(
    groupNumber: groupNumber,
    coreRulesExcused: coreRulesExcused);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
