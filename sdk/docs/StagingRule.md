# Lusid.Sdk.Model.StagingRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | **string** | The ID of the staging rule. | 
**Description** | **string** | A description for the staging rule. | [optional] 
**Status** | **string** | Whether the rule is &#39;Active&#39; or &#39;Inactive&#39;. | 
**MatchCriteria** | [**StagingRuleMatchCriteria**](StagingRuleMatchCriteria.md) |  | 
**ApprovalCriteria** | [**StagingRuleApprovalCriteria**](StagingRuleApprovalCriteria.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string ruleId = "ruleId";
string description = "example description";
string status = "status";
StagingRuleMatchCriteria matchCriteria = new StagingRuleMatchCriteria();
StagingRuleApprovalCriteria approvalCriteria = new StagingRuleApprovalCriteria();

StagingRule stagingRuleInstance = new StagingRule(
    ruleId: ruleId,
    description: description,
    status: status,
    matchCriteria: matchCriteria,
    approvalCriteria: approvalCriteria);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
