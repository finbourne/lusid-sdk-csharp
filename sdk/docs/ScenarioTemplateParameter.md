# Lusid.Sdk.Model.ScenarioTemplateParameter
One parameter of a scenario template: its name (case-sensitive), whether it must be supplied,  what it means, and - for optional numeric parameters - the default used when omitted and the  unit the value is read in.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The parameter name, as supplied in the create request&#39;s Parameters dictionary. Case-sensitive. | [optional] 
**Required** | **bool** | Whether the parameter must be supplied. | [optional] 
**Description** | **string** | What the parameter means to this template. | [optional] 
**DefaultValue** | **string** | The value used when the parameter is omitted. Null for required parameters. | [optional] 
**Unit** | **string** | The unit a numeric value is read in: &#39;BasisPoints&#39;, &#39;PercentagePoints&#39; or &#39;Fraction&#39;  (0.20 meaning +20%). The templates do NOT share one unit - read this per template.  Null for non-numeric parameters. | [optional] 
**ExclusiveGroup** | **string** | Parameters of a template sharing an ExclusiveGroup are alternatives: exactly one of them must  be supplied. Group members are not individually Required and carry no default. Null for  parameters that stand alone. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "example name";
bool required = //"True";
string description = "example description";
string defaultValue = "example defaultValue";
string unit = "example unit";
string exclusiveGroup = "example exclusiveGroup";

ScenarioTemplateParameter scenarioTemplateParameterInstance = new ScenarioTemplateParameter(
    name: name,
    required: required,
    description: description,
    defaultValue: defaultValue,
    unit: unit,
    exclusiveGroup: exclusiveGroup);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
