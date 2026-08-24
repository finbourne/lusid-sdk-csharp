# Lusid.Sdk.Model.PortfolioHoldingResult
Represents holding details for a data quality check result, where LusidEntityResult represents a scope-and-code  or identifier-addressed entity. A holding has no scope and code of its own, so it is identified by the portfolio  it came from plus what distinguishes it within that portfolio.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** | The type of the entity. Always \&quot;Holding\&quot;. | [optional] 
**AsAt** | **DateTimeOffset** | The as-at timestamp for the holding | [optional] 
**EffectiveAt** | **DateTimeOffset** | The effective-at timestamp for the holding | [optional] 
**SourcePortfolioScope** | **string** | The scope of the portfolio this holding came from | [optional] 
**SourcePortfolioCode** | **string** | The code of the portfolio this holding came from | [optional] 
**SourcePortfolioEntityUniqueId** | **string** | The unique identifier of the portfolio this holding came from | [optional] 
**SourcePortfolioDisplayName** | **string** | The display name of the portfolio this holding came from | [optional] 
**HoldingId** | **string** | The holding&#39;s identifier within its portfolio | [optional] 
**TaxlotId** | **string** | The tax lot identifier, where the holding was expanded to tax lots. Null otherwise. | [optional] 
**SubEntityId** | **string** | Identifies the holding to the derived property explain API: the holding id on its own, or the holding id  and tax lot id colon-separated where a tax lot is present. | [optional] 
**LusidInstrumentId** | **string** | The LUSID instrument identifier of the instrument held | [optional] 
**InstrumentDisplayName** | **string** | The name of the instrument held | [optional] 
**HoldingTypeName** | **string** | The kind of holding, e.g. Position, Balance | [optional] 
**Currency** | **string** | The currency of the holding | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "example entityType";
string sourcePortfolioScope = "example sourcePortfolioScope";
string sourcePortfolioCode = "example sourcePortfolioCode";
string sourcePortfolioEntityUniqueId = "example sourcePortfolioEntityUniqueId";
string sourcePortfolioDisplayName = "example sourcePortfolioDisplayName";
string holdingId = "example holdingId";
string taxlotId = "example taxlotId";
string subEntityId = "example subEntityId";
string lusidInstrumentId = "example lusidInstrumentId";
string instrumentDisplayName = "example instrumentDisplayName";
string holdingTypeName = "example holdingTypeName";
string currency = "example currency";

PortfolioHoldingResult portfolioHoldingResultInstance = new PortfolioHoldingResult(
    entityType: entityType,
    asAt: asAt,
    effectiveAt: effectiveAt,
    sourcePortfolioScope: sourcePortfolioScope,
    sourcePortfolioCode: sourcePortfolioCode,
    sourcePortfolioEntityUniqueId: sourcePortfolioEntityUniqueId,
    sourcePortfolioDisplayName: sourcePortfolioDisplayName,
    holdingId: holdingId,
    taxlotId: taxlotId,
    subEntityId: subEntityId,
    lusidInstrumentId: lusidInstrumentId,
    instrumentDisplayName: instrumentDisplayName,
    holdingTypeName: holdingTypeName,
    currency: currency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
