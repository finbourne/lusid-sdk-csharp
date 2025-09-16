# Lusid.Sdk.Model.ComplianceTemplateVariation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | Label of a Compliance Template Variation | 
**Description** | **string** | The description of the Compliance Template Variation | 
**RequiredParameters** | [**List&lt;ComplianceTemplateParameter&gt;**](ComplianceTemplateParameter.md) | A parameter required by a Compliance Template Variation | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Properties associated with the Compliance Template Variation | 
**AcceptedAddressKeys** | [**ResourceId**](ResourceId.md) |  | 
**Steps** | [**List&lt;ComplianceStep&gt;**](ComplianceStep.md) | The steps expressed in this template, with their required parameters | 
**ReferencedGroupLabel** | **string** | The label of a given referenced group in a Compliance Rule Template Variation | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string label = "label";
string description = "description";
List<ComplianceTemplateParameter> requiredParameters = new List<ComplianceTemplateParameter>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
ResourceId acceptedAddressKeys = new ResourceId();
List<ComplianceStep> steps = new List<ComplianceStep>();
string referencedGroupLabel = "example referencedGroupLabel";

ComplianceTemplateVariation complianceTemplateVariationInstance = new ComplianceTemplateVariation(
    label: label,
    description: description,
    requiredParameters: requiredParameters,
    properties: properties,
    acceptedAddressKeys: acceptedAddressKeys,
    steps: steps,
    referencedGroupLabel: referencedGroupLabel);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
