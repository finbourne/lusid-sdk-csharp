# Lusid.Sdk.Model.InstrumentDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The name of the instrument. | 
**Identifiers** | [**Dictionary&lt;string, InstrumentIdValue&gt;**](InstrumentIdValue.md) | A set of identifiers that can be used to identify the instrument. At least one of these must be configured to be a unique identifier. | 
**Properties** | [**List&lt;Property&gt;**](Property.md) | Set of unique instrument properties and associated values to store with the instrument. Each property must be from the &#39;Instrument&#39; domain. | [optional] 
**LookThroughPortfolioId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Definition** | [**LusidInstrument**](LusidInstrument.md) |  | [optional] 
**SettlementCycle** | [**SettlementCycle**](SettlementCycle.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string name = "name";
Dictionary<string, InstrumentIdValue> identifiers = new Dictionary<string, InstrumentIdValue>();
List<Property> properties = new List<Property>();
ResourceId? lookThroughPortfolioId = new ResourceId();

LusidInstrument? definition = new LusidInstrument();

SettlementCycle? settlementCycle = new SettlementCycle();


InstrumentDefinition instrumentDefinitionInstance = new InstrumentDefinition(
    name: name,
    identifiers: identifiers,
    properties: properties,
    lookThroughPortfolioId: lookThroughPortfolioId,
    definition: definition,
    settlementCycle: settlementCycle);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
