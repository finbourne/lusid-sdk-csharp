# Lusid.Sdk.Model.RelationalDataSeriesResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeriesScope** | **string** | The scope of the DataSeries. | 
**ApplicableEntity** | [**ApplicableEntity**](ApplicableEntity.md) |  | 
**SeriesIdentifiers** | [**Dictionary&lt;string, RelationalDataPointFieldValueResponse&gt;**](RelationalDataPointFieldValueResponse.md) | The identifiers that uniquely define this DataSeries, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | 

```csharp
using Lusid.Sdk.Model;
using System;

string seriesScope = "seriesScope";
ApplicableEntity applicableEntity = new ApplicableEntity();
Dictionary<string, RelationalDataPointFieldValueResponse> seriesIdentifiers = new Dictionary<string, RelationalDataPointFieldValueResponse>();

RelationalDataSeriesResponse relationalDataSeriesResponseInstance = new RelationalDataSeriesResponse(
    seriesScope: seriesScope,
    applicableEntity: applicableEntity,
    seriesIdentifiers: seriesIdentifiers);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
