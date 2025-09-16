# Lusid.Sdk.Model.TransactionTypeRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Aliases** | [**List&lt;TransactionTypeAlias&gt;**](TransactionTypeAlias.md) | List of transaction types that map to this specific transaction configuration | 
**Movements** | [**List&lt;TransactionTypeMovement&gt;**](TransactionTypeMovement.md) | Movement data for the transaction type | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Properties attached to the transaction type | [optional] 
**Calculations** | [**List&lt;TransactionTypeCalculation&gt;**](TransactionTypeCalculation.md) | Calculations to be performed for the transaction type | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<TransactionTypeAlias> aliases = new List<TransactionTypeAlias>();
List<TransactionTypeMovement> movements = new List<TransactionTypeMovement>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
List<TransactionTypeCalculation> calculations = new List<TransactionTypeCalculation>();

TransactionTypeRequest transactionTypeRequestInstance = new TransactionTypeRequest(
    aliases: aliases,
    movements: movements,
    properties: properties,
    calculations: calculations);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
