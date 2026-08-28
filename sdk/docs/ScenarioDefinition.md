# Lusid.Sdk.Model.ScenarioDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** |  | 
**Code** | **string** |  | 
**DisplayName** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**ShortCode** | **string** | A short, memorable identifier for the scenario, for use in reporting. Optional on upsert:  when omitted, reads return a value inferred from the display name (falling back to the  code) rather than null; the inferred value is computed fresh on every read and is never  persisted. When supplied, the value is stored and returned verbatim. Independent of  scenarioType. | [optional] 
**ScenarioType** | **string** | Classifies the scenario. Required on upsert; supported string (enumeration) values are:  [Historical, Regulatory, Hypothetical]. Independent of shortCode. Available values: Historical, Regulatory, Hypothetical. | 
**Shifts** | [**List&lt;ScenarioShiftDefinition&gt;**](ScenarioShiftDefinition.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";
string displayName = "example displayName";
string description = "example description";
string shortCode = "example shortCode";
string scenarioType = "scenarioType";
List<ScenarioShiftDefinition> shifts = new List<ScenarioShiftDefinition>();

ScenarioDefinition scenarioDefinitionInstance = new ScenarioDefinition(
    scope: scope,
    code: code,
    displayName: displayName,
    description: description,
    shortCode: shortCode,
    scenarioType: scenarioType,
    shifts: shifts);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
