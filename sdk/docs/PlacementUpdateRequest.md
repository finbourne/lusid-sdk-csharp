# Lusid.Sdk.Model.PlacementUpdateRequest
A request to update a Placement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Quantity** | **decimal?** | The quantity of given instrument ordered. | [optional] 
**Amount** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this placement. | [optional] 
**Type** | **string** | Optionally changes the type of this placement (Market, Limit, Stop, StopLimit). A type may only be tightened: a Market placement may become Limit, Stop or StopLimit, and any placement may become StopLimit. A placement may be relaxed to Market only when the associated block is of type &#39;Market&#39;. Changing to a priced type requires a currency and the price(s) that type carries; a price the new type does not carry is cleared. Changing to Market clears both prices and may not be combined with a price update. A change to or from any other type is not subject to these rules, leaves both prices as they are, and is permitted only when the associated block is of type &#39;Market&#39;. | [optional] 
**LimitPrice** | **decimal?** | Optionally updates the limit price of this placement, in the placement&#39;s limit price currency unless a currency is also specified. A currency is required if the placement has no limit price currency. | [optional] 
**StopPrice** | **decimal?** | Optionally updates the stop price of this placement, in the placement&#39;s stop price currency unless a currency is also specified. A currency is required if the placement has no stop price currency. | [optional] 
**Counterparty** | **string** | Optionally specifies the market entity this placement is placed with. | [optional] 
**ExecutionSystem** | **string** | Optionally specifies the execution system in use. | [optional] 
**EntryType** | **string** | Optionally specifies the entry type of this placement. Available values: Undecided, Manual, Direct, Ems, External. | [optional] 
**Currency** | **string** | The ISO currency code of the stop and/or limit price carried by the placement&#39;s type. Required when the type is changed to Stop, Limit or StopLimit, or when a price is set that the placement has no currency for; not permitted for a Market placement. For a value placement it must match the currency of the amount exactly, whether that amount is on the placement or in the update. | [optional] 

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
