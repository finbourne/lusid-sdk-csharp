# Lusid.Sdk.Model.InvestmentPortfolioIdentifier

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | A client-defined key used to identify the Investment Portfolio, unique within the Investment Account | 
**Scope** | **string** | The scope of the Investment Portfolio. | 
**Identifiers** | **Dictionary&lt;string, string&gt;** | The code identifier of the Investment Portfolio. | 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
string scope = "scope";
Dictionary<string, string> identifiers = new Dictionary<string, string>();

InvestmentPortfolioIdentifier investmentPortfolioIdentifierInstance = new InvestmentPortfolioIdentifier(
    key: key,
    scope: scope,
    identifiers: identifiers);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
