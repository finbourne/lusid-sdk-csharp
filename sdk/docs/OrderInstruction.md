# Lusid.Sdk.Model.OrderInstruction
Record of an order instruction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**CreatedDate** | **DateTimeOffset** | The active date of this order instruction. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this execution. | [optional] 
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**InstrumentIdentifiers** | **Dictionary&lt;string, string&gt;** | The instrument ordered. | 
**Quantity** | **decimal?** | The quantity of given instrument ordered. | [optional] 
**Weight** | **decimal?** | The weight of given instrument ordered. | [optional] 
**Price** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**InstrumentScope** | **string** | The scope in which the instrument lies | [optional] 
**LusidInstrumentId** | **string** | The LUSID instrument id for the instrument ordered. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)

