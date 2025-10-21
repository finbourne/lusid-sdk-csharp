# Lusid.Sdk.Model.LusidEntityResult
Represents LUSID entity details for a data quality check result

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset** | The as-at timestamp for the entity | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective-at timestamp for the entity | [optional] 
**EntityType** | **string** | The type of the LUSID entity | [optional] 
**Scope** | **string** | The scope of the entity | [optional] 
**IdentifierKey** | **string** | The identifier key for the entity | [optional] 
**IdentifierValue** | **string** | The identifier value for the entity | [optional] 
**EntityUniqueId** | **string** | The unique identifier for the entity | [optional] 
**DisplayName** | **string** | The display name of the entity | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "example entityType";
string scope = "example scope";
string identifierKey = "example identifierKey";
string identifierValue = "example identifierValue";
string entityUniqueId = "example entityUniqueId";
string displayName = "example displayName";

LusidEntityResult lusidEntityResultInstance = new LusidEntityResult(
    asAt: asAt,
    effectiveAt: effectiveAt,
    entityType: entityType,
    scope: scope,
    identifierKey: identifierKey,
    identifierValue: identifierValue,
    entityUniqueId: entityUniqueId,
    displayName: displayName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
