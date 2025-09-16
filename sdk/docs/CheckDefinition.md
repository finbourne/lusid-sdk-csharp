# Lusid.Sdk.Model.CheckDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Check Definition. | [optional] 
**Description** | **string** | A description for the Check Definition. | [optional] 
**DatasetSchema** | [**CheckDefinitionDatasetSchema**](CheckDefinitionDatasetSchema.md) |  | [optional] 
**RuleSets** | [**List&lt;CheckDefinitionRuleSet&gt;**](CheckDefinitionRuleSet.md) | A collection of rule sets for the Check Definition. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Check Definition. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "example displayName";
string description = "example description";
CheckDefinitionDatasetSchema? datasetSchema = new CheckDefinitionDatasetSchema();

List<CheckDefinitionRuleSet> ruleSets = new List<CheckDefinitionRuleSet>();
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<Link> links = new List<Link>();

CheckDefinition checkDefinitionInstance = new CheckDefinition(
    id: id,
    displayName: displayName,
    description: description,
    datasetSchema: datasetSchema,
    ruleSets: ruleSets,
    href: href,
    varVersion: varVersion,
    properties: properties,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
