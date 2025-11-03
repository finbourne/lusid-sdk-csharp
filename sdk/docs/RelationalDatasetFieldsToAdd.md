# Lusid.Sdk.Model.RelationalDatasetFieldsToAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeriesIdentifiers** | [**List&lt;CreateSeriesIdentifierField&gt;**](CreateSeriesIdentifierField.md) | The schema defining the structure and data types of the relational dataset. | [optional] 
**ValueAndMetadataFields** | [**List&lt;RelationalDatasetFieldDefinition&gt;**](RelationalDatasetFieldDefinition.md) | The schema defining the structure and data types of the relational dataset. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<CreateSeriesIdentifierField> seriesIdentifiers = new List<CreateSeriesIdentifierField>();
List<RelationalDatasetFieldDefinition> valueAndMetadataFields = new List<RelationalDatasetFieldDefinition>();

RelationalDatasetFieldsToAdd relationalDatasetFieldsToAddInstance = new RelationalDatasetFieldsToAdd(
    seriesIdentifiers: seriesIdentifiers,
    valueAndMetadataFields: valueAndMetadataFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
