# Lusid.Sdk.Model.LegalEntity
Representation of Legal Entity on LUSID API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The display name of the Legal Entity | [optional] 
**Description** | **string** | The description of the Legal Entity | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**LusidLegalEntityId** | **string** | The unique LUSID Legal Entity Identifier of the Legal Entity. | [optional] 
**Identifiers** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Unique client-defined identifiers of the Legal Entity. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties associated to the Legal Entity. | [optional] 
**Relationships** | [**List&lt;Relationship&gt;**](Relationship.md) | A set of relationships associated to the Legal Entity. | [optional] 
**CounterpartyRiskInformation** | [**CounterpartyRiskInformation**](CounterpartyRiskInformation.md) |  | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "example displayName";
string description = "example description";
string href = "example href";
string lusidLegalEntityId = "example lusidLegalEntityId";
Dictionary<string, Property> identifiers = new Dictionary<string, Property>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<Relationship> relationships = new List<Relationship>();
CounterpartyRiskInformation? counterpartyRiskInformation = new CounterpartyRiskInformation();

ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

LegalEntity legalEntityInstance = new LegalEntity(
    displayName: displayName,
    description: description,
    href: href,
    lusidLegalEntityId: lusidLegalEntityId,
    identifiers: identifiers,
    properties: properties,
    relationships: relationships,
    counterpartyRiskInformation: counterpartyRiskInformation,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
