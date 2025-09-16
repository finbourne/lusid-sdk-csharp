# Lusid.Sdk.Model.Execution
The record of a number of executions against a single Placement (directly analogous to  a partial or full fill against a street order).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**PlacementId** | [**ResourceId**](ResourceId.md) |  | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this execution. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument ordered. | 
**LusidInstrumentId** | **string** | The LUSID instrument id for the instrument execution. | 
**Quantity** | **decimal** | The quantity of given instrument ordered. | 
**State** | **string** | The state of this execution (typically a FIX state; Open, Filled, etc). | 
**Side** | **string** | The side (Buy, Sell, ...) of this execution. | 
**Type** | **string** | The type of this execution (Market, Limit, etc). | 
**CreatedDate** | **DateTimeOffset** | The active date of this execution. | 
**SettlementDate** | **DateTimeOffset?** | The (optional) settlement date for this execution | [optional] 
**Price** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | 
**SettlementCurrency** | **string** | The execution&#39;s settlement currency. | 
**SettlementCurrencyFxRate** | **decimal** | The exectuion&#39;s settlement currency rate. | 
**Counterparty** | **string** | The market entity this placement is placed with. | 
**AveragePrice** | **decimal?** | The average price of all executions for a given placement at the time of upsert | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**DataModelMembership** | [**DataModelMembership**](DataModelMembership.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
ResourceId placementId = new ResourceId();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
string lusidInstrumentId = "lusidInstrumentId";decimal quantity = "quantity";

string state = "state";
string side = "side";
string type = "type";
CurrencyAndAmount price = new CurrencyAndAmount();
string settlementCurrency = "settlementCurrency";decimal settlementCurrencyFxRate = "settlementCurrencyFxRate";

string counterparty = "counterparty";
ModelVersion? varVersion = new ModelVersion();

DataModelMembership? dataModelMembership = new DataModelMembership();

List<Link> links = new List<Link>();

Execution executionInstance = new Execution(
    id: id,
    placementId: placementId,
    properties: properties,
    instrumentIdentifiers: instrumentIdentifiers,
    lusidInstrumentId: lusidInstrumentId,
    quantity: quantity,
    state: state,
    side: side,
    type: type,
    createdDate: createdDate,
    settlementDate: settlementDate,
    price: price,
    settlementCurrency: settlementCurrency,
    settlementCurrencyFxRate: settlementCurrencyFxRate,
    counterparty: counterparty,
    averagePrice: averagePrice,
    varVersion: varVersion,
    dataModelMembership: dataModelMembership,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
