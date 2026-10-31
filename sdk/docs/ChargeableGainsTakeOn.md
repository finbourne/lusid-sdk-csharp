# Lusid.Sdk.Model.ChargeableGainsTakeOn
Carried-forward chargeable-gains balances for a tax-lot taken on under the UK chargeable gains accounting method

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Role** | **string** | Available values: Section104Pool, Holding1982, Holding1965. | 
**Indexation** | **decimal?** |  | [optional] 
**IndexedTo** | **DateTimeOffset?** |  | [optional] 
**OriginalCost** | **decimal?** |  | [optional] 
**MarketValue1982** | **decimal?** |  | [optional] 
**RebasingElection** | **bool?** |  | [optional] 
**Additions** | [**List&lt;ChargeableGainsTakeOnAddition&gt;**](ChargeableGainsTakeOnAddition.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string role = "role";
bool? rebasingElection = //"True";
List<ChargeableGainsTakeOnAddition> additions = new List<ChargeableGainsTakeOnAddition>();

ChargeableGainsTakeOn chargeableGainsTakeOnInstance = new ChargeableGainsTakeOn(
    role: role,
    indexation: indexation,
    indexedTo: indexedTo,
    originalCost: originalCost,
    marketValue1982: marketValue1982,
    rebasingElection: rebasingElection,
    additions: additions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
