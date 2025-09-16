# Lusid.Sdk.Model.CustomEntityDefinition
Representation of Custom Entity Definition on LUSID API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**EntityTypeName** | **string** | The name provided when the custom entity type was created. This has been prefixed with “~” and returned as “entityType”, which is the identifier for the custom entity type. | 
**DisplayName** | **string** | A display label for the custom entity type. | 
**Description** | **string** | A description for the custom entity type. | [optional] 
**EntityType** | **string** | The identifier for the custom entity type, derived from the “entityTypeName” provided on creation. | 
**FieldSchema** | [**List&lt;CustomEntityFieldDefinition&gt;**](CustomEntityFieldDefinition.md) | The description of the fields on the custom entity type. | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
string entityTypeName = "entityTypeName";
string displayName = "displayName";
string description = "example description";
string entityType = "entityType";
List<CustomEntityFieldDefinition> fieldSchema = new List<CustomEntityFieldDefinition>();
ModelVersion varVersion = new ModelVersion();
List<Link> links = new List<Link>();

CustomEntityDefinition customEntityDefinitionInstance = new CustomEntityDefinition(
    href: href,
    entityTypeName: entityTypeName,
    displayName: displayName,
    description: description,
    entityType: entityType,
    fieldSchema: fieldSchema,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
