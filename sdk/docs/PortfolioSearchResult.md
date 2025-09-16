# Lusid.Sdk.Model.PortfolioSearchResult
A list of portfolios.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Type** | **string** | The type of the portfolio. The available values are: Transaction, Reference, DerivedTransaction, SimplePosition | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Description** | **string** | The long form description of the portfolio. | [optional] 
**DisplayName** | **string** | The name of the portfolio. | 
**IsDerived** | **bool** | Whether or not this is a derived portfolio. | [optional] [readonly] 
**Created** | **DateTimeOffset** | The effective datetime at which the portfolio was created. No transactions or constituents can be added to the portfolio before this date. | 
**ParentPortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**BaseCurrency** | **string** | The base currency of the portfolio. | [optional] 
**Properties** | [**List&lt;Property&gt;**](Property.md) | The requested portfolio properties. These will be from the &#39;Portfolio&#39; domain. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string type = "type";
string href = "example href";
string description = "example description";
string displayName = "displayName";
bool isDerived = //"True";
ResourceId? parentPortfolioId = new ResourceId();

string baseCurrency = "example baseCurrency";
List<Property> properties = new List<Property>();
List<Link> links = new List<Link>();

PortfolioSearchResult portfolioSearchResultInstance = new PortfolioSearchResult(
    id: id,
    type: type,
    href: href,
    description: description,
    displayName: displayName,
    isDerived: isDerived,
    created: created,
    parentPortfolioId: parentPortfolioId,
    baseCurrency: baseCurrency,
    properties: properties,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
