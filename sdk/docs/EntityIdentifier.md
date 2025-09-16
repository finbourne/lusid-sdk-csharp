# Lusid.Sdk.Model.EntityIdentifier
Dto to expose mapped keys to new standardised format

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentifierScope** | **string** | The scope of the identifier | [optional] 
**IdentifierType** | **string** | The type of the identifier | 
**IdentifierValue** | **string** | The value of the identifier | 

```csharp
using Lusid.Sdk.Model;
using System;

string identifierScope = "example identifierScope";
string identifierType = "identifierType";
string identifierValue = "identifierValue";

EntityIdentifier entityIdentifierInstance = new EntityIdentifier(
    identifierScope: identifierScope,
    identifierType: identifierType,
    identifierValue: identifierValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
