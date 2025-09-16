# Lusid.Sdk.Model.ComplianceRuleTemplate

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Description** | **string** | The description of the Compliance Template | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Properties associated with the Compliance Template Variation | [optional] 
**Variations** | [**List&lt;ComplianceTemplateVariationDto&gt;**](ComplianceTemplateVariationDto.md) | Variation details of a Compliance Template | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? id = new ResourceId();

string description = "example description";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<ComplianceTemplateVariationDto> variations = new List<ComplianceTemplateVariationDto>();
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

ComplianceRuleTemplate complianceRuleTemplateInstance = new ComplianceRuleTemplate(
    id: id,
    description: description,
    properties: properties,
    variations: variations,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
