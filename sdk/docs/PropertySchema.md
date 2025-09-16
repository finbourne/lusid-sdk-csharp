# Lusid.Sdk.Model.PropertySchema

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** |  | [optional] 
**Values** | [**Dictionary&lt;string, FieldSchema&gt;**](FieldSchema.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
Dictionary<string, FieldSchema> values = new Dictionary<string, FieldSchema>();
List<Link> links = new List<Link>();

PropertySchema propertySchemaInstance = new PropertySchema(
    href: href,
    values: values,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
