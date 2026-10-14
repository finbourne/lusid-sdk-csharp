# Lusid.Sdk.Model.CollateralAgreement
A collateral agreement: who it covers, how exposure is valued, and the variation and initial margin  arrangements collateral is called and returned under.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Id** | [**ResourceId**](ResourceId.md) |  | 
**CounterpartyId** | [**CounterpartyIdentifier**](CounterpartyIdentifier.md) |  | [optional] 
**ApplicabilityFilter** | **string** | A filter selecting the portfolios and trades the agreement covers. Checked for structure only when the agreement is stored. | [optional] 
**BaseCurrency** | **string** | The currency margin is calculated and called in. Filterable. | [optional] 
**CutLabel** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The cut label naming the market data that margin is valued at. | [optional] 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**MinimumTransferAmount** | **decimal?** | The smallest margin movement that is called. Optional. | [optional] 
**Rounding** | [**MarginRounding**](MarginRounding.md) |  | [optional] 
**SettlementLag** | [**MarginSettlementLag**](MarginSettlementLag.md) |  | [optional] 
**MatchTolerance** | **decimal?** | The tolerance within which our margin figure and the counterparty&#39;s are considered to match. Optional. | [optional] 
**VariationMargin** | [**List&lt;MarginItem&gt;**](MarginItem.md) | The variation margin arrangements under the agreement. | [optional] 
**InitialMargin** | [**List&lt;MarginItem&gt;**](MarginItem.md) | The initial margin arrangements under the agreement. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties to decorate onto the Collateral Agreement. Filterable. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ResourceId id = new ResourceId();
CounterpartyIdentifier? counterpartyId = new CounterpartyIdentifier();

string applicabilityFilter = "example applicabilityFilter";
string baseCurrency = "example baseCurrency";
DateTimeOrCutLabel cutLabel = "example cutLabel";
ResourceId? recipeId = new ResourceId();

MarginRounding? rounding = new MarginRounding();

MarginSettlementLag? settlementLag = new MarginSettlementLag();

List<MarginItem> variationMargin = new List<MarginItem>();
List<MarginItem> initialMargin = new List<MarginItem>();
ModelVersion? varVersion = new ModelVersion();

Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<Link> links = new List<Link>();

CollateralAgreement collateralAgreementInstance = new CollateralAgreement(
    href: href,
    id: id,
    counterpartyId: counterpartyId,
    applicabilityFilter: applicabilityFilter,
    baseCurrency: baseCurrency,
    cutLabel: cutLabel,
    recipeId: recipeId,
    minimumTransferAmount: minimumTransferAmount,
    rounding: rounding,
    settlementLag: settlementLag,
    matchTolerance: matchTolerance,
    variationMargin: variationMargin,
    initialMargin: initialMargin,
    varVersion: varVersion,
    properties: properties,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
