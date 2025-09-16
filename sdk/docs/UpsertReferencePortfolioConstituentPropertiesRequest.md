# Lusid.Sdk.Model.UpsertReferencePortfolioConstituentPropertiesRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifiers** | **Dictionary&lt;string, string&gt;** | A set of instrument identifiers that can resolve the constituent to a unique instrument. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | The updated collection of properties of the constituent. | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> identifiers = new Dictionary<string, string>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();

UpsertReferencePortfolioConstituentPropertiesRequest upsertReferencePortfolioConstituentPropertiesRequestInstance = new UpsertReferencePortfolioConstituentPropertiesRequest(
    identifiers: identifiers,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
