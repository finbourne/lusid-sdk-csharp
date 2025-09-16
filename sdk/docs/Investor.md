# Lusid.Sdk.Model.Investor
Representation of an Investor on the LUSID API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorType** | **string** | The type of the Investor | [optional] 
**Identifiers** | **Dictionary&lt;string, string&gt;** | The identifiers of the Investor | [optional] 
**EntityUniqueId** | **string** | The unique Investor entity identifier | [optional] 
**Person** | [**Person**](Person.md) |  | [optional] 
**LegalEntity** | [**LegalEntity**](LegalEntity.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string investorType = "example investorType";
Dictionary<string, string> identifiers = new Dictionary<string, string>();
string entityUniqueId = "example entityUniqueId";
Person? person = new Person();

LegalEntity? legalEntity = new LegalEntity();


Investor investorInstance = new Investor(
    investorType: investorType,
    identifiers: identifiers,
    entityUniqueId: entityUniqueId,
    person: person,
    legalEntity: legalEntity);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
