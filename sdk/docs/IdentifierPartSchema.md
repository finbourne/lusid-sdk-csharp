# Lusid.Sdk.Model.IdentifierPartSchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **int** |  | 
**Name** | **string** |  | 
**DisplayName** | **string** |  | 
**Description** | **string** |  | 
**Required** | **bool** |  | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "name";
string displayName = "displayName";
string description = "description";
bool required = //"True";
List<Link> links = new List<Link>();

IdentifierPartSchema identifierPartSchemaInstance = new IdentifierPartSchema(
    index: index,
    name: name,
    displayName: displayName,
    description: description,
    required: required,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
