# Lusid.Sdk.Model.RecActivitySinceEffectiveAt
A per-side exclusive lower bound on an activity window's effective range.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | **DateTimeOffset** | The exclusive lower bound for the left side. Activity effective at exactly this datetime falls outside the window. | 
**Right** | **DateTimeOffset** | The exclusive lower bound for the right side. Activity effective at exactly this datetime falls outside the window. | 

```csharp
using Lusid.Sdk.Model;
using System;


RecActivitySinceEffectiveAt recActivitySinceEffectiveAtInstance = new RecActivitySinceEffectiveAt(
    left: left,
    right: right);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
