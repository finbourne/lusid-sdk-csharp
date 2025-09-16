# Lusid.Sdk.Model.ComplianceRuleResultDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleId** | [**ResourceId**](ResourceId.md) |  | 
**AffectedPortfoliosDetails** | [**List&lt;ComplianceRuleResultPortfolioDetail&gt;**](ComplianceRuleResultPortfolioDetail.md) |  | 
**AffectedOrders** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 
**TemplateId** | [**ResourceId**](ResourceId.md) |  | 
**TemplateDescription** | **string** |  | 
**TemplateVariation** | **string** |  | 
**Status** | **string** |  | 
**RuleName** | **string** |  | 
**RuleDescription** | **string** |  | 
**Outcome** | **string** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId ruleId = new ResourceId();
List<ComplianceRuleResultPortfolioDetail> affectedPortfoliosDetails = new List<ComplianceRuleResultPortfolioDetail>();
List<ResourceId> affectedOrders = new List<ResourceId>();
ResourceId templateId = new ResourceId();
string templateDescription = "templateDescription";
string templateVariation = "templateVariation";
string status = "status";
string ruleName = "ruleName";
string ruleDescription = "ruleDescription";
string outcome = "outcome";

ComplianceRuleResultDetail complianceRuleResultDetailInstance = new ComplianceRuleResultDetail(
    ruleId: ruleId,
    affectedPortfoliosDetails: affectedPortfoliosDetails,
    affectedOrders: affectedOrders,
    templateId: templateId,
    templateDescription: templateDescription,
    templateVariation: templateVariation,
    status: status,
    ruleName: ruleName,
    ruleDescription: ruleDescription,
    outcome: outcome);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
