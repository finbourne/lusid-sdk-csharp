# Lusid.Sdk.Model.StagedModificationStagingRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StagingRuleSetId** | **string** | System generated unique id for the staging rule set. | [optional] 
**RuleId** | **string** | The ID of the staging rule. | [optional] 
**RequiredApprovals** | **int** | The number of approvals required. If left blank, one approval is needed. | [optional] 
**CurrentUserCanDecide** | **bool** | True or False indicating whether the current user can make a decision on the staged modification. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string stagingRuleSetId = "example stagingRuleSetId";
string ruleId = "example ruleId";
bool currentUserCanDecide = //"True";

StagedModificationStagingRule stagedModificationStagingRuleInstance = new StagedModificationStagingRule(
    stagingRuleSetId: stagingRuleSetId,
    ruleId: ruleId,
    requiredApprovals: requiredApprovals,
    currentUserCanDecide: currentUserCanDecide);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
