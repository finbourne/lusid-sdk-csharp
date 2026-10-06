# Lusid.Sdk.Model.FundDefinitionRequest
The request used to create a Fund.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The code given for the Fund. | 
**ShortCode** | **string** | A short code for the Fund. A fund structure tags journal entry lines with the short code of the member they originated from, so it should be unique across the funds of one structure. Optional. | [optional] 
**DisplayName** | **string** | The name of the Fund. | 
**Description** | **string** | A description for the Fund. | [optional] 
**BaseCurrency** | **string** | The base currency of the Fund in ISO 4217 currency code format. All portfolios must be of a matching base currency. | 
**InvestorStructure** | **string** | The Investor structure to be used by the Fund. Available values: NonUnitised, Classes. | [optional] 
**PortfolioIds** | [**List&lt;PortfolioEntityId&gt;**](PortfolioEntityId.md) | A list of the Portfolio IDs associated with the fund, which are part of the Fund. Note: These must all have the same base currency, which must also match the Fund Base Currency. | 
**FundConfigurationId** | [**ResourceId**](ResourceId.md) |  | 
**ShareClassInstrumentScopes** | **List&lt;string&gt;** | The scopes in which the instruments lie, currently limited to one. | [optional] 
**ShareClassInstruments** | [**List&lt;InstrumentResolutionDetail&gt;**](InstrumentResolutionDetail.md) | Details the user-provided instrument identifiers and the instrument resolved from them. These would be decommissioned in favour of the new AllocationGroups and ShareClasses structures. | [optional] 
**Type** | **string** | The kind of vehicle the fund is, one of the values of the system/fundVehicleType data type. Master and Feeder are deprecated: the structural role of a fund now lives on its fund structure node, and a fund with either type cannot be a member of a fund structure. Available values: Standalone, Master, Feeder, SPV, AIV, TaxBlocker, CarryVehicle, SponsorCommitmentVehicle, CoInvestVehicle, GPInterestHolder, SMA, CTA. | [optional] 
**TaxTransparency** | **string** | Whether the Fund is looked through for tax: Transparent passes its income and gains to its holders as their own, Opaque is taxed in its own right. Optional; if not set, a TaxBlocker is Opaque and a CarryVehicle or GPInterestHolder is Transparent. A fund structure requires it on every SPV and AIV member. Available values: Transparent, Opaque. | [optional] 
**InceptionDate** | **DateTimeOffset** | Inception date of the Fund | 
**DecimalPlaces** | **int?** | Number of decimal places for reporting | [optional] 
**PrimaryNavType** | [**NavTypeDefinition**](NavTypeDefinition.md) |  | 
**AdditionalNavTypes** | [**List&lt;NavTypeDefinition&gt;**](NavTypeDefinition.md) | The definitions for any additional NAVs on the Fund. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties for the Fund. | [optional] 
**CreateInstrument** | **bool** | Whether to create instruments for the Fund&#39;s share classes, series, or partner classes upon creation. Defaults to false. | [optional] 
**ShareClasses** | [**List&lt;ShareClassDefinition&gt;**](ShareClassDefinition.md) | An optional list of Share Class definitions for the Fund. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string shortCode = "example shortCode";
string displayName = "displayName";
string description = "example description";
string baseCurrency = "baseCurrency";
string investorStructure = "example investorStructure";
List<PortfolioEntityId> portfolioIds = new List<PortfolioEntityId>();
ResourceId fundConfigurationId = new ResourceId();
List<string> shareClassInstrumentScopes = new List<string>();
List<InstrumentResolutionDetail> shareClassInstruments = new List<InstrumentResolutionDetail>();
string type = "example type";
string taxTransparency = "example taxTransparency";
NavTypeDefinition primaryNavType = new NavTypeDefinition();
List<NavTypeDefinition> additionalNavTypes = new List<NavTypeDefinition>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
bool createInstrument = //"True";
List<ShareClassDefinition> shareClasses = new List<ShareClassDefinition>();

FundDefinitionRequest fundDefinitionRequestInstance = new FundDefinitionRequest(
    code: code,
    shortCode: shortCode,
    displayName: displayName,
    description: description,
    baseCurrency: baseCurrency,
    investorStructure: investorStructure,
    portfolioIds: portfolioIds,
    fundConfigurationId: fundConfigurationId,
    shareClassInstrumentScopes: shareClassInstrumentScopes,
    shareClassInstruments: shareClassInstruments,
    type: type,
    taxTransparency: taxTransparency,
    inceptionDate: inceptionDate,
    decimalPlaces: decimalPlaces,
    primaryNavType: primaryNavType,
    additionalNavTypes: additionalNavTypes,
    properties: properties,
    createInstrument: createInstrument,
    shareClasses: shareClasses);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
