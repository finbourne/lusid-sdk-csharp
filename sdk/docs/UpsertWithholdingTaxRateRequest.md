# Lusid.Sdk.Model.UpsertWithholdingTaxRateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeriesIdentifiers** | **Dictionary&lt;string, Object&gt;** | The series identifiers that, with effectiveAt, identify the rate row: taxCountry, profileType and the dataset&#39;s own matching dimensions, structured according to its field schema. ruleSource is not accepted here: pass it as the ruleSource query parameter, which applies it to every row in the batch, and omit it for rows that apply at every source. | [optional] 
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
