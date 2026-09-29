# Lusid.Sdk.Model.DecoratedComplianceRunSummaryRequest
Specification for retrieving a decorated compliance run summary, optionally restricted to a  set of portfolios and/or portfolio groups.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | [**ResourceId**](ResourceId.md) |  | 
**PortfolioEntityIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) |  | [optional] 
**PropertyKeys** | **List&lt;string&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId runId = new ResourceId();
List<PortfolioEntityId> portfolioEntityIds = new List<PortfolioEntityId>();
List<string> propertyKeys = new List<string>();

DecoratedComplianceRunSummaryRequest decoratedComplianceRunSummaryRequestInstance = new DecoratedComplianceRunSummaryRequest(
    runId: runId,
    portfolioEntityIds: portfolioEntityIds,
    propertyKeys: propertyKeys);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
