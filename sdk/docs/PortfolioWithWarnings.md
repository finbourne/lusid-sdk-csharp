# Lusid.Sdk.Model.PortfolioWithWarnings
A portfolio together with warnings about its configuration.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Portfolio** | [**Portfolio**](Portfolio.md) |  | [optional] 
**Warnings** | [**List&lt;Warning&gt;**](Warning.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Portfolio? portfolio = new Portfolio();

List<Warning> warnings = new List<Warning>();
List<Link> links = new List<Link>();

PortfolioWithWarnings portfolioWithWarningsInstance = new PortfolioWithWarnings(
    portfolio: portfolio,
    warnings: warnings,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
