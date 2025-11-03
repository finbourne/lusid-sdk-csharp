# Lusid.Sdk.Model.UpdateRelationalDatasetDetails

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | A user-friendly display name for the relational dataset definition. | 
**Description** | **string** | A detailed description of the relational dataset definition and its purpose. | [optional] 
**ApplicableEntityTypes** | [**ApplicableEntityTypes**](ApplicableEntityTypes.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "displayName";
string description = "example description";
ApplicableEntityTypes? applicableEntityTypes = new ApplicableEntityTypes();


UpdateRelationalDatasetDetails updateRelationalDatasetDetailsInstance = new UpdateRelationalDatasetDetails(
    displayName: displayName,
    description: description,
    applicableEntityTypes: applicableEntityTypes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
