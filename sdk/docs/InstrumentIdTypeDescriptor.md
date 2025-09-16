# Lusid.Sdk.Model.InstrumentIdTypeDescriptor
The description of an allowable instrument identifier.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentifierType** | **string** | The name of the identifier type. | 
**PropertyKey** | **string** | The property key that corresponds to the identifier type. | 
**IsUniqueIdentifierType** | **bool** | Whether or not the identifier type is enforced to be unique. | 

```csharp
using Lusid.Sdk.Model;
using System;

string identifierType = "identifierType";
string propertyKey = "propertyKey";
bool isUniqueIdentifierType = //"True";

InstrumentIdTypeDescriptor instrumentIdTypeDescriptorInstance = new InstrumentIdTypeDescriptor(
    identifierType: identifierType,
    propertyKey: propertyKey,
    isUniqueIdentifierType: isUniqueIdentifierType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
