# Lusid.Sdk.Model.IdSelectorDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifier** | **Dictionary&lt;string, string&gt;** |  | 
**Actions** | [**List&lt;ActionId&gt;**](ActionId.md) |  | 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, string> identifier = new Dictionary<string, string>();
List<ActionId> actions = new List<ActionId>();
string name = "example name";
string description = "example description";

IdSelectorDefinition idSelectorDefinitionInstance = new IdSelectorDefinition(
    identifier: identifier,
    actions: actions,
    name: name,
    description: description);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
