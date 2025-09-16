# Lusid.Sdk.Model.AmortisationRuleSet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | A user-friendly name. | 
**Description** | **string** | A description of what this rule set is for. | [optional] 
**RulesInterval** | [**RulesInterval**](RulesInterval.md) |  | 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "example description";
RulesInterval rulesInterval = new RulesInterval();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

AmortisationRuleSet amortisationRuleSetInstance = new AmortisationRuleSet(
    href: href,
    id: id,
    displayName: displayName,
    description: description,
    rulesInterval: rulesInterval,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
