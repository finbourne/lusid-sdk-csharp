# Lusid.Sdk.Model.UpsertLegalEntityRequest
Request to create or update an legal entity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Identifiers** | [**Dictionary&lt;string, Property&gt;**](Property.md) | The identifiers the legal entity will be upserted with.The provided keys should be idTypeScope, idTypeCode, code | 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties associated to the Legal Entity. | [optional] 
**DisplayName** | **string** | The display name of the Legal Entity | 
**Description** | **string** | The description of the Legal Entity | [optional] 
**CounterpartyRiskInformation** | [**CounterpartyRiskInformation**](CounterpartyRiskInformation.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, Property> identifiers = new Dictionary<string, Property>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
string displayName = "displayName";
string description = "example description";
CounterpartyRiskInformation? counterpartyRiskInformation = new CounterpartyRiskInformation();


UpsertLegalEntityRequest upsertLegalEntityRequestInstance = new UpsertLegalEntityRequest(
    identifiers: identifiers,
    properties: properties,
    displayName: displayName,
    description: description,
    counterpartyRiskInformation: counterpartyRiskInformation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
