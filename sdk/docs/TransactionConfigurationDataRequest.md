# Lusid.Sdk.Model.TransactionConfigurationDataRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Aliases** | [**List&lt;TransactionConfigurationTypeAlias&gt;**](TransactionConfigurationTypeAlias.md) | List of transaction codes that map to this specific transaction model | 
**Movements** | [**List&lt;TransactionConfigurationMovementDataRequest&gt;**](TransactionConfigurationMovementDataRequest.md) | Movement data for the transaction code | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Properties attached to the underlying holding. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<TransactionConfigurationTypeAlias> aliases = new List<TransactionConfigurationTypeAlias>();
List<TransactionConfigurationMovementDataRequest> movements = new List<TransactionConfigurationMovementDataRequest>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();

TransactionConfigurationDataRequest transactionConfigurationDataRequestInstance = new TransactionConfigurationDataRequest(
    aliases: aliases,
    movements: movements,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
