# Lusid.Sdk.Model.ScenarioTemplateDefinition
One pre-built scenario template: the name to pass to CreateScenarioFromTemplate, what the  template does, and the parameters it accepts. A parameter not listed here is rejected by  the create call, not ignored.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The template name, as accepted by CreateScenarioFromTemplate. | [optional] 
**Description** | **string** | What the template&#39;s scenario does. | [optional] 
**Parameters** | [**List&lt;ScenarioTemplateParameter&gt;**](ScenarioTemplateParameter.md) | The parameters the template accepts, in the order they are documented. Parameter names are  case-sensitive; supplying one not in this list fails the create call. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "example name";
string description = "example description";
List<ScenarioTemplateParameter> parameters = new List<ScenarioTemplateParameter>();

ScenarioTemplateDefinition scenarioTemplateDefinitionInstance = new ScenarioTemplateDefinition(
    name: name,
    description: description,
    parameters: parameters);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
