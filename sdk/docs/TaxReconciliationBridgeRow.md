# Lusid.Sdk.Model.TaxReconciliationBridgeRow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | The label of the period, for example the four-digit year. | [optional] 
**Amount** | **decimal** | The amount, in pounds. | [optional] 
**RunningTotal** | **decimal** | The running total after this step of the bridge. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string label = "example label";decimal? amount = "example amount";decimal? runningTotal = "example runningTotal";

TaxReconciliationBridgeRow taxReconciliationBridgeRowInstance = new TaxReconciliationBridgeRow(
    label: label,
    amount: amount,
    runningTotal: runningTotal);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
