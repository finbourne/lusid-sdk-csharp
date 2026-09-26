# Lusid.Sdk.Model.PlacementUpdateRequest
A request to update a Placement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Quantity** | **decimal?** | The quantity of given instrument ordered. | [optional] 
**Amount** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this placement. | [optional] 
**Type** | **string** | Optionally changes the type of this placement (Market, Limit, Stop, StopLimit, etc). A type change is permitted only when the associated block is of type &#39;Market&#39;. Setting the type to &#39;Market&#39; clears the placement&#39;s stop and limit prices; any other type change leaves them as they are. | [optional] 
**LimitPrice** | **decimal?** | Optionally updates the limit price of this placement, in the placement&#39;s limit price currency unless a currency is also specified. A price on a placement with no limit price currency is stored but not returned until a currency is supplied. | [optional] 
**StopPrice** | **decimal?** | Optionally updates the stop price of this placement, in the placement&#39;s stop price currency unless a currency is also specified. A price on a placement with no stop price currency is stored but not returned until a currency is supplied. | [optional] 
**Counterparty** | **string** | Optionally specifies the market entity this placement is placed with. | [optional] 
**ExecutionSystem** | **string** | Optionally specifies the execution system in use. | [optional] 
**EntryType** | **string** | Optionally specifies the entry type of this placement. Available values: Undecided, Manual, Direct, Ems, External. | [optional] 
**Currency** | **string** | Optionally sets the ISO currency code of the placement&#39;s stop and/or limit price. Not permitted for a Market placement. For a value placement it must match the currency of the amount exactly, whether that amount is on the placement or in the update. When omitted, no currency checks are applied. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
CurrencyAndAmount? amount = new CurrencyAndAmount();

Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
string type = "example type";
string counterparty = "example counterparty";
string executionSystem = "example executionSystem";
string entryType = "example entryType";
string currency = "example currency";

PlacementUpdateRequest placementUpdateRequestInstance = new PlacementUpdateRequest(
    id: id,
    quantity: quantity,
    amount: amount,
    properties: properties,
    type: type,
    limitPrice: limitPrice,
    stopPrice: stopPrice,
    counterparty: counterparty,
    executionSystem: executionSystem,
    entryType: entryType,
    currency: currency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
