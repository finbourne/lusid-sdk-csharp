# Lusid.Sdk.Model.CdsModelOptions
Model options for credit default instrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelOptionsType** | **string** | The available values are: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, CdsModelOptions | 
**UseFactorsForCurrentNotional** | **bool** | Determines if calculations that use current notional apply use a constituent weight factor from a quote representing a default. | 

```csharp
using Lusid.Sdk.Model;
using System;

bool useFactorsForCurrentNotional = //"True";

CdsModelOptions cdsModelOptionsInstance = new CdsModelOptions(
    useFactorsForCurrentNotional: useFactorsForCurrentNotional);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
