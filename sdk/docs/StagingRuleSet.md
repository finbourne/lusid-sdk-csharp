# Lusid.Sdk.Model.StagingRuleSet

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The entity type the staging rule set applies to. | 
**StagingRuleSetId** | **string** | System generated unique id for the staging rule set. | 
**DisplayName** | **string** | The name of the staging rule set. | 
**Description** | **string** | A description for the staging rule set. | [optional] 
**Rules** | [**List&lt;StagingRule&gt;**](StagingRule.md) | The list of staging rules that apply to a specific entity type. | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "entityType";
string stagingRuleSetId = "stagingRuleSetId";
string displayName = "displayName";
string description = "example description";
List<StagingRule> rules = new List<StagingRule>();
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

StagingRuleSet stagingRuleSetInstance = new StagingRuleSet(
    entityType: entityType,
    stagingRuleSetId: stagingRuleSetId,
    displayName: displayName,
    description: description,
    rules: rules,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
