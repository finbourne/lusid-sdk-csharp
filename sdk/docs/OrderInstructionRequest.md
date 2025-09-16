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
**Weight** | **decimal?** | The proportion of the total portfolio value ordered for the given instrument ordered. | [optional] 
**Price** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this execution. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
ResourceId? portfolioId = new ResourceId();

Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
CurrencyAndAmount? price = new CurrencyAndAmount();

Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();

OrderInstructionRequest orderInstructionRequestInstance = new OrderInstructionRequest(
    id: id,
    createdDate: createdDate,
    portfolioId: portfolioId,
    instrumentIdentifiers: instrumentIdentifiers,
    quantity: quantity,
    weight: weight,
    price: price,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
