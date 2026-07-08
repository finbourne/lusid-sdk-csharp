# Lusid.Sdk.Model.EventInheritance
The information that determines the rules for instrument event inheritance.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ParentCorporateActionSourceId** | [**ResourceId**](ResourceId.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId parentCorporateActionSourceId = new ResourceId();

EventInheritance eventInheritanceInstance = new EventInheritance(
    parentCorporateActionSourceId: parentCorporateActionSourceId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
