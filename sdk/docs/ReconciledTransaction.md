# Lusid.Sdk.Model.ReconciledTransaction
Information about reconciled transactions.  At least one of Left and Right will be populated.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**Transaction**](Transaction.md) |  | [optional] 
**Right** | [**Transaction**](Transaction.md) |  | [optional] 
**PercentageMatch** | **decimal** | How good a match this is considered to be. | [optional] 
**MappingRuleSetResults** | **List&lt;bool&gt;** | The result of each individual mapping rule result.  Will only be present if both Left and Right are populated. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Transaction? left = new Transaction();

Transaction? right = new Transaction();
decimal? percentageMatch = "example percentageMatch";
List<bool> mappingRuleSetResults = new List<bool>();

ReconciledTransaction reconciledTransactionInstance = new ReconciledTransaction(
    left: left,
    right: right,
    percentageMatch: percentageMatch,
    mappingRuleSetResults: mappingRuleSetResults);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
