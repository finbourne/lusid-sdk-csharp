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
**InvestorStructure** | **string** | The Investor structure to be used by the Fund. Available values: NonUnitised, Classes. | 
**PortfolioIds** | [**List&lt;PortfolioEntityIdWithDetails&gt;**](PortfolioEntityIdWithDetails.md) | A list of the portfolios on the fund, which are part of the Fund. Note: These must all have the same base currency, which must also match the Fund Base Currency. | [optional] 
**FundConfigurationId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ShortCode** | **string** | A short code for the Fund. A fund structure tags journal entry lines with the short code of the member they originated from, so it should be unique across the funds of one structure. Optional. | [optional] 
**AborId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**ShareClassInstruments** | [**List&lt;InstrumentResolutionDetail&gt;**](InstrumentResolutionDetail.md) | Details the user-provided instrument identifiers and the instrument resolved from them. These would be decommissioned in favour of the new AllocationGroups and ShareClasses structures. | [optional] 
**Type** | **string** | The kind of vehicle the fund is, one of the values of the system/fundVehicleType data type. Master and Feeder are deprecated: the structural role of a fund now lives on its fund structure node, and a fund with either type cannot be a member of a fund structure. Available values: Standalone, Master, Feeder, SPV, AIV, TaxBlocker, CarryVehicle, SponsorCommitmentVehicle, CoInvestVehicle, GPInterestHolder, SMA, CTA. | [optional] 
**TaxTransparency** | **string** | Whether the Fund is looked through for tax: Transparent passes its income and gains to its holders as their own, Opaque is taxed in its own right. Optional; if not set, a TaxBlocker is Opaque and a CarryVehicle or GPInterestHolder is Transparent. A fund structure requires it on every SPV and AIV member. Available values: Transparent, Opaque. | [optional] 
**InceptionDate** | **DateTimeOffset** | Inception date of the Fund | 
**DecimalPlaces** | **int?** | Number of decimal places for reporting | [optional] 
**YearEndDate** | [**DayMonth**](DayMonth.md) |  | [optional] 
**PrimaryNavType** | [**NavType**](NavType.md) |  | [optional] 
**AdditionalNavTypes** | [**List&lt;NavType&gt;**](NavType.md) | The definitions for any additional NAVs on the Fund. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Fund. | [optional] 
**CreateInstrument** | **bool** | Whether to create instruments for the Fund&#39;s share classes, series, or partner classes upon creation. Defaults to false. | [optional] 
**AllocationGroups** | [**List&lt;AllocationGroup&gt;**](AllocationGroup.md) | An optional list of Allocation Group definitions for the Fund. | [optional] 
**ShareClasses** | [**List&lt;ShareClass&gt;**](ShareClass.md) | An optional list of Share Class definitions for the Fund. | [optional] 
**FundInstrument** | [**FundInstrument**](FundInstrument.md) |  | [optional] 
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

string shortCode = "example shortCode";
ResourceId? aborId = new ResourceId();

List<InstrumentResolutionDetail> shareClassInstruments = new List<InstrumentResolutionDetail>();
string type = "example type";
string taxTransparency = "example taxTransparency";
DayMonth? yearEndDate = new DayMonth();

NavType? primaryNavType = new NavType();

List<NavType> additionalNavTypes = new List<NavType>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
bool createInstrument = //"True";
List<AllocationGroup> allocationGroups = new List<AllocationGroup>();
List<ShareClass> shareClasses = new List<ShareClass>();
FundInstrument? fundInstrument = new FundInstrument();

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
    shortCode: shortCode,
    aborId: aborId,
    shareClassInstruments: shareClassInstruments,
    type: type,
    taxTransparency: taxTransparency,
    inceptionDate: inceptionDate,
    decimalPlaces: decimalPlaces,
    yearEndDate: yearEndDate,
    primaryNavType: primaryNavType,
    additionalNavTypes: additionalNavTypes,
    properties: properties,
    createInstrument: createInstrument,
    allocationGroups: allocationGroups,
    shareClasses: shareClasses,
    fundInstrument: fundInstrument,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
