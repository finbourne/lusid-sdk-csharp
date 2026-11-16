# Lusid.Sdk.Model.TaxReturnResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Period** | [**TaxAccountingPeriod**](TaxAccountingPeriod.md) |  | [optional] 
**Status** | **string** | The workflow status of the return. Available values: Draft, Prepared, Reviewed, SignedOff, Final. Available values: Draft, Prepared, Reviewed, SignedOff, Final. | [optional] 
**Steps** | [**List&lt;TaxReturnWorkflowStep&gt;**](TaxReturnWorkflowStep.md) | The workflow history of the return in the order the steps were taken. | [optional] 
**LineA** | [**List&lt;TaxReturnDisposalRow&gt;**](TaxReturnDisposalRow.md) | Chargeable gains and allowable losses on actual disposals in the period. | [optional] 
**LineATotal** | **decimal** | The total of line A, in whole pounds. | [optional] 
**Vintages** | [**List&lt;TaxReturnVintage&gt;**](TaxReturnVintage.md) | The deemed-disposal vintages, one per period, that feed line D. | [optional] 
**Instalments** | [**List&lt;TaxReturnSpreadInstalment&gt;**](TaxReturnSpreadInstalment.md) | The instalments of earlier vintages that fall into the period. | [optional] 
**LineDTotal** | **decimal** | The total of line D, in whole pounds. | [optional] 
**LoanRelationships** | [**List&lt;TaxReturnLoanRelationshipRow&gt;**](TaxReturnLoanRelationshipRow.md) | The loan relationship and derivative holdings that make up line LR. Empty for a fund. | [optional] 
**LineLRTotal** | **decimal** | The total of line LR, in whole pounds. Zero for a fund. | [optional] 
**Outside** | [**List&lt;TaxReturnExcludedRow&gt;**](TaxReturnExcludedRow.md) | The holdings excluded from the return, with the reason. | [optional] 
**Summary** | [**List&lt;TaxReturnMemoRow&gt;**](TaxReturnMemoRow.md) | Memo rows such as the tax at the applicable rate and the minimum-profits trade profit. | [optional] 
**SyncBreakOpen** | **bool** | True when the tax records are out of sync with the ledger and the return cannot advance past Reviewed. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? fundId = new ResourceId();

TaxAccountingPeriod? period = new TaxAccountingPeriod();

string status = "example status";
List<TaxReturnWorkflowStep> steps = new List<TaxReturnWorkflowStep>();
List<TaxReturnDisposalRow> lineA = new List<TaxReturnDisposalRow>();decimal? lineATotal = "example lineATotal";
List<TaxReturnVintage> vintages = new List<TaxReturnVintage>();
List<TaxReturnSpreadInstalment> instalments = new List<TaxReturnSpreadInstalment>();decimal? lineDTotal = "example lineDTotal";
List<TaxReturnLoanRelationshipRow> loanRelationships = new List<TaxReturnLoanRelationshipRow>();decimal? lineLRTotal = "example lineLRTotal";
List<TaxReturnExcludedRow> outside = new List<TaxReturnExcludedRow>();
List<TaxReturnMemoRow> summary = new List<TaxReturnMemoRow>();
bool syncBreakOpen = //"True";

TaxReturnResponse taxReturnResponseInstance = new TaxReturnResponse(
    fundId: fundId,
    period: period,
    status: status,
    steps: steps,
    lineA: lineA,
    lineATotal: lineATotal,
    vintages: vintages,
    instalments: instalments,
    lineDTotal: lineDTotal,
    loanRelationships: loanRelationships,
    lineLRTotal: lineLRTotal,
    outside: outside,
    summary: summary,
    syncBreakOpen: syncBreakOpen);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
