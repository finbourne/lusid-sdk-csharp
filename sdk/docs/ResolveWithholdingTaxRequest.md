# Lusid.Sdk.Model.ResolveWithholdingTaxRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Mode** | **string** | Where the dimension values come from. Raw: from Dimensions. InstrumentResolved: from the instrument, through the configuration&#39;s value sources, as in booking. Available values: Raw, InstrumentResolved. | 
**TaxCountry** | **string** | The tax country of the holder. It is matched like any other dimension. | 
**ProfileType** | **string** | The profile type of the holder. It is matched like any other dimension. | 
**Dimensions** | **Dictionary&lt;string, string&gt;** | The value of each matching dimension, keyed by its field name in the rate datasets. A dimension left out is null, as in booking. taxCountry, profileType and ruleSource are not allowed here, and a name that neither dataset matches on is refused. With InstrumentResolved, a value here overrides the derived one, or gives one that the lookup cannot derive (see unresolvedDimensions in the response). | [optional] 
**WhtConfig** | [**ResourceId**](ResourceId.md) |  | [optional] 
**AnomalyDataset** | [**ResourceId**](ResourceId.md) |  | [optional] 
**MainDataset** | [**ResourceId**](ResourceId.md) |  | [optional] 
**SourcePriority** | **List&lt;string&gt;** | Optional. The source priority, most preferred first: it replaces the configuration&#39;s, or is used on its own when there is no configuration. An empty list applies no source filter. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The identifiers of the instrument, resolved as for a transaction. Required with InstrumentResolved, not allowed with Raw. | [optional] 
**InstrumentScope** | **string** | Optional. The scope to resolve the instrument in, before the default scope. Only with InstrumentResolved. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string mode = "mode";
string taxCountry = "taxCountry";
string profileType = "profileType";
Dictionary<string, string> dimensions = new Dictionary<string, string>();
ResourceId? whtConfig = new ResourceId();

ResourceId? anomalyDataset = new ResourceId();

ResourceId? mainDataset = new ResourceId();

List<string> sourcePriority = new List<string>();
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
string instrumentScope = "example instrumentScope";

ResolveWithholdingTaxRequest resolveWithholdingTaxRequestInstance = new ResolveWithholdingTaxRequest(
    mode: mode,
    taxCountry: taxCountry,
    profileType: profileType,
    dimensions: dimensions,
    whtConfig: whtConfig,
    anomalyDataset: anomalyDataset,
    mainDataset: mainDataset,
    sourcePriority: sourcePriority,
    instrumentIdentifiers: instrumentIdentifiers,
    instrumentScope: instrumentScope);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
