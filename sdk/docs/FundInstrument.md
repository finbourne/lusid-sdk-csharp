# Lusid.Sdk.Model.FundInstrument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | Unique instrument identifiers. Must only point to the same instrument | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();

FundInstrument fundInstrumentInstance = new FundInstrument(
    instrumentIdentifiers: instrumentIdentifiers);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
