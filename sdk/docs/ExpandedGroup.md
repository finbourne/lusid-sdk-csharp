# Lusid.Sdk.Model.ExpandedGroup

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the portfolio group. | 
**Description** | **string** | The long form description of the portfolio group. | [optional] 
**Values** | [**List&lt;CompletePortfolio&gt;**](CompletePortfolio.md) | The collection of resource identifiers for the portfolios contained in the portfolio group. | [optional] 
**SubGroups** | [**List&lt;ExpandedGroup&gt;**](ExpandedGroup.md) | The collection of resource identifiers for the portfolio groups contained in the portfolio group as sub groups. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "example description";
List<CompletePortfolio> values = new List<CompletePortfolio>();
List<ExpandedGroup> subGroups = new List<ExpandedGroup>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

ExpandedGroup expandedGroupInstance = new ExpandedGroup(
    href: href,
    id: id,
    displayName: displayName,
    description: description,
    values: values,
    subGroups: subGroups,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
