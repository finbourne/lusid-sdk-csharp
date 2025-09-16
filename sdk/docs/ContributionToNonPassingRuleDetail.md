# Lusid.Sdk.Model.ContributionToNonPassingRuleDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**RuleStatus** | **string** | The status of the non-passing rule. | [optional] 
**BreachTaskIds** | **List&lt;string&gt;** | The task ids associated with the compliance breach for this order&#39;s groups (if failing). | [optional] 
**LikelyResponsibleForStatus** | **bool** | Whether this order is deemed as a likely contributor to the non-passing rule for this group. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? ruleId = new ResourceId();

string ruleStatus = "example ruleStatus";
List<string> breachTaskIds = new List<string>();
bool likelyResponsibleForStatus = //"True";

ContributionToNonPassingRuleDetail contributionToNonPassingRuleDetailInstance = new ContributionToNonPassingRuleDetail(
    ruleId: ruleId,
    ruleStatus: ruleStatus,
    breachTaskIds: breachTaskIds,
    likelyResponsibleForStatus: likelyResponsibleForStatus);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
