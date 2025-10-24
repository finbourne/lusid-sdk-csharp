# Lusid.Sdk.Model.ApplicableEntity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The type of entity (e.g., Instrument, Portfolio) that this DataSeries applies to. | 
**EntityScope** | **string** | The scope of the entity. | [optional] 
**IdentifierScope** | **string** | The scope of the identifier used to uniquely identify the entity. | [optional] 
**IdentifierType** | **string** | The type of identifier (e.g., Figi, Isin) used to uniquely identify the entity. | [optional] 
**IdentifierValue** | **string** | The value of the identifier used to uniquely identify the entity. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "entityType";
string entityScope = "example entityScope";
string identifierScope = "example identifierScope";
string identifierType = "example identifierType";
string identifierValue = "example identifierValue";

ApplicableEntity applicableEntityInstance = new ApplicableEntity(
    entityType: entityType,
    entityScope: entityScope,
    identifierScope: identifierScope,
    identifierType: identifierType,
    identifierValue: identifierValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
