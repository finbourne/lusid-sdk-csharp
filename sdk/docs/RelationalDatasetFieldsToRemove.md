# Lusid.Sdk.Model.RelationalDatasetFieldsToRemove

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ValueAndMetadataFields** | **List&lt;string&gt;** | An array of FieldName(s) to be removed from the FieldSchema. Only Value or Metadata fields can be removed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> valueAndMetadataFields = new List<string>();

RelationalDatasetFieldsToRemove relationalDatasetFieldsToRemoveInstance = new RelationalDatasetFieldsToRemove(
    valueAndMetadataFields: valueAndMetadataFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
