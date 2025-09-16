# Lusid.Sdk.Model.UpdateComplianceTemplateRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code given for the Compliance Template | 
**Description** | **string** | The description of the Compliance Template | 
**Variations** | [**List&lt;ComplianceTemplateVariationRequest&gt;**](ComplianceTemplateVariationRequest.md) | Variation details of a Compliance Template | 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string description = "description";
List<ComplianceTemplateVariationRequest> variations = new List<ComplianceTemplateVariationRequest>();

UpdateComplianceTemplateRequest updateComplianceTemplateRequestInstance = new UpdateComplianceTemplateRequest(
    code: code,
    description: description,
    variations: variations);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
