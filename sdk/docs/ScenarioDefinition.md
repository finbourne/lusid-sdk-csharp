# Lusid.Sdk.Model.ScenarioDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** |  | 
**Code** | **string** |  | 
**DisplayName** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Shifts** | [**List&lt;ScenarioShiftDefinition&gt;**](ScenarioShiftDefinition.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string displayName = "example displayName";
string description = "example description";
List<ScenarioShiftDefinition> shifts = new List<ScenarioShiftDefinition>();

ScenarioDefinition scenarioDefinitionInstance = new ScenarioDefinition(
    scope: scope,
    code: code,
    displayName: displayName,
    description: description,
    shifts: shifts);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
