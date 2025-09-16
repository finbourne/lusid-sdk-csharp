# Lusid.Sdk.Model.Alias

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AttributeName** | **string** | The property key, identifier type, or field to be replaced by an alias. | 
**AttributeAlias** | **string** | The alias to replace the property key, identifier type, or field on the bound entity. | 

```csharp
using Lusid.Sdk.Model;
using System;

string attributeName = "attributeName";
string attributeAlias = "attributeAlias";

Alias aliasInstance = new Alias(
    attributeName: attributeName,
    attributeAlias: attributeAlias);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
