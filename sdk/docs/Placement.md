# Lusid.Sdk.Model.Placement
A street order for a quantity of a single instrument placed with a single market entity.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**ParentPlacementId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**BlockIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The IDs of the Blocks associated with this placement. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this placement. | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument ordered. | 
**LusidInstrumentId** | **string** | The LUSID instrument id for the instrument placement. | 
**Quantity** | **decimal** | The quantity of given instrument ordered. | 
**State** | **string** | The state of this placement (typically a FIX state; Open, Filled, etc). | 
**Side** | **string** | The side (Buy, Sell, ...) of this placement. | 
**TimeInForce** | **string** | The time in force applicable to this placement (GTC, FOK, Day, etc) | 
**Type** | **string** | The type of this placement (Market, Limit, etc). | 
**CreatedDate** | **DateTimeOffset** | The active date of this placement. | 
**LimitPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**StopPrice** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Counterparty** | **string** | Optionally specifies the market entity this placement is placed with. | [optional] 
**ExecutionSystem** | **string** | Optionally specifies the execution system in use. | [optional] 
**EntryType** | **string** | Optionally specifies the entry type of this placement. | [optional] 
**Version** | [**Version**](Version.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) | Collection of links. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

