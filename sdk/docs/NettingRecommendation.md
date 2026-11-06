# Lusid.Sdk.Model.NettingRecommendation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RunId** | **string** | The run the recommendation was made from. Filterable. | 
**SourceAgreementId** | [**ResourceId**](ResourceId.md) |  | 
**SourceItem** | **string** | The initial-margin item the trades would leave. Filterable. | 
**TargetAgreementId** | [**ResourceId**](ResourceId.md) |  | 
**TargetItem** | **string** | The initial-margin item the trades would join. Filterable. | 
**Transfer** | **string** | How the trades would get there: Redesignation when both agreements face one counterparty, Novation otherwise. Filterable. | 
**InstrumentType** | **string** | LUSID&#39;s type for the instruments in the cluster. Filterable. | [optional] 
**Currency** | **string** | The currency the cluster&#39;s trades are denominated in. Filterable. | [optional] 
**MaturityBucket** | **string** | The residual-maturity bucket the cluster&#39;s trades fall in on the run date; empty for instruments without a maturity. Filterable. | [optional] 
**Trades** | [**List&lt;TradeReference&gt;**](TradeReference.md) | The holdings that would move. | 
**SavingPerDay** | **decimal** | What we would no longer fund each day across both sets, in the sets&#39; base currency. Filterable. | 
**OneOffCost** | **decimal** | The novation cost when the transfer is one; zero for a re-designation. Filterable. | 
**PaybackDays** | **decimal** | How many days of saving cover the one-off cost. Filterable. | 
**InitialMarginChange** | **decimal** | The sum over both sets of what we would post after the move less what we post today. Filterable. | 
**Source** | [**InitialMarginChange**](InitialMarginChange.md) |  | 
**Target** | [**InitialMarginChange**](InitialMarginChange.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string runId = "runId";
ResourceId sourceAgreementId = new ResourceId();
string sourceItem = "sourceItem";
ResourceId targetAgreementId = new ResourceId();
string targetItem = "targetItem";
string transfer = "transfer";
string instrumentType = "example instrumentType";
string currency = "example currency";
string maturityBucket = "example maturityBucket";
List<TradeReference> trades = new List<TradeReference>();decimal savingPerDay = "savingPerDay";
decimal oneOffCost = "oneOffCost";
decimal paybackDays = "paybackDays";
decimal initialMarginChange = "initialMarginChange";

InitialMarginChange source = new InitialMarginChange();
InitialMarginChange target = new InitialMarginChange();

NettingRecommendation nettingRecommendationInstance = new NettingRecommendation(
    runId: runId,
    sourceAgreementId: sourceAgreementId,
    sourceItem: sourceItem,
    targetAgreementId: targetAgreementId,
    targetItem: targetItem,
    transfer: transfer,
    instrumentType: instrumentType,
    currency: currency,
    maturityBucket: maturityBucket,
    trades: trades,
    savingPerDay: savingPerDay,
    oneOffCost: oneOffCost,
    paybackDays: paybackDays,
    initialMarginChange: initialMarginChange,
    source: source,
    target: target);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
