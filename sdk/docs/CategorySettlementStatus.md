# Lusid.Sdk.Model.CategorySettlementStatus

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | The Status of the settlement category - &#39;Settled&#39;, &#39;Part Settled&#39; or &#39;Unsettled&#39;. | 
**IsOverdue** | **bool** | Whether the category has any overdue movements | 
**Problems** | [**List&lt;SettlementProblem&gt;**](SettlementProblem.md) | Instruction level detail of rejected or invalid settlement instructions | 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "status";
bool isOverdue = //"True";
List<SettlementProblem> problems = new List<SettlementProblem>();

CategorySettlementStatus categorySettlementStatusInstance = new CategorySettlementStatus(
    status: status,
    isOverdue: isOverdue,
    problems: problems);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
