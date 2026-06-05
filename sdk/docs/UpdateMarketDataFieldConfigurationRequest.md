# Lusid.Sdk.Model.UpdateMarketDataFieldConfigurationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Add** | [**MetadataFieldsToAdd**](MetadataFieldsToAdd.md) |  | [optional] 
**Update** | [**MetadataFieldsToUpdate**](MetadataFieldsToUpdate.md) |  | [optional] 
**Remove** | [**MetadataFieldsToRemove**](MetadataFieldsToRemove.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

MetadataFieldsToAdd? add = new MetadataFieldsToAdd();

MetadataFieldsToUpdate? update = new MetadataFieldsToUpdate();

MetadataFieldsToRemove? remove = new MetadataFieldsToRemove();


UpdateMarketDataFieldConfigurationRequest updateMarketDataFieldConfigurationRequestInstance = new UpdateMarketDataFieldConfigurationRequest(
    add: add,
    update: update,
    remove: remove);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
