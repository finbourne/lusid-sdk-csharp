# Lusid.Sdk.Model.PortfolioEntityId
Specification of a portfolio or portfolio group id, its scope and which it is.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope within which the portfolio or portfolio group lives. | 
**Code** | **string** | Portfolio name or code. | 
**PortfolioEntityType** | **string** | String identifier for portfolio e.g. \&quot;SinglePortfolio\&quot; and \&quot;GroupPortfolio\&quot;. If not specified, it is assumed to be a single portfolio. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string portfolioEntityType = "example portfolioEntityType";

PortfolioEntityId portfolioEntityIdInstance = new PortfolioEntityId(
    scope: scope,
    code: code,
    portfolioEntityType: portfolioEntityType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
