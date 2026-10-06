# Lusid.Sdk.Model.UpsertWithholdingTaxRateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeriesIdentifiers** | **Dictionary&lt;string, Object&gt;** | The identifiers that uniquely define this DataSeries, if any, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | [optional] 
**EffectiveAt** | **string** | The effectiveAt or cut-label datetime of the DataPoint. | 
**ValueFields** | **Dictionary&lt;string, Object&gt;** | The values associated with the DataPoint, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | 
**MetaDataFields** | **Dictionary&lt;string, Object&gt;** | The metadata associated with the DataPoint, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, Object> seriesIdentifiers = new Dictionary<string, Object>();
string effectiveAt = "effectiveAt";
Dictionary<string, Object> valueFields = new Dictionary<string, Object>();
Dictionary<string, Object> metaDataFields = new Dictionary<string, Object>();

UpsertWithholdingTaxRateRequest upsertWithholdingTaxRateRequestInstance = new UpsertWithholdingTaxRateRequest(
    seriesIdentifiers: seriesIdentifiers,
    effectiveAt: effectiveAt,
    valueFields: valueFields,
    metaDataFields: metaDataFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
