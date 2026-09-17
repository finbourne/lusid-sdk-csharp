# Lusid.Sdk.Model.RecAsAtPolicy
The knowledge-date policy of each side of a rec definition. Optional as a whole, defaulting to Latest on both  sides, but both sides are required when it is supplied.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | **string** | The left side&#39;s policy. Latest: the left asAt may not be supplied at instantiation, is stamped as the latest at run time and advances on re-run. Explicit: the left asAt is the caller&#39;s, defaulting to the current date-time, and is pinned on the instance. Available values: Latest, Explicit. | 
**Right** | **string** | The right side&#39;s policy. Latest: the right asAt may not be supplied at instantiation, is stamped as the latest at run time and advances on re-run. Explicit: the right asAt is the caller&#39;s, defaulting to the current date-time, and is pinned on the instance. Available values: Latest, Explicit. | 

```csharp
using Lusid.Sdk.Model;
using System;

string left = "left";
string right = "right";

RecAsAtPolicy recAsAtPolicyInstance = new RecAsAtPolicy(
    left: left,
    right: right);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
