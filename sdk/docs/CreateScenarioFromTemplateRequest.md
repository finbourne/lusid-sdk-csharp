# Lusid.Sdk.Model.CreateScenarioFromTemplateRequest
Request to create a scenario from a pre-built parameterised template. The template determines the  shape of the scenario's shifts; the parameters supply the targets (e.g. currency, instrument) and  optionally override the template's default shift size.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Template** | **string** | The template to build the scenario from. Available templates: RatesUp, RatesDown, CurveSteepener,  CurveFlattener, VolSpike, EquityCrash, FxShock, RiskOff. | 
**Code** | **string** | The code of the scenario to create. | 
**DisplayName** | **string** | The display name of the created scenario. Defaults to a name derived from the template. | [optional] 
**Description** | **string** | The description of the created scenario. Defaults to a description derived from the template. | [optional] 
**Parameters** | **Dictionary&lt;string, string&gt;** | Template parameters. Which parameters are required depends on the template: &#39;ccy&#39; for rate curve  templates, &#39;instrument&#39; for equity and vol templates, &#39;currencyPair&#39; for FX templates; RiskOff  requires &#39;ccy&#39; and &#39;instrument&#39;. All templates accept an optional &#39;amount&#39; override of the  template&#39;s default shift size. | [optional] 

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
