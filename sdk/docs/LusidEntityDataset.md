# Lusid.Sdk.Model.LusidEntityDataset
Contains the run-time parameters that are appropriate for check definitions  with datasetSchema.type = \"LusidEntity\"

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset?** | The asAt date to fetch the data. Nullable. Defaults to latest. | [optional] 
**EffectiveAt** | **DateTimeOffset?** | The effectiveAt date to fetch the data. Nullable. Defaults to latest. | [optional] 
**Scope** | **string** | The scope of the entities to check. Required. | 
**AsAtModifiedSince** | **DateTimeOffset?** | Nullable. Filters the dataset for version.asAtModified greater than or equal to this value. | [optional] 
**SelectorAttribute** | **string** | An attribute (field name, propertyKey or identifierKey) to use to sub-divide the dataset. | 
**SelectorValue** | **string** | The value of the above attribute used to sub-divide the dataset. | 
**ReturnIdentifierKey** | **string** | The preferred identifier to return for entities with multiple external identifiers. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string selectorAttribute = "selectorAttribute";
string selectorValue = "selectorValue";
string returnIdentifierKey = "example returnIdentifierKey";

LusidEntityDataset lusidEntityDatasetInstance = new LusidEntityDataset(
    asAt: asAt,
    effectiveAt: effectiveAt,
    scope: scope,
    asAtModifiedSince: asAtModifiedSince,
    selectorAttribute: selectorAttribute,
    selectorValue: selectorValue,
    returnIdentifierKey: returnIdentifierKey);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
