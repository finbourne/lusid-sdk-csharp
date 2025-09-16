# Lusid.Sdk.Model.Mapping
Defines the rule set to be used to determine if entries should be considered as a match.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope for this mapping. | 
**Code** | **string** | The code for this mapping. | 
**Name** | **string** | The mapping name | 
**ReconciliationType** | **string** | What type of reconciliation this mapping is for | 
**Rules** | [**List&lt;MappingRule&gt;**](MappingRule.md) | The rules in this mapping, keyed by the left field/property name | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string name = "name";
string reconciliationType = "reconciliationType";
List<MappingRule> rules = new List<MappingRule>();

Mapping mappingInstance = new Mapping(
    scope: scope,
    code: code,
    name: name,
    reconciliationType: reconciliationType,
    rules: rules);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
