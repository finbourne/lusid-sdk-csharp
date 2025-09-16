# Lusid.Sdk.Model.UpsertComplianceRuleRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Name** | **string** |  | [optional] 
**Description** | **string** |  | [optional] 
**Active** | **bool** |  | 
**TemplateId** | [**ResourceId**](ResourceId.md) |  | 
**Variation** | **string** |  | 
**PortfolioGroupId** | [**ResourceId**](ResourceId.md) |  | 
**Parameters** | [**Dictionary&lt;string, ComplianceParameter&gt;**](ComplianceParameter.md) |  | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string name = "example name";
string description = "example description";
bool active = //"True";
ResourceId templateId = new ResourceId();
string variation = "variation";
ResourceId portfolioGroupId = new ResourceId();
Dictionary<string, ComplianceParameter> parameters = new Dictionary<string, ComplianceParameter>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();

UpsertComplianceRuleRequest upsertComplianceRuleRequestInstance = new UpsertComplianceRuleRequest(
    id: id,
    name: name,
    description: description,
    active: active,
    templateId: templateId,
    variation: variation,
    portfolioGroupId: portfolioGroupId,
    parameters: parameters,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
