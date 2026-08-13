# Lusid.Sdk.Model.RecResultDecisionUpdate
The decision update within a batch review item. Omitting the object leaves the existing decision  untouched; a null value nullifies it (dissolving any group).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | The decision value. Null nullifies the decision. Available values: Acknowledge, FixAtSource, FixAsGroup, Accept, ForceMatch, Tolerate. | [optional] 
**Affirm** | **bool** | Whether to affirm an existing decision (e.g. after revisions were requested). | [optional] 
**CoreRulesExcused** | **List&lt;string&gt;** | The ruleNames of the core rules excused by a ForceMatch. Identical on every group member; non-null only for ForceMatch. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string value = "example value";
bool affirm = //"True";
List<string> coreRulesExcused = new List<string>();

RecResultDecisionUpdate recResultDecisionUpdateInstance = new RecResultDecisionUpdate(
    value: value,
    affirm: affirm,
    coreRulesExcused: coreRulesExcused);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
