# Lusid.Sdk.Model.CheckDefinitionDatasetSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of dataset schema that the Check Definition applies to | [optional] 
**EntityType** | **string** | The type of entity that the dataset schema applies to, e.g. Instrument, Transaction, etc. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "example type";
string entityType = "example entityType";

CheckDefinitionDatasetSchema checkDefinitionDatasetSchemaInstance = new CheckDefinitionDatasetSchema(
    type: type,
    entityType: entityType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
