# Lusid.Sdk.Model.ComplianceRuleBreakdownWithContributions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GroupId** | **int** | A stable identifier for this group within the rule, matching the same group in the rule-result endpoint. | 
**Status** | **string** | The status of this subset of results. | 
**GroupKey** | [**ComplianceGroupKey**](ComplianceGroupKey.md) |  | [optional] 
**Nav** | **decimal?** | The portfolio net asset value the group sits within. Absent where no contribution carried it. | [optional] 
**Results** | **Dictionary&lt;string, decimal&gt;** | The valuation result totals the group aggregated. Omitted when empty. | [optional] 
**Comparisons** | [**List&lt;ComplianceComparison&gt;**](ComplianceComparison.md) | Every leaf comparison the check criterion made for this group, drawn from both the hard and the soft limit.  Omitted for a group no check reached. | [optional] 
**Properties** | **Dictionary&lt;string, List&lt;Property&gt;&gt;** | The property values the group aggregated. Omitted when empty. | [optional] 
**FormulaValues** | **Dictionary&lt;string, decimal&gt;** | The value each formula within the check criterion evaluated to for this group. Omitted when empty. | [optional] 
**Contributions** | [**List&lt;ComplianceRuleContribution&gt;**](ComplianceRuleContribution.md) | The per-position contributions aggregated into this rule breakdown group. Empty when the run  genuinely produced no contributions; a run with no recorded breakdown (e.g. one that predates  this feature) returns a 404 rather than this response. | 
**MissingDataInformation** | **List&lt;string&gt;** | List of string information detailing data that was missing from contributions processed in this rule. Omitted when empty. | [optional] 
**ContributionCount** | **int** | The number of contributions aggregated into this group, before any cap. | 
**ContributionsTruncated** | **bool** | Whether the reported contributions were capped below ContributionCount. Always false today. | 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "status";
ComplianceGroupKey? groupKey = new ComplianceGroupKey();

Dictionary<string, decimal> results = new Dictionary<string, decimal>();
List<ComplianceComparison> comparisons = new List<ComplianceComparison>();
Dictionary<string, List<Property>> properties = new Dictionary<string, List<Property>>();
Dictionary<string, decimal> formulaValues = new Dictionary<string, decimal>();
List<ComplianceRuleContribution> contributions = new List<ComplianceRuleContribution>();
List<string> missingDataInformation = new List<string>();
bool contributionsTruncated = //"True";

ComplianceRuleBreakdownWithContributions complianceRuleBreakdownWithContributionsInstance = new ComplianceRuleBreakdownWithContributions(
    groupId: groupId,
    status: status,
    groupKey: groupKey,
    nav: nav,
    results: results,
    comparisons: comparisons,
    properties: properties,
    formulaValues: formulaValues,
    contributions: contributions,
    missingDataInformation: missingDataInformation,
    contributionCount: contributionCount,
    contributionsTruncated: contributionsTruncated);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
