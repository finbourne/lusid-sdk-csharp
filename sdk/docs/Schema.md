# Lusid.Sdk.Model.Schema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Entity** | **string** |  | [optional] 
**Href** | **string** |  | [optional] 
**Values** | [**Dictionary&lt;string, FieldSchema&gt;**](FieldSchema.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entity = "example entity";
string href = "example href";
Dictionary<string, FieldSchema> values = new Dictionary<string, FieldSchema>();
List<Link> links = new List<Link>();

Schema schemaInstance = new Schema(
    entity: entity,
    href: href,
    values: values,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
