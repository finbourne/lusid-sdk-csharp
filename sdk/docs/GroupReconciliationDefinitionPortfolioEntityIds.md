# Lusid.Sdk.Model.GroupReconciliationDefinitionPortfolioEntityIds

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | Portfolio Entity Id of the left side of a reconciliation | 
**Right** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | Portfolio Entity Id of the right side of a reconciliation | 

```csharp
using Lusid.Sdk.Model;
using System;

List<PortfolioEntityId> left = new List<PortfolioEntityId>();
List<PortfolioEntityId> right = new List<PortfolioEntityId>();

GroupReconciliationDefinitionPortfolioEntityIds groupReconciliationDefinitionPortfolioEntityIdsInstance = new GroupReconciliationDefinitionPortfolioEntityIds(
    left: left,
    right: right);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
