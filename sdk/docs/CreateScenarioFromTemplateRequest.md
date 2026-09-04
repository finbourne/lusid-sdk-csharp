# Lusid.Sdk.Model.CreateScenarioFromTemplateRequest
Request to create a scenario from a pre-built parameterised template. The template determines the  shape of the scenario's shifts; the parameters supply the targets (e.g. currency, instrument) and  optionally override the template's default shift size.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Template** | **string** | The template to build the scenario from. Use ListScenarioTemplates to discover the available  templates and the parameters each accepts. | 
**Code** | **string** | The code of the scenario to create. | 
**DisplayName** | **string** | The display name of the created scenario. Defaults to a name derived from the template. | [optional] 
**Description** | **string** | The description of the created scenario. Defaults to a description derived from the template. | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** | Template parameters. Which parameters each template requires and accepts - with defaults and  units for the numeric ones - is listed by ListScenarioTemplates. A parameter the template does  not read is rejected rather than ignored, and parameter names are case-sensitive. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string template = "template";
string code = "code";
string displayName = "example displayName";
string description = "example description";
Dictionary<string, string> parameters = new Dictionary<string, string>();

CreateScenarioFromTemplateRequest createScenarioFromTemplateRequestInstance = new CreateScenarioFromTemplateRequest(
    template: template,
    code: code,
    displayName: displayName,
    description: description,
    parameters: parameters);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
