# Lusid.Sdk.Model.DerivationFormulaExplainRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The type of the entity for which the derived property or partial formula is to be resolved against. | 
**Scope** | **string** | The scope that entity exists in. If no scope is provided, the default scope for the entity type will be used. | [optional] 
**Identifier** | **Dictionary&lt;string, string&gt;** | An identifier key/value pair that uniquely identifies the entity to explain the derived property for. This can be either an instrument identifier, an identifier property, or a scope/code identifier which take the format {entityType}/default/code : {identifier}. If no identifiers are provided, the logical evaluation tree without resolved values is returned. | [optional] 
**PropertyKey** | **string** | The key of the derived property to explain. This takes the format {domain}/{scope}/{code}. | [optional] 
**PartialFormula** | **string** | A partial derivation formula to explain. Can be provided in lieu of a property key. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "entityType";
string scope = "example scope";
Dictionary<string, string> identifier = new Dictionary<string, string>();
string propertyKey = "example propertyKey";
string partialFormula = "example partialFormula";

DerivationFormulaExplainRequest derivationFormulaExplainRequestInstance = new DerivationFormulaExplainRequest(
    entityType: entityType,
    scope: scope,
    identifier: identifier,
    propertyKey: propertyKey,
    partialFormula: partialFormula);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
