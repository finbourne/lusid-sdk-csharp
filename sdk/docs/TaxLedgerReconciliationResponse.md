# Lusid.Sdk.Model.TaxLedgerReconciliationResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Period** | [**TaxAccountingPeriod**](TaxAccountingPeriod.md) |  | [optional] 
**LedgerCapitalGainLoss** | **decimal** | The realised and unrealised capital gain or loss recorded in the ledger for the period. | [optional] 
**ComparableTaxFigure** | **decimal** | The tax figure on the same basis as the ledger, before the return adjustments. | [optional] 
**Differences** | [**List&lt;TaxReconciliationDifferenceRow&gt;**](TaxReconciliationDifferenceRow.md) | The explained differences between the two sides, by holding. | [optional] 
**Unexplained** | **decimal** | The part of the difference not explained by any category. Nil when the reconciliation is complete. | [optional] 
**Bridge** | [**List&lt;TaxReconciliationBridgeRow&gt;**](TaxReconciliationBridgeRow.md) | The bridge from the ledger figure to the return total. | [optional] 
**ReturnTotal** | **decimal** | The total of lines A, D and LR. | [optional] 
**BridgeUnexplained** | **decimal** | The part of the bridge not explained. Nil when the bridge is complete. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? fundId = new ResourceId();

TaxAccountingPeriod? period = new TaxAccountingPeriod();
decimal? ledgerCapitalGainLoss = "example ledgerCapitalGainLoss";decimal? comparableTaxFigure = "example comparableTaxFigure";
List<TaxReconciliationDifferenceRow> differences = new List<TaxReconciliationDifferenceRow>();decimal? unexplained = "example unexplained";
List<TaxReconciliationBridgeRow> bridge = new List<TaxReconciliationBridgeRow>();decimal? returnTotal = "example returnTotal";decimal? bridgeUnexplained = "example bridgeUnexplained";

TaxLedgerReconciliationResponse taxLedgerReconciliationResponseInstance = new TaxLedgerReconciliationResponse(
    fundId: fundId,
    period: period,
    ledgerCapitalGainLoss: ledgerCapitalGainLoss,
    comparableTaxFigure: comparableTaxFigure,
    differences: differences,
    unexplained: unexplained,
    bridge: bridge,
    returnTotal: returnTotal,
    bridgeUnexplained: bridgeUnexplained);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
