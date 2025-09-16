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
**Weight** | **decimal?** | The proportion of the total portfolio value ordered for the given instrument ordered. | [optional] 
**Price** | [**CurrencyAndAmount**](CurrencyAndAmount.md) |  | [optional] 
**InstrumentScope** | **string** | The scope in which the instrument lies | [optional] 
**LusidInstrumentId** | **string** | The LUSID instrument id for the instrument ordered. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**DataModelMembership** | [**DataModelMembership**](DataModelMembership.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
ResourceId? portfolioId = new ResourceId();

Dictionary<string, string> instrumentIdentifiers = new Dictionary<string, string>();
CurrencyAndAmount? price = new CurrencyAndAmount();

string instrumentScope = "example instrumentScope";
string lusidInstrumentId = "example lusidInstrumentId";
ModelVersion? varVersion = new ModelVersion();

DataModelMembership? dataModelMembership = new DataModelMembership();

List<Link> links = new List<Link>();

OrderInstruction orderInstructionInstance = new OrderInstruction(
    id: id,
    createdDate: createdDate,
    properties: properties,
    portfolioId: portfolioId,
    instrumentIdentifiers: instrumentIdentifiers,
    quantity: quantity,
    weight: weight,
    price: price,
    instrumentScope: instrumentScope,
    lusidInstrumentId: lusidInstrumentId,
    varVersion: varVersion,
    dataModelMembership: dataModelMembership,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
