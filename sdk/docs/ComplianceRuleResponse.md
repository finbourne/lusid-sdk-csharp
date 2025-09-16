# Lusid.Sdk.Model.ComplianceRuleResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Active** | **bool** |  | [optional] 
**TemplateId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Variation** | **string** |  | [optional] 
**PortfolioGroupId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Parameters** | [**Dictionary&lt;string, ComplianceParameter&gt;**](ComplianceParameter.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? id = new ResourceId();

string name = "example name";
string description = "example description";
bool active = //"True";
ResourceId? templateId = new ResourceId();

string variation = "example variation";
ResourceId? portfolioGroupId = new ResourceId();

Dictionary<string, ComplianceParameter> parameters = new Dictionary<string, ComplianceParameter>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

ComplianceRuleResponse complianceRuleResponseInstance = new ComplianceRuleResponse(
    id: id,
    name: name,
    description: description,
    active: active,
    templateId: templateId,
    variation: variation,
    portfolioGroupId: portfolioGroupId,
    parameters: parameters,
    properties: properties,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
