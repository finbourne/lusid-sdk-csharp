# Lusid.Sdk.Model.MetadataFieldsToRemove

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetadataFields** | **List&lt;string&gt;** | An array of FieldName(s) to be removed from the metadata field schema. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> metadataFields = new List<string>();

MetadataFieldsToRemove metadataFieldsToRemoveInstance = new MetadataFieldsToRemove(
    metadataFields: metadataFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
