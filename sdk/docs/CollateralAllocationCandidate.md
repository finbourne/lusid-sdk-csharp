# Lusid.Sdk.Model.CollateralAllocationCandidate
One holding the allocation considered for a margin call, with its figures as far as they could be computed and  either its rank or the constraint that excluded it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentId** | **string** | The LUSID instrument identifier of the asset, or CCY_ and the currency code for cash. | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument identifiers a transaction for the line is booked against. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**CustodianAccount** | [**ResourceId**](ResourceId.md) |  | [optional] 
**AssetKind** | **string** | Cash or Security. | 
**Currency** | **string** | The currency the asset is denominated in, when known. | [optional] 
**UnitsFree** | **decimal** | Units not in a margin account and not promised to an earlier call of the run. | 
**LotSize** | **decimal** | The smallest number of units the asset is delivered in. | 
**Price** | **decimal?** | The market value per unit in the base currency, before any haircut. Null when the asset could not be priced. | [optional] 
**EligibilitySeq** | **int?** | The one-based position of the schedule row that admits the asset. Null when no row does. | [optional] 
**ValuationPercentage** | **decimal?** | The fraction of market value the schedule row counts as collateral. | [optional] 
**FxHaircut** | **decimal?** | The further fraction deducted because the asset is not in the base currency. Zero when it is. | [optional] 
**EffectiveValuePerUnit** | **decimal?** | Price times the valuation percentage, less the FX haircut: what one unit counts for as collateral. | [optional] 
**OpportunityRate** | **decimal?** | The annual rate the fund gives up by locking the asset up: funding less the agreement&#39;s cash interest for cash, the lending fee it would otherwise earn for a security. | [optional] 
**CostPerUnitOfValue** | **decimal?** | The ranking key: the annual cost of one unit of collateral value from this asset. | [optional] 
**ConcentrationCap** | **decimal?** | The collateral value the schedule&#39;s concentration limit still allows from the asset&#39;s group. Null when the row sets no limit. | [optional] 
**SettlementDate** | **DateTimeOffset?** | When the movement would settle under the agreement&#39;s settlement lag, counting weekdays. | [optional] 
**Rank** | **int?** | The asset&#39;s position in the ranking, cheapest first. Null when excluded. | [optional] 
**ExclusionReason** | **string** | The constraint the asset failed, when it did. One of NotEligible, NoFreeUnits, MissingPrice, MissingRate, MissesDeadline, BelowMinimumLot or ConcentrationExhausted. Null when it passed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentId = "instrumentId";
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
ResourceId portfolioId = new ResourceId();
ResourceId? custodianAccount = new ResourceId();

string assetKind = "assetKind";
string currency = "example currency";decimal unitsFree = "unitsFree";
decimal lotSize = "lotSize";

string exclusionReason = "example exclusionReason";

CollateralAllocationCandidate collateralAllocationCandidateInstance = new CollateralAllocationCandidate(
    instrumentId: instrumentId,
    instrumentIdentifiers: instrumentIdentifiers,
    portfolioId: portfolioId,
    custodianAccount: custodianAccount,
    assetKind: assetKind,
    currency: currency,
    unitsFree: unitsFree,
    lotSize: lotSize,
    price: price,
    eligibilitySeq: eligibilitySeq,
    valuationPercentage: valuationPercentage,
    fxHaircut: fxHaircut,
    effectiveValuePerUnit: effectiveValuePerUnit,
    opportunityRate: opportunityRate,
    costPerUnitOfValue: costPerUnitOfValue,
    concentrationCap: concentrationCap,
    settlementDate: settlementDate,
    rank: rank,
    exclusionReason: exclusionReason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
