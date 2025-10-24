# Lusid.Sdk.Model.RelationalDataPointResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RelationalDatasetDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**DataSeries** | [**RelationalDataSeriesResponse**](RelationalDataSeriesResponse.md) |  | 
**EffectiveAt** | **DateTimeOffset** | The effectiveAt or cut-label datetime of the DataPoint. | 
**ValueFields** | [**Dictionary&lt;string, RelationalDataPointFieldValueResponse&gt;**](RelationalDataPointFieldValueResponse.md) | The values associated with the DataPoint, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | 
**MetaDataFields** | [**Dictionary&lt;string, RelationalDataPointFieldValueResponse&gt;**](RelationalDataPointFieldValueResponse.md) | The metadata associated with the DataPoint, structured according to the FieldSchema of the parent RelationalDatasetDefinition. | 
**EffectiveAtEntered** | **string** | The effectiveAt datetime as entered when the DataPoint was created. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId relationalDatasetDefinitionId = new ResourceId();
RelationalDataSeriesResponse dataSeries = new RelationalDataSeriesResponse();
Dictionary<string, RelationalDataPointFieldValueResponse> valueFields = new Dictionary<string, RelationalDataPointFieldValueResponse>();
Dictionary<string, RelationalDataPointFieldValueResponse> metaDataFields = new Dictionary<string, RelationalDataPointFieldValueResponse>();
string effectiveAtEntered = "effectiveAtEntered";

RelationalDataPointResponse relationalDataPointResponseInstance = new RelationalDataPointResponse(
    relationalDatasetDefinitionId: relationalDatasetDefinitionId,
    dataSeries: dataSeries,
    effectiveAt: effectiveAt,
    valueFields: valueFields,
    metaDataFields: metaDataFields,
    effectiveAtEntered: effectiveAtEntered);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
