# Lusid.Sdk.Model.ComplianceBreachedOrderInfo

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | [**ResourceId**](ResourceId.md) |  | 
**ListRuleResult** | [**List&lt;ComplianceRuleResult&gt;**](ComplianceRuleResult.md) | The Rule Results for a particular compliance run | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId orderId = new ResourceId();
List<ComplianceRuleResult> listRuleResult = new List<ComplianceRuleResult>();

ComplianceBreachedOrderInfo complianceBreachedOrderInfoInstance = new ComplianceBreachedOrderInfo(
    orderId: orderId,
    listRuleResult: listRuleResult);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
