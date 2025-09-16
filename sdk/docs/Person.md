# Lusid.Sdk.Model.Person

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DisplayName** | **string** | The display name of the Person | [optional] 
**Description** | **string** | The description of the Person | [optional] 
**Href** | **string** | The specifc Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**LusidPersonId** | **string** | The unique LUSID Person Identifier of the Person. | [optional] 
**Identifiers** | [**Dictionary&lt;string, Property&gt;**](Property.md) | Unique client-defined identifiers of the Person. | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) | A set of properties associated to the Person. There can be multiple properties associated with a property key. | [optional] 
**Relationships** | [**List&lt;Relationship&gt;**](Relationship.md) | A set of relationships associated to the Person. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string displayName = "example displayName";
string description = "example description";
string href = "example href";
string lusidPersonId = "example lusidPersonId";
Dictionary<string, Property> identifiers = new Dictionary<string, Property>();
Dictionary<string, Property> properties = new Dictionary<string, Property>();
List<Relationship> relationships = new List<Relationship>();
ModelVersion? varVersion = new ModelVersion();

List<Link> links = new List<Link>();

Person personInstance = new Person(
    displayName: displayName,
    description: description,
    href: href,
    lusidPersonId: lusidPersonId,
    identifiers: identifiers,
    properties: properties,
    relationships: relationships,
    varVersion: varVersion,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
