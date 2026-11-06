# Lusid.Sdk.Model.ComplianceRunV3Response
The outcome of a V3 compliance run: the result of each rule that was run.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RuleResults** | [**List&lt;ComplianceRuleV3RuleResult&gt;**](ComplianceRuleV3RuleResult.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ComplianceRuleV3RuleResult> ruleResults = new List<ComplianceRuleV3RuleResult>();
List<Link> links = new List<Link>();

ComplianceRunV3Response complianceRunV3ResponseInstance = new ComplianceRunV3Response(
    ruleResults: ruleResults,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
