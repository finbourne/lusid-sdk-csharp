# Lusid.Sdk.Model.Abor
An Abor entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Abor. | [optional] 
**Description** | **string** | The description for the Abor. | [optional] 
**PortfolioIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | The list with the portfolio ids which are part of the Abor. Note: These must all have the same base currency. | 
**AborConfigurationId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Abor. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**BaseCurrency** | **string** | The base currency of the abor based on contained portfolio base currencies. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string displayName = "example displayName";
string description = "example description";
List<PortfolioEntityId> portfolioIds = new List<PortfolioEntityId>();
ResourceId? aborConfigurationId = new ResourceId();

Dictionary<string, Property> properties = new Dictionary<string, Property>();
ModelVersion? varVersion = new ModelVersion();

string baseCurrency = "example baseCurrency";
List<Link> links = new List<Link>();

Abor aborInstance = new Abor(
    href: href,
    id: id,
    displayName: displayName,
    description: description,
    portfolioIds: portfolioIds,
    aborConfigurationId: aborConfigurationId,
    properties: properties,
    varVersion: varVersion,
    baseCurrency: baseCurrency,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
