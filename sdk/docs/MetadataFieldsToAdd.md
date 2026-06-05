# Lusid.Sdk.Model.MetadataFieldsToAdd

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MetadataFields** | [**List&lt;MetadataFieldDefinition&gt;**](MetadataFieldDefinition.md) | The metadata field definitions for this configuration. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<MetadataFieldDefinition> metadataFields = new List<MetadataFieldDefinition>();

MetadataFieldsToAdd metadataFieldsToAddInstance = new MetadataFieldsToAdd(
    metadataFields: metadataFields);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
