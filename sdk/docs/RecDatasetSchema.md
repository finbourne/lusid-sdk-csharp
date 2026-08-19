# Lusid.Sdk.Model.RecDatasetSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The kind of dataset this side draws on. One of: PortfolioContents, LusidEntity, RelationalData. At most one side may be RelationalData. Available values: PortfolioContents, LusidEntity, RelationalData. | 
**EntityType** | **string** | The entity within the dataset. Required when type is PortfolioContents, in which case it is one of: Holding, Valuation, Transaction, OutputTransaction, SettlementActivity. Must be omitted when type is RelationalData. Available values: Holding, Valuation, Transaction, OutputTransaction, SettlementActivity. | [optional] 
**RelationalDatasetDefinitionId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";
string entityType = "example entityType";
ResourceId? relationalDatasetDefinitionId = new ResourceId();


RecDatasetSchema recDatasetSchemaInstance = new RecDatasetSchema(
    type: type,
    entityType: entityType,
    relationalDatasetDefinitionId: relationalDatasetDefinitionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
