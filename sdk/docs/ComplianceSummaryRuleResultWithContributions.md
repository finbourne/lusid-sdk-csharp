# Lusid.Sdk.Model.ComplianceSummaryRuleResultWithContributions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | [**ResourceId**](ResourceId.md) |  | 
**Status** | **string** |  | 
**CheckType** | **string** | The kind of check the rule applied across its groups: \&quot;PercentCheck\&quot; or \&quot;Check\&quot;. Static per rule. Absent for a  rule no check reached. | [optional] 
**AffectedPortfolios** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 
**AffectedOrders** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The orders the rule affected. Omitted for a holdings-based run. | [optional] 
**Groups** | [**List&lt;ComplianceRuleBreakdownWithContributions&gt;**](ComplianceRuleBreakdownWithContributions.md) |  | 
**OtherPositionsConsidered** | [**List&lt;ComplianceRuleContribution&gt;**](ComplianceRuleContribution.md) | The rest of the basis the rule was measured against but did not directly evaluate — the positions in  the referenced/denominator (or initial) group that are not in a group&#39;s contributions. Together with those  contributions this forms the whole basis, with no overlap, so a breach can be explained against the full picture  (e.g. the non-equity remainder behind an equity limit). Omitted when the rule evaluated everything it considered. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId ruleId = new ResourceId();
string status = "status";
string checkType = "example checkType";
List<ResourceId> affectedPortfolios = new List<ResourceId>();
List<ResourceId> affectedOrders = new List<ResourceId>();
List<ComplianceRuleBreakdownWithContributions> groups = new List<ComplianceRuleBreakdownWithContributions>();
List<ComplianceRuleContribution> otherPositionsConsidered = new List<ComplianceRuleContribution>();

ComplianceSummaryRuleResultWithContributions complianceSummaryRuleResultWithContributionsInstance = new ComplianceSummaryRuleResultWithContributions(
    ruleId: ruleId,
    status: status,
    checkType: checkType,
    affectedPortfolios: affectedPortfolios,
    affectedOrders: affectedOrders,
    groups: groups,
    otherPositionsConsidered: otherPositionsConsidered);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
