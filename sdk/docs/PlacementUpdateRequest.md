# Lusid.Sdk.Model.PlacementUpdateRequest
A request to create or update a Placement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Quantity** | **decimal?** | The quantity of given instrument ordered. | [optional] 
**Properties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | Client-defined properties associated with this placement. | [optional] 
**Counterparty** | **string** | Optionally specifies the market entity this placement is placed with. | [optional] 
**ExecutionSystem** | **string** | Optionally specifies the execution system in use. | [optional] 
**EntryType** | **string** | Optionally specifies the entry type of this placement. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
Dictionary<string, PerpetualProperty> properties = new Dictionary<string, PerpetualProperty>();
string counterparty = "example counterparty";
string executionSystem = "example executionSystem";
string entryType = "example entryType";

PlacementUpdateRequest placementUpdateRequestInstance = new PlacementUpdateRequest(
    id: id,
    quantity: quantity,
    properties: properties,
    counterparty: counterparty,
    executionSystem: executionSystem,
    entryType: entryType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
