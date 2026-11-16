# Lusid.Sdk.Model.TaxLedgerReconciliationHoldingResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Period** | [**TaxAccountingPeriod**](TaxAccountingPeriod.md) |  | [optional] 
**HoldingId** | **string** | The identifier of the holding. For a company this is the pooled LUSID instrument identifier, for a fund the portfolio code and instrument identifier. | [optional] 
**InstrumentId** | **string** | The LUSID unique identifier of the instrument. | [optional] 
**InstrumentName** | **string** | The name of the instrument. | [optional] 
**PortfolioCode** | **string** | The code of the portfolio the holding sits in, or the pooled marker for a company. | [optional] 
**LedgerRealised** | **decimal** | The realised gain or loss recorded in the ledger for the holding. | [optional] 
**LedgerUnrealisedMovement** | **decimal** | The movement in unrealised gain or loss recorded in the ledger for the holding. | [optional] 
**TaxRealisedUnindexed** | **decimal** | The realised gain or loss for tax before indexation. | [optional] 
**TaxUnrealisedMovementUnindexed** | **decimal** | The movement in the unrealised gain or loss for tax before indexation. | [optional] 
**DeemedDisposalNet** | **decimal** | The net deemed-disposal amount for the holding. | [optional] 
**LoanRelationshipNet** | **decimal** | The net loan relationship credit or debit for the holding. | [optional] 
**Category** | **string** | The reconciliation category of the difference, when there is one. Available values: ExcludedHoldings, TaxCostAdjustments, OutOfSync, Scope, PoolAveraging, Matching, Indexation, KinkTest. | [optional] 
**Difference** | **decimal** | The difference between the two sides. | [optional] 
**Explanation** | **string** | The explanation of the difference. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? fundId = new ResourceId();

TaxAccountingPeriod? period = new TaxAccountingPeriod();

string holdingId = "example holdingId";
string instrumentId = "example instrumentId";
string instrumentName = "example instrumentName";
string portfolioCode = "example portfolioCode";decimal? ledgerRealised = "example ledgerRealised";decimal? ledgerUnrealisedMovement = "example ledgerUnrealisedMovement";decimal? taxRealisedUnindexed = "example taxRealisedUnindexed";decimal? taxUnrealisedMovementUnindexed = "example taxUnrealisedMovementUnindexed";decimal? deemedDisposalNet = "example deemedDisposalNet";decimal? loanRelationshipNet = "example loanRelationshipNet";
string category = "example category";decimal? difference = "example difference";
string explanation = "example explanation";

TaxLedgerReconciliationHoldingResponse taxLedgerReconciliationHoldingResponseInstance = new TaxLedgerReconciliationHoldingResponse(
    fundId: fundId,
    period: period,
    holdingId: holdingId,
    instrumentId: instrumentId,
    instrumentName: instrumentName,
    portfolioCode: portfolioCode,
    ledgerRealised: ledgerRealised,
    ledgerUnrealisedMovement: ledgerUnrealisedMovement,
    taxRealisedUnindexed: taxRealisedUnindexed,
    taxUnrealisedMovementUnindexed: taxUnrealisedMovementUnindexed,
    deemedDisposalNet: deemedDisposalNet,
    loanRelationshipNet: loanRelationshipNet,
    category: category,
    difference: difference,
    explanation: explanation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
