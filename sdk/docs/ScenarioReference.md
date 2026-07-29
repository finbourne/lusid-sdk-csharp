# Lusid.Sdk.Model.ScenarioReference
A reference to a stored Scenario, identified by scope and code, optionally pinned to an AsAt version.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope of the scenario to apply. | 
**Code** | **string** | The code of the scenario to apply. | 
**AsAt** | **DateTimeOffset?** | The AsAt of the scenario version to apply. If not supplied, the latest version is used. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string code = "code";

ScenarioReference scenarioReferenceInstance = new ScenarioReference(
    scope: scope,
    code: code,
    asAt: asAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
