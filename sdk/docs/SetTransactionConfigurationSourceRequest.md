# Lusid.Sdk.Model.SetTransactionConfigurationSourceRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Aliases** | [**List&lt;SetTransactionConfigurationAlias&gt;**](SetTransactionConfigurationAlias.md) |  | 
**Movements** | [**List&lt;TransactionConfigurationMovementDataRequest&gt;**](TransactionConfigurationMovementDataRequest.md) |  | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<SetTransactionConfigurationAlias> aliases = new List<SetTransactionConfigurationAlias>();
List<TransactionConfigurationMovementDataRequest> movements = new List<TransactionConfigurationMovementDataRequest>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();

SetTransactionConfigurationSourceRequest setTransactionConfigurationSourceRequestInstance = new SetTransactionConfigurationSourceRequest(
    aliases: aliases,
    movements: movements,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
