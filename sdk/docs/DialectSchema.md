# Lusid.Sdk.Model.DialectSchema
A schema that a given document must obey. A representation of the validation of a particular Dialect,  in a given language.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of schema this represents | 
**Body** | **string** | The body of the schema | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";
string body = "example body";

DialectSchema dialectSchemaInstance = new DialectSchema(
    type: type,
    body: body);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
