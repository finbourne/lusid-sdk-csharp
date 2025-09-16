# Lusid.Sdk.Model.PortfolioResultDataKeyRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultKeyRuleType** | **string** | The available values are: Invalid, ResultDataKeyRule, PortfolioResultDataKeyRule | 
**Supplier** | **string** | the result resource supplier (where the data comes from) | 
**DataScope** | **string** | which is the scope in which the data should be found | 
**DocumentCode** | **string** | document code that defines which document is desired | 
**QuoteInterval** | **string** | Shorthand for the time interval used to select result data. This must be a dot-separated string              specifying a start and end date, for example &#39;5D.0D&#39; to look back 5 days from today (0 days ago). | [optional] 
**AsAt** | **DateTimeOffset?** | The AsAt predicate specification. | [optional] 
**PortfolioCode** | **string** |  | [optional] 
**PortfolioScope** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string supplier = "supplier";
string dataScope = "dataScope";
string documentCode = "documentCode";
string quoteInterval = "example quoteInterval";
string portfolioCode = "example portfolioCode";
string portfolioScope = "example portfolioScope";

PortfolioResultDataKeyRule portfolioResultDataKeyRuleInstance = new PortfolioResultDataKeyRule(
    supplier: supplier,
    dataScope: dataScope,
    documentCode: documentCode,
    quoteInterval: quoteInterval,
    asAt: asAt,
    portfolioCode: portfolioCode,
    portfolioScope: portfolioScope);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
