# Lusid.Sdk.Model.InvestmentPortfolio
An Investment Portfolio of an Investment Account.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | A client-defined key used to identify the Investment Portfolio, unique within the Investment Account | [optional] 
**Scope** | **string** | The scope of the Investment Portfolio | [optional] 
**Identifiers** | **Dictionary&lt;string, string&gt;** | The code identifier of the Investment Portfolio | [optional] 
**EntityUniqueId** | **string** | The unique Portfolio entity identifier | [optional] 
**Portfolio** | [**Portfolio**](Portfolio.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "example key";
string scope = "example scope";
Dictionary<string, string> identifiers = new Dictionary<string, string>();
string entityUniqueId = "example entityUniqueId";
Portfolio? portfolio = new Portfolio();


InvestmentPortfolio investmentPortfolioInstance = new InvestmentPortfolio(
    key: key,
    scope: scope,
    identifiers: identifiers,
    entityUniqueId: entityUniqueId,
    portfolio: portfolio);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
