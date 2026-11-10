# Lusid.Sdk.Model.DeemedDisposal
Settings for the deemed disposal a NAV type books at period close. When enabled, the in-scope holdings are  treated as sold and immediately re-acquired at market value, realising their unrealised gain against the  chosen cost base.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Enabled** | **bool** | Whether the Nav Type books a deemed disposal at period close. When true, in-scope holdings are treated as sold and immediately re-acquired at market value, realising their unrealised gain. | 
**CostBase** | **string** | The cost the deemed disposal realises against: Book or Tax. Defaults to Book. Book: rebases book cost to base value and posts the movement as realised FX; it moves the portfolio&#39;s cost, so it is only valid on the primary Nav Type. Tax: writes a tax cost equal to market value and spreads the deemed gain since the prior tax cost. Available values: Book, Tax. | [optional] 
**HoldingsFilter** | **string** | An optional filter selecting which holdings are deemed disposed of at period close. Omit it for the cost base&#39;s default: under Book, every non-base-currency monetary item (cash, receivables, payables, accruals). Tax has no default yet, so set a filter. | [optional] 
**TransactionTypeCode** | **string** | An optional transaction type, in the Nav Type&#39;s transaction type scope, that the deemed disposal transactions are booked with. Omit it to use the domain default deemed disposal transaction type. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool enabled = //"True";
string costBase = "example costBase";
string holdingsFilter = "example holdingsFilter";
string transactionTypeCode = "example transactionTypeCode";

DeemedDisposal deemedDisposalInstance = new DeemedDisposal(
    enabled: enabled,
    costBase: costBase,
    holdingsFilter: holdingsFilter,
    transactionTypeCode: transactionTypeCode);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
