# Lusid.Sdk.Model.ComplianceTemplateVariationRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** |  | 
**Description** | **string** |  | 
**OutcomeDescription** | **string** |  | [optional] 
**ReferencedGroupLabel** | **string** |  | [optional] 
**Steps** | [**List&lt;ComplianceStepRequest&gt;**](ComplianceStepRequest.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string label = "label";
string description = "description";
string outcomeDescription = "example outcomeDescription";
string referencedGroupLabel = "example referencedGroupLabel";
List<ComplianceStepRequest> steps = new List<ComplianceStepRequest>();

ComplianceTemplateVariationRequest complianceTemplateVariationRequestInstance = new ComplianceTemplateVariationRequest(
    label: label,
    description: description,
    outcomeDescription: outcomeDescription,
    referencedGroupLabel: referencedGroupLabel,
    steps: steps);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
