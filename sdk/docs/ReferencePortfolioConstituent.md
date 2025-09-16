# Lusid.Sdk.Model.ReferencePortfolioConstituent

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers | [optional] 
**InstrumentUid** | **string** | LUSID&#39;s internal unique instrument identifier, resolved from the instrument identifiers | 
**Currency** | **string** |  | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Properties associated with the constituent | [optional] 
**Weight** | **decimal** |  | 
**FloatingWeight** | **decimal?** |  | [optional] 
**InstrumentScope** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
string instrumentUid = "instrumentUid";
string currency = "currency";
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();decimal weight = "weight";

string instrumentScope = "example instrumentScope";

ReferencePortfolioConstituent referencePortfolioConstituentInstance = new ReferencePortfolioConstituent(
    instrumentIdentifiers: instrumentIdentifiers,
    instrumentUid: instrumentUid,
    currency: currency,
    properties: properties,
    weight: weight,
    floatingWeight: floatingWeight,
    instrumentScope: instrumentScope);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
