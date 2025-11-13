# Lusid.Sdk.Model.Fund
A Fund entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | The name of the Fund. | [optional] 
**Description** | **string** | A description for the Fund. | [optional] 
**BaseCurrency** | **string** | The base currency of the Fund in ISO 4217 currency code format. All portfolios must be of a matching base currency. | [optional] 
**InvestorStructure** | **string** | The Investor structure to be used by the Fund. Supported values are &#39;NonUnitised&#39; and &#39;Classes&#39;. | 
**PortfolioIds** | [**List&lt;PortfolioEntityIdWithDetails&gt;**](PortfolioEntityIdWithDetails.md) | A list of the portfolios on the fund, which are part of the Fund. Note: These must all have the same base currency, which must also much the Fund Base Currency. | [optional] 
**FundConfigurationId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**AborId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ShareClassInstruments** | [**List&lt;InstrumentResolutionDetail&gt;**](InstrumentResolutionDetail.md) | Details the user-provided instrument identifiers and the instrument resolved from them. | [optional] 
**Type** | **string** | The type of fund; &#39;Standalone&#39;, &#39;Master&#39; or &#39;Feeder&#39; | [optional] 
**InceptionDate** | **DateTimeOffset** | Inception date of the Fund | 
**DecimalPlaces** | **int?** | Number of decimal places for reporting | [optional] 
**YearEndDate** | [**DayMonth**](DayMonth.md) |  | [optional] 
**PrimaryNavType** | [**NavTypeDefinition**](NavTypeDefinition.md) |  | [optional] 
**AdditionalNavTypes** | [**List&lt;NavTypeDefinition&gt;**](NavTypeDefinition.md) | The definitions for any additional NAVs on the Fund. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Fund. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
string displayName = "example displayName";
string description = "example description";
string baseCurrency = "example baseCurrency";
string investorStructure = "investorStructure";
List<PortfolioEntityIdWithDetails> portfolioIds = new List<PortfolioEntityIdWithDetails>();
ResourceId? fundConfigurationId = new ResourceId();

ResourceId? aborId = new ResourceId();

List<InstrumentResolutionDetail> shareClassInstruments = new List<InstrumentResolutionDetail>();
string type = "example type";
DayMonth? yearEndDate = new DayMonth();

NavTypeDefinition? primaryNavType = new NavTypeDefinition();

List<NavTypeDefinition> additionalNavTypes = new List<NavTypeDefinition>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

Fund fundInstance = new Fund(
    href: href,
    id: id,
    displayName: displayName,
    description: description,
    baseCurrency: baseCurrency,
    investorStructure: investorStructure,
    portfolioIds: portfolioIds,
    fundConfigurationId: fundConfigurationId,
    aborId: aborId,
    shareClassInstruments: shareClassInstruments,
    type: type,
    inceptionDate: inceptionDate,
    decimalPlaces: decimalPlaces,
    yearEndDate: yearEndDate,
    primaryNavType: primaryNavType,
    additionalNavTypes: additionalNavTypes,
    properties: properties,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
