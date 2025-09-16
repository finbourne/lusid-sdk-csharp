# Lusid.Sdk.Model.TransactionConfigurationData

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Aliases** | [**List&lt;TransactionConfigurationTypeAlias&gt;**](TransactionConfigurationTypeAlias.md) | List of transaction types that map to this specific transaction configuration | 
**Movements** | [**List&lt;TransactionConfigurationMovementData&gt;**](TransactionConfigurationMovementData.md) | Movement data for the transaction type | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Properties attached to the transaction type | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<TransactionConfigurationTypeAlias> aliases = new List<TransactionConfigurationTypeAlias>();
List<TransactionConfigurationMovementData> movements = new List<TransactionConfigurationMovementData>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();

TransactionConfigurationData transactionConfigurationDataInstance = new TransactionConfigurationData(
    aliases: aliases,
    movements: movements,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
