# Lusid.Sdk.Model.UpsertRelationalDataPointDataSeries

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeriesScope** | **string** | The scope of the DataSeries. | 
**ApplicableEntity** | [**ApplicableEntity**](ApplicableEntity.md) |  | 
**SeriesIdentifiers** | **Dictionary&lt;string, Object&gt;** | The identifiers that uniquely define this DataSeries, if any, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string seriesScope = "seriesScope";
ApplicableEntity applicableEntity = new ApplicableEntity();
Dictionary<string, Object> seriesIdentifiers = new Dictionary<string, Object>();

UpsertRelationalDataPointDataSeries upsertRelationalDataPointDataSeriesInstance = new UpsertRelationalDataPointDataSeries(
    seriesScope: seriesScope,
    applicableEntity: applicableEntity,
    seriesIdentifiers: seriesIdentifiers);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
