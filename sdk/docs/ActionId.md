# Lusid.Sdk.Model.ActionId

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Scope** | **string** |  | 
**Activity** | **string** |  | 
**Entity** | **string** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string scope = "scope";
string activity = "activity";
string entity = "entity";

ActionId actionIdInstance = new ActionId(
    scope: scope,
    activity: activity,
    entity: entity);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
