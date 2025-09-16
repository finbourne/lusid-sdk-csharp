# Lusid.Sdk.Model.Link

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Relation** | **string** |  | 
**Href** | **string** |  | 
**Description** | **string** |  | [optional] 
**Method** | **string** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string relation = "relation";
string href = "href";
string description = "example description";
string method = "method";

Link linkInstance = new Link(
    relation: relation,
    href: href,
    description: description,
    method: method);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
