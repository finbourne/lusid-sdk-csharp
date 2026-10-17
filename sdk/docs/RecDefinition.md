# Lusid.Sdk.Model.RecDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the rec definition. | 
**Description** | **string** | A description of the rec definition. | [optional] 
**SideNames** | [**RecDefSideNames**](RecDefSideNames.md) |  | [optional] 
**Details** | [**RecDefinitionDetails**](RecDefinitionDetails.md) |  | 
**ReviewConfiguration** | [**RecReviewConfiguration**](RecReviewConfiguration.md) |  | 
**DatePolicy** | [**RecDatePolicy**](RecDatePolicy.md) |  | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Properties in the RecDefinition domain. On update, a property with a null value is deleted and omitted properties are left unchanged. Filterable and sortable. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string displayName = "displayName";
string description = "example description";
RecDefSideNames? sideNames = new RecDefSideNames();

RecDefinitionDetails details = new RecDefinitionDetails();
RecReviewConfiguration reviewConfiguration = new RecReviewConfiguration();
RecDatePolicy datePolicy = new RecDatePolicy();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

RecDefinition recDefinitionInstance = new RecDefinition(
    id: id,
    displayName: displayName,
    description: description,
    sideNames: sideNames,
    details: details,
    reviewConfiguration: reviewConfiguration,
    datePolicy: datePolicy,
    properties: properties,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
