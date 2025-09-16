# Lusid.Sdk.Model.ReferencePortfolioConstituentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) |  | [optional] 
**Weight** | **decimal** |  | 
**Currency** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();decimal weight = "weight";

string currency = "example currency";

ReferencePortfolioConstituentRequest referencePortfolioConstituentRequestInstance = new ReferencePortfolioConstituentRequest(
    instrumentIdentifiers: instrumentIdentifiers,
    properties: properties,
    weight: weight,
    currency: currency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
