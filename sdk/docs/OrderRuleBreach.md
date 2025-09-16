# Lusid.Sdk.Model.OrderRuleBreach

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BreachTaskId** | **string** | Uniquely identifies this historical order breach workflow task. | 
**ComplianceState** | **string** | The compliance state of this order breach. Possible values are &#39;Pending&#39;, &#39;Failed&#39;, &#39;Manually approved&#39;, &#39;Passed&#39; and &#39;Warning&#39;. | 

```csharp
using Lusid.Sdk.Model;
using System;

string breachTaskId = "breachTaskId";
string complianceState = "complianceState";

OrderRuleBreach orderRuleBreachInstance = new OrderRuleBreach(
    breachTaskId: breachTaskId,
    complianceState: complianceState);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
