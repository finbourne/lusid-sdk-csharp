# Lusid.Sdk.Model.OrderGraphBlockOrderDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**ComplianceState** | **string** | The compliance state of this order. Possible values are &#39;Pending&#39;, &#39;Failed&#39;, &#39;Manually approved&#39;, &#39;Passed&#39; and &#39;Warning&#39;. | 
**ApprovalState** | **string** | The approval state of this order. Possible values are &#39;Pending&#39;, &#39;Rejected&#39; and &#39;Approved&#39;. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PortfolioName** | **string** | The name of the order&#39;s referenced Portfolio. | [optional] 
**OrderApprovalTaskId** | **string** | The task id associated with the approval state of the order. | [optional] 
**OrderApprovalTaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**NonPassingComplianceRuleResults** | [**List&lt;ContributionToNonPassingRuleDetail&gt;**](ContributionToNonPassingRuleDetail.md) | The details of compliance rules in non-passing states. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string complianceState = "complianceState";
string approvalState = "approvalState";
ResourceId? portfolioId = new ResourceId();

string portfolioName = "example portfolioName";
string orderApprovalTaskId = "example orderApprovalTaskId";
ResourceId? orderApprovalTaskDefinitionId = new ResourceId();

List<ContributionToNonPassingRuleDetail> nonPassingComplianceRuleResults = new List<ContributionToNonPassingRuleDetail>();

OrderGraphBlockOrderDetail orderGraphBlockOrderDetailInstance = new OrderGraphBlockOrderDetail(
    id: id,
    complianceState: complianceState,
    approvalState: approvalState,
    portfolioId: portfolioId,
    portfolioName: portfolioName,
    orderApprovalTaskId: orderApprovalTaskId,
    orderApprovalTaskDefinitionId: orderApprovalTaskDefinitionId,
    nonPassingComplianceRuleResults: nonPassingComplianceRuleResults);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
