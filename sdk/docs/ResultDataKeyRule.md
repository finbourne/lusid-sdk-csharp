# Lusid.Sdk.Model.ResultDataKeyRule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultKeyRuleType** | **string** | The available values are: Invalid, ResultDataKeyRule, PortfolioResultDataKeyRule | 
**Supplier** | **string** | the result resource supplier (where the data comes from) | 
**DataScope** | **string** | which is the scope in which the data should be found | 
**DocumentCode** | **string** | document code that defines which document is desired | 
**QuoteInterval** | **string** | Shorthand for the time interval used to select result data. This must be a dot-separated string              specifying a start and end date, for example &#39;5D.0D&#39; to look back 5 days from today (0 days ago). | [optional] 
**AsAt** | **DateTimeOffset?** | The AsAt predicate specification. | [optional] 
**ResourceKey** | **string** | The result data key that identifies the address pattern that this is a rule for | 
**DocumentResultType** | **string** |  | 
**UseDocumentToInferHoldings** | **bool** | Indicates whether the relevant document should be used to infer the set of holdings in the valuation. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string supplier = "supplier";
string dataScope = "dataScope";
string documentCode = "documentCode";
string quoteInterval = "example quoteInterval";
string resourceKey = "resourceKey";
string documentResultType = "documentResultType";
bool useDocumentToInferHoldings = //"True";

ResultDataKeyRule resultDataKeyRuleInstance = new ResultDataKeyRule(
    supplier: supplier,
    dataScope: dataScope,
    documentCode: documentCode,
    quoteInterval: quoteInterval,
    asAt: asAt,
    resourceKey: resourceKey,
    documentResultType: documentResultType,
    useDocumentToInferHoldings: useDocumentToInferHoldings);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
