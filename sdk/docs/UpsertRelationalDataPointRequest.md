# Lusid.Sdk.Model.UpsertRelationalDataPointRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DataPointDataSeries** | [**UpsertRelationalDataPointDataSeries**](UpsertRelationalDataPointDataSeries.md) |  | 
**EffectiveAt** | **string** | The effectiveAt or cut-label datetime of the DataPoint. | 
**ValueFields** | **Dictionary&lt;string, Object&gt;** | The values associated with the DataPoint, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | 
**MetaDataFields** | **Dictionary&lt;string, Object&gt;** | The metadata associated with the DataPoint, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

UpsertRelationalDataPointDataSeries dataPointDataSeries = new UpsertRelationalDataPointDataSeries();
string effectiveAt = "effectiveAt";
Dictionary<string, Object> valueFields = new Dictionary<string, Object>();
Dictionary<string, Object> metaDataFields = new Dictionary<string, Object>();

UpsertRelationalDataPointRequest upsertRelationalDataPointRequestInstance = new UpsertRelationalDataPointRequest(
    dataPointDataSeries: dataPointDataSeries,
    effectiveAt: effectiveAt,
    valueFields: valueFields,
    metaDataFields: metaDataFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
