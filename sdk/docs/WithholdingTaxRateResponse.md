# Lusid.Sdk.Model.WithholdingTaxRateResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RelationalDatasetDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**SeriesIdentifiers** | [**Dictionary&lt;string, RelationalDataPointFieldValueResponse&gt;**](RelationalDataPointFieldValueResponse.md) | The identifiers that uniquely define this DataSeries, if any, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | 
**EffectiveAt** | **DateTimeOffset** | The effectiveAt or cut-label datetime of the DataPoint. | 
**ValueFields** | [**Dictionary&lt;string, RelationalDataPointFieldValueResponse&gt;**](RelationalDataPointFieldValueResponse.md) | The values associated with the DataPoint, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | 
**MetaDataFields** | [**Dictionary&lt;string, RelationalDataPointFieldValueResponse&gt;**](RelationalDataPointFieldValueResponse.md) | The metadata associated with the DataPoint, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | 
**EffectiveAtEntered** | **string** | The effectiveAt datetime as entered when the DataPoint was created. | 
**DataPointVersion** | [**DataPointVersion**](DataPointVersion.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId relationalDatasetDefinitionId = new ResourceId();
Dictionary<string, RelationalDataPointFieldValueResponse> seriesIdentifiers = new Dictionary<string, RelationalDataPointFieldValueResponse>();
Dictionary<string, RelationalDataPointFieldValueResponse> valueFields = new Dictionary<string, RelationalDataPointFieldValueResponse>();
Dictionary<string, RelationalDataPointFieldValueResponse> metaDataFields = new Dictionary<string, RelationalDataPointFieldValueResponse>();
string effectiveAtEntered = "effectiveAtEntered";
DataPointVersion? dataPointVersion = new DataPointVersion();


WithholdingTaxRateResponse withholdingTaxRateResponseInstance = new WithholdingTaxRateResponse(
    relationalDatasetDefinitionId: relationalDatasetDefinitionId,
    seriesIdentifiers: seriesIdentifiers,
    effectiveAt: effectiveAt,
    valueFields: valueFields,
    metaDataFields: metaDataFields,
    effectiveAtEntered: effectiveAtEntered,
    dataPointVersion: dataPointVersion);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
