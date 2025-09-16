# Lusid.Sdk.Model.InvestorRecord
Representation of an Investor Record on the LUSID API

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** | The scope in which the Investor Record lies. | [optional] 
**Identifiers** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Unique client-defined identifiers of the Investor Record. | [optional] 
**DisplayName** | **string** | The display name of the Investor Record | [optional] 
**Description** | **string** | The description of the Investor Record | [optional] 
**Investor** | [**Investor**](Investor.md) |  | [optional] 
**LusidInvestorRecordId** | **string** | The unique LUSID Investor Record Identifier of the Investor Record. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties associated to the Investor Record. | [optional] 
**Relationships** | [**List&lt;Relationship&gt;**](Relationship.md) | A set of relationships associated to the Investor Record. | [optional] 
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "example scope";
Dictionary<string, Property> identifiers = new Dictionary<string, Property>();
string displayName = "example displayName";
string description = "example description";
Investor? investor = new Investor();

string lusidInvestorRecordId = "example lusidInvestorRecordId";
Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<Relationship> relationships = new List<Relationship>();
string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

InvestorRecord investorRecordInstance = new InvestorRecord(
    scope: scope,
    identifiers: identifiers,
    displayName: displayName,
    description: description,
    investor: investor,
    lusidInvestorRecordId: lusidInvestorRecordId,
    properties: properties,
    relationships: relationships,
    href: href,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
