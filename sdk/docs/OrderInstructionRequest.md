# Lusid.Sdk.Model.OrderInstructionRequest
A request to create or update a Order Instruction.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**CreatedDate** | **DateTimeOffset** | The active date of this order instruction. | 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument ordered. | [optional] 
**Quantity** | **decimal?** | The quantity of given instrument ordered. | [optional] 
**Weight** | **decimal?** | The weight of given instrument ordered. | [optional] 
**Price** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this execution. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

