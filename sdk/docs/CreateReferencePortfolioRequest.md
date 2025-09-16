# Lusid.Sdk.Model.CreateReferencePortfolioRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The name of the reference portfolio. | 
**Description** | **string** | A long form text description of the portfolio. | [optional] 
**Code** | **string** | Unique identifier for the portfolio. | 
**Created** | **DateTimeOffset?** | The original creation date, defaults to today if not specified when creating a portfolio. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Portfolio properties to add to the portfolio. | [optional] 
**InstrumentScopes** | **List&lt;string&gt;** | Instrument Scopes. | [optional] 
**BaseCurrency** | **string** | The base currency of the transaction portfolio in ISO 4217 currency code format. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
string code = "code";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<string> instrumentScopes = new List<string>();
string baseCurrency = "example baseCurrency";

CreateReferencePortfolioRequest createReferencePortfolioRequestInstance = new CreateReferencePortfolioRequest(
    displayName: displayName,
    description: description,
    code: code,
    created: created,
    properties: properties,
    instrumentScopes: instrumentScopes,
    baseCurrency: baseCurrency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
