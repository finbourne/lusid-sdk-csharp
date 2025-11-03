# Lusid.Sdk.Model.RelationalDatasetFieldsToUpdate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeriesIdentifiers** | [**List&lt;UpdateSeriesIdentifierField&gt;**](UpdateSeriesIdentifierField.md) | The schema defining the structure and data types of the relational dataset. | [optional] 
**ValueAndMetadataFields** | [**List&lt;RelationalDatasetFieldDefinition&gt;**](RelationalDatasetFieldDefinition.md) | The schema defining the structure and data types of the relational dataset. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<UpdateSeriesIdentifierField> seriesIdentifiers = new List<UpdateSeriesIdentifierField>();
List<RelationalDatasetFieldDefinition> valueAndMetadataFields = new List<RelationalDatasetFieldDefinition>();

RelationalDatasetFieldsToUpdate relationalDatasetFieldsToUpdateInstance = new RelationalDatasetFieldsToUpdate(
    seriesIdentifiers: seriesIdentifiers,
    valueAndMetadataFields: valueAndMetadataFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
