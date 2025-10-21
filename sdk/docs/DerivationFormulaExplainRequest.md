# Lusid.Sdk.Model.DerivationFormulaExplainRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The type of the entity for which the derived property or partial formula is to be resolved against. | 
**Scope** | **string** | (Optional) The scope that entity exists in. If no scope is provided, the default scope for the entity type will be used. | [optional] 
**Code** | **string** | (Optional) The code of the entity, to be provided for entities that support scope/code retrieval. If no code or identifier is provided, the logical evaluation tree without resolved values is returned. | [optional] 
**Identifier** | **Dictionary&lt;string, string&gt;** | (Optional). An identifier key/value pair that uniquely identifies the entity to explain the derived property for. This can be either an instrument identifier, or an identifier property. If no code or identifier is provided, the logical evaluation tree without resolved values is returned. | [optional] 
**PropertyKey** | **string** | (Optional) The key of the derived property to get an explanation for. This takes the format {domain}/{scope}/{code}. One of either property key or partial formula must be provided. | [optional] 
**PartialFormula** | **string** | (Optional) A partial derivation formula to get an explanation for. Can be provided in lieu of a property key. One of either property key or partial formula must be provided. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "entityType";
string scope = "example scope";
string code = "example code";
Dictionary<string, string> identifier = new Dictionary<string, string>();
string propertyKey = "example propertyKey";
string partialFormula = "example partialFormula";

DerivationFormulaExplainRequest derivationFormulaExplainRequestInstance = new DerivationFormulaExplainRequest(
    entityType: entityType,
    scope: scope,
    code: code,
    identifier: identifier,
    propertyKey: propertyKey,
    partialFormula: partialFormula);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
