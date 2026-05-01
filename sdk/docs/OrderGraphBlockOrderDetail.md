# Lusid.Sdk.Model.OrderGraphBlockOrderDetail

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**ComplianceState** | **string** | The compliance state of this order. Available values: Pending, Failed, Passed, ManuallyApproved, PartiallyOverridden, Warning. | 
**ApprovalState** | **string** | The approval state of this order. Available values: Pending, Rejected, Approved. | 
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
