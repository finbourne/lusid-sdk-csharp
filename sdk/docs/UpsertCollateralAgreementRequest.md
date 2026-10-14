# Lusid.Sdk.Model.UpsertCollateralAgreementRequest
The request used to create or update a Collateral Agreement. The scope and code come from the route.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CounterpartyId** | [**CounterpartyIdentifier**](CounterpartyIdentifier.md) |  | 
**ApplicabilityFilter** | **string** | A filter selecting the portfolios and trades the agreement covers. Checked for structure only when the agreement is stored. | 
**BaseCurrency** | **string** | The currency margin is calculated and called in. Filterable. | 
**CutLabel** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The cut label naming the market data that margin is valued at. | 
**RecipeId** | [**ResourceId**](ResourceId.md) |  | 
**MinimumTransferAmount** | **decimal?** | The smallest margin movement that is called. Optional. | [optional] 
**Rounding** | [**MarginRounding**](MarginRounding.md) |  | 
**SettlementLag** | [**MarginSettlementLag**](MarginSettlementLag.md) |  | 
**MatchTolerance** | **decimal?** | The tolerance within which our margin figure and the counterparty&#39;s are considered to match. Optional. | [optional] 
**VariationMargin** | [**List&lt;MarginItem&gt;**](MarginItem.md) | The variation margin arrangements under the agreement. | [optional] 
**InitialMargin** | [**List&lt;MarginItem&gt;**](MarginItem.md) | The initial margin arrangements under the agreement. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties to decorate onto the Collateral Agreement. Filterable. | [optional] 
**EffectiveAt** | **DateTimeOffset?** | The effective datetime or cut label from which the change applies. Defaults to the current LUSID system datetime if not specified. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

CounterpartyIdentifier counterpartyId = new CounterpartyIdentifier();
string applicabilityFilter = "applicabilityFilter";
string baseCurrency = "baseCurrency";
DateTimeOrCutLabel cutLabel = "cutLabel";
ResourceId recipeId = new ResourceId();
MarginRounding rounding = new MarginRounding();
MarginSettlementLag settlementLag = new MarginSettlementLag();
List<MarginItem> variationMargin = new List<MarginItem>();
List<MarginItem> initialMargin = new List<MarginItem>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();

UpsertCollateralAgreementRequest upsertCollateralAgreementRequestInstance = new UpsertCollateralAgreementRequest(
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
    properties: properties,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
