# Lusid.Sdk.Model.UpsertInstrumentPropertyRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**IdentifierType** | **string** | The unique identifier type to search for the instrument, for example &#39;Figi&#39;. | 
**Identifier** | **string** | A value of that type to identify the instrument to upsert properties for, for example &#39;BBG000BLNNV0&#39;. | 
**Properties** | [**List&lt;Property&gt;**](Property.md) | A set of instrument properties and associated values to store for the instrument. Each property must be from the &#39;Instrument&#39; domain. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string identifierType = "identifierType";
string identifier = "identifier";
List<Property> properties = new List<Property>();

UpsertInstrumentPropertyRequest upsertInstrumentPropertyRequestInstance = new UpsertInstrumentPropertyRequest(
    identifierType: identifierType,
    identifier: identifier,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
