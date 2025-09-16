# Lusid.Sdk.Model.CompletePortfolio

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Description** | **string** | The long form description of the portfolio. | [optional] 
**DisplayName** | **string** | The name of the portfolio. | [optional] 
**Created** | **DateTimeOffset** | The effective datetime at which the portfolio was created. No transactions or constituents can be added to the portfolio before this date. | [optional] 
**ParentPortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**IsDerived** | **bool** | Whether or not this is a derived portfolio. | [optional] [readonly] 
**Type** | **string** | The type of the portfolio. The available values are: Transaction, Reference, DerivedTransaction, SimplePosition | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Properties** | [**List&lt;Property&gt;**](Property.md) | The requested portfolio properties. These will be from the &#39;Portfolio&#39; domain. | [optional] 
**BaseCurrency** | **string** | If the portfolio is a transaction portfolio or derived transaction portfolio, this is the base currency of the portfolio. | [optional] 
**SubHoldingKeys** | **List&lt;string&gt;** | The sub holding key properties configured for the portfolio | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string href = "example href";
string description = "example description";
string displayName = "example displayName";
ResourceId? parentPortfolioId = new ResourceId();

bool isDerived = //"True";
string type = "example type";
ModelVersion varVersion = new ModelVersion();
List<Property> properties = new List<Property>();
string baseCurrency = "example baseCurrency";
List<string> subHoldingKeys = new List<string>();
List<Link> links = new List<Link>();

CompletePortfolio completePortfolioInstance = new CompletePortfolio(
    id: id,
    href: href,
    description: description,
    displayName: displayName,
    created: created,
    parentPortfolioId: parentPortfolioId,
    isDerived: isDerived,
    type: type,
    varVersion: varVersion,
    properties: properties,
    baseCurrency: baseCurrency,
    subHoldingKeys: subHoldingKeys,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
