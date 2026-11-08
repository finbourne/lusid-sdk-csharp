# Lusid.Sdk.Model.CollateralAllocationLine
One asset chosen for a margin call, with what a transaction moving it needs: the instrument, the portfolio and  account it leaves, the units, the price and the consideration. An override that fails a constraint is kept with  its exclusion reason and covers nothing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentId** | **string** | The LUSID instrument identifier of the asset, or CCY_ and the currency code for cash. | 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument identifiers a transaction for the line is booked against. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**CustodianAccount** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Currency** | **string** | The currency the asset is denominated in, when known. | [optional] 
**Units** | **decimal** | The units to move. | 
**Price** | **decimal?** | The market value per unit in the base currency, before any haircut. Null when the asset could not be priced. | [optional] 
**Consideration** | **decimal?** | Units times price in the base currency: what a transaction for the line settles. Null when the asset could not be priced. | [optional] 
**EffectiveValuePerUnit** | **decimal?** | Price times the valuation percentage, less the FX haircut: what one unit counts for as collateral. | [optional] 
**CollateralValue** | **decimal** | The collateral value the line covers: units times the effective value per unit. | 
**CostPerUnitOfValue** | **decimal?** | The ranking key: the annual cost of one unit of collateral value from this asset. | [optional] 
**SettlementDate** | **DateTimeOffset?** | When the movement would settle under the agreement&#39;s settlement lag, counting weekdays. | [optional] 
**BoundBy** | **string** | Which limit decided the units. One of RemainingRequirement, FreeUnits, ConcentrationCap, LotRounding or Override. | 
**ExclusionReason** | **string** | The constraint the asset failed, when it did. One of NotEligible, NoFreeUnits, MissingPrice, MissingRate, MissesDeadline, BelowMinimumLot or ConcentrationExhausted. Null when it passed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentId = "instrumentId";
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
ResourceId portfolioId = new ResourceId();
ResourceId? custodianAccount = new ResourceId();

string currency = "example currency";decimal units = "units";
decimal collateralValue = "collateralValue";

string boundBy = "boundBy";
string exclusionReason = "example exclusionReason";

CollateralAllocationLine collateralAllocationLineInstance = new CollateralAllocationLine(
    instrumentId: instrumentId,
    instrumentIdentifiers: instrumentIdentifiers,
    portfolioId: portfolioId,
    custodianAccount: custodianAccount,
    currency: currency,
    units: units,
    price: price,
    consideration: consideration,
    effectiveValuePerUnit: effectiveValuePerUnit,
    collateralValue: collateralValue,
    costPerUnitOfValue: costPerUnitOfValue,
    settlementDate: settlementDate,
    boundBy: boundBy,
    exclusionReason: exclusionReason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
