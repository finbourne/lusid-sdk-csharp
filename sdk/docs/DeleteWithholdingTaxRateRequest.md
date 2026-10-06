# Lusid.Sdk.Model.DeleteWithholdingTaxRateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeriesIdentifiers** | **Dictionary&lt;string, Object&gt;** | The identifiers that uniquely define this DataSeries, if any, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | [optional] 
**EffectiveAt** | **string** | The effectiveAt or cut-label datetime of the DataPoint. | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, Object> seriesIdentifiers = new Dictionary<string, Object>();
string effectiveAt = "effectiveAt";

DeleteWithholdingTaxRateRequest deleteWithholdingTaxRateRequestInstance = new DeleteWithholdingTaxRateRequest(
    seriesIdentifiers: seriesIdentifiers,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
