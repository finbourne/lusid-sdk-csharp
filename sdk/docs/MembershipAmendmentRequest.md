# Lusid.Sdk.Model.MembershipAmendmentRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CustomDataModelId** | [**ResourceId**](ResourceId.md) |  | 
**EntityType** | **string** | The type of the entity that is being added or removed from the Custom Data Model. | 
**EntityUniqueId** | **string** | The entity unique identifier of the entity that is being added or removed from the Custom Data Model. | 
**Operation** | **string** | The operation to be performed on the entity&#39;s membership in the Custom Data Model. Either &#39;Add&#39; or &#39;Remove&#39;. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId customDataModelId = new ResourceId();
string entityType = "entityType";
string entityUniqueId = "entityUniqueId";
string operation = "operation";

MembershipAmendmentRequest membershipAmendmentRequestInstance = new MembershipAmendmentRequest(
    customDataModelId: customDataModelId,
    entityType: entityType,
    entityUniqueId: entityUniqueId,
    operation: operation);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
