# Lusid.Sdk.Model.ComplianceSummaryRuleResultRequest

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
**RuleBreakdown** | [**List&lt;ComplianceRuleBreakdownRequest&gt;**](ComplianceRuleBreakdownRequest.md) |  | 

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
List<ComplianceRuleBreakdownRequest> ruleBreakdown = new List<ComplianceRuleBreakdownRequest>();

ComplianceSummaryRuleResultRequest complianceSummaryRuleResultRequestInstance = new ComplianceSummaryRuleResultRequest(
    ruleId: ruleId,
    templateId: templateId,
    variation: variation,
    ruleStatus: ruleStatus,
    affectedPortfolios: affectedPortfolios,
    affectedOrders: affectedOrders,
    parametersUsed: parametersUsed,
    ruleBreakdown: ruleBreakdown);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
