# Lusid.Sdk.Model.UpsertEntityResolverRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The entity type that a specific resolution configuration is applicable to (e.g. Instrument). | 
**Description** | **string** | Describes what this specific identifier order is used for. | [optional] 
**IdentifierMatchingOrder** | [**List&lt;IdentifierForResolution&gt;**](IdentifierForResolution.md) | Ordered collection of related identifier keys that are used to define which identifier takes priority in resolving an entity. | 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "entityType";
string description = "example description";
List<IdentifierForResolution> identifierMatchingOrder = new List<IdentifierForResolution>();

UpsertEntityResolverRequest upsertEntityResolverRequestInstance = new UpsertEntityResolverRequest(
    entityType: entityType,
    description: description,
    identifierMatchingOrder: identifierMatchingOrder);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
