# Lusid.Sdk.Model.PackageRequest
A request to create or update a Package.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**OrderIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Related order ids. | 
**OrderInstructionIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Related order instruction ids. | 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this execution. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
List<ResourceId> orderIds = new List<ResourceId>();
List<ResourceId> orderInstructionIds = new List<ResourceId>();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();

PackageRequest packageRequestInstance = new PackageRequest(
    id: id,
    orderIds: orderIds,
    orderInstructionIds: orderInstructionIds,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
