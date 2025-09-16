# Lusid.Sdk.Model.CreateUnitDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** |  | 
**DisplayName** | **string** |  | 
**Description** | **string** |  | 
**Details** | **Dictionary&lt;string, string&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string displayName = "displayName";
string description = "description";
Dictionary<string, string> details = new Dictionary<string, string>();

CreateUnitDefinition createUnitDefinitionInstance = new CreateUnitDefinition(
    code: code,
    displayName: displayName,
    description: description,
    details: details);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
