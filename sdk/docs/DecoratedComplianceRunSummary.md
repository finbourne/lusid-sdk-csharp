# Lusid.Sdk.Model.DecoratedComplianceRunSummary

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | [**ResourceId**](ResourceId.md) |  | 
**Details** | [**List&lt;ComplianceRuleResultDetail&gt;**](ComplianceRuleResultDetail.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId runId = new ResourceId();
List<ComplianceRuleResultDetail> details = new List<ComplianceRuleResultDetail>();

DecoratedComplianceRunSummary decoratedComplianceRunSummaryInstance = new DecoratedComplianceRunSummary(
    runId: runId,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
