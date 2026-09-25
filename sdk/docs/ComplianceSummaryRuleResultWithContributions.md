# Lusid.Sdk.Model.ComplianceSummaryRuleResultWithContributions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | [**ResourceId**](ResourceId.md) |  | 
**TemplateId** | [**ResourceId**](ResourceId.md) |  | 
**Variation** | **string** |  | 
**RuleStatus** | **string** |  | 
**AffectedPortfolios** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 
**AffectedOrders** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 
**ParametersUsed** | **Dictionary&lt;string, string&gt;** |  | 
**RuleBreakdown** | [**List&lt;ComplianceRuleBreakdownWithContributions&gt;**](ComplianceRuleBreakdownWithContributions.md) |  | 
**OtherPositionsConsidered** | [**List&lt;ComplianceRuleContribution&gt;**](ComplianceRuleContribution.md) | The rest of the basis the rule was measured against but did not directly evaluate — the positions in  the referenced/denominator (or initial) group that are not in the RuleBreakdown&#39;s  contributions. Together with those contributions this forms the whole basis, with no overlap, so a  breach can be explained against the full picture (e.g. the non-equity remainder behind an equity limit).  Empty when the rule evaluated everything it considered. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId ruleId = new ResourceId();
ResourceId templateId = new ResourceId();
string variation = "variation";
string ruleStatus = "ruleStatus";
List<ResourceId> affectedPortfolios = new List<ResourceId>();
List<ResourceId> affectedOrders = new List<ResourceId>();
Dictionary<string, string> parametersUsed = new Dictionary<string, string>();
List<ComplianceRuleBreakdownWithContributions> ruleBreakdown = new List<ComplianceRuleBreakdownWithContributions>();
List<ComplianceRuleContribution> otherPositionsConsidered = new List<ComplianceRuleContribution>();

ComplianceSummaryRuleResultWithContributions complianceSummaryRuleResultWithContributionsInstance = new ComplianceSummaryRuleResultWithContributions(
    ruleId: ruleId,
    templateId: templateId,
    variation: variation,
    ruleStatus: ruleStatus,
    affectedPortfolios: affectedPortfolios,
    affectedOrders: affectedOrders,
    parametersUsed: parametersUsed,
    ruleBreakdown: ruleBreakdown,
    otherPositionsConsidered: otherPositionsConsidered);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
