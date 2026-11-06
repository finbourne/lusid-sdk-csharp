# Lusid.Sdk.Model.ComplianceRuleV3RuleResult
The aggregate result of one rule across every group it was evaluated over: the rule's overall status  (its worst group outcome) and the per-group results partitioned by outcome.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Status** | **string** | Available values: Passed, Failed, Warning, MissingData. | [optional] 
**Results** | [**List&lt;ComplianceRuleV3GroupResult&gt;**](ComplianceRuleV3GroupResult.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? ruleId = new ResourceId();

string status = "example status";
List<ComplianceRuleV3GroupResult> results = new List<ComplianceRuleV3GroupResult>();

ComplianceRuleV3RuleResult complianceRuleV3RuleResultInstance = new ComplianceRuleV3RuleResult(
    ruleId: ruleId,
    status: status,
    results: results);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
