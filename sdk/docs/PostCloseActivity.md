# Lusid.Sdk.Model.PostCloseActivity

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EntityType** | **string** |  | 
**EntityUniqueId** | **string** |  | 
**AsAt** | **DateTimeOffset** |  | 
**EffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string entityType = "entityType";
string entityUniqueId = "entityUniqueId";
DateTimeOrCutLabel effectiveAt = "example effectiveAt";

PostCloseActivity postCloseActivityInstance = new PostCloseActivity(
    entityType: entityType,
    entityUniqueId: entityUniqueId,
    asAt: asAt,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
