# Lusid.Sdk.Model.FacilityLimitChange
A change to a Facility's committed limit: the limit in force from a date until the next change.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveFrom** | **DateTimeOffset** |  | 
**Limit** | **decimal** |  | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal limit = "limit";


FacilityLimitChange facilityLimitChangeInstance = new FacilityLimitChange(
    effectiveFrom: effectiveFrom,
    limit: limit);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
