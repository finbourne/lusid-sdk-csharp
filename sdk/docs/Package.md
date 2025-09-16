# Lusid.Sdk.Model.Package
A structure used to describe the structure of an order or orders that make up a non-trivial trade.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**OrderIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Related order ids. | 
**OrderInstructionIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Related order instruction ids. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this execution. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**DataModelMembership** | [**DataModelMembership**](DataModelMembership.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
List<ResourceId> orderIds = new List<ResourceId>();
List<ResourceId> orderInstructionIds = new List<ResourceId>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
ModelVersion? varVersion = new ModelVersion();

DataModelMembership? dataModelMembership = new DataModelMembership();

List<Link> links = new List<Link>();

Package packageInstance = new Package(
    id: id,
    orderIds: orderIds,
    orderInstructionIds: orderInstructionIds,
    properties: properties,
    varVersion: varVersion,
    dataModelMembership: dataModelMembership,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
