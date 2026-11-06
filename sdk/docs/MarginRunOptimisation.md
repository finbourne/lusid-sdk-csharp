# Lusid.Sdk.Model.MarginRunOptimisation

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Status** | **string** | How far the pass got. One of Pending, Completed, Skipped or Failed. | 
**RecommendationCount** | **int** | How many recommendations the pass made. | 
**Detail** | **string** | What the pass left out and why, or why it failed. Null when nothing was left out. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string status = "status";
string detail = "example detail";

MarginRunOptimisation marginRunOptimisationInstance = new MarginRunOptimisation(
    status: status,
    recommendationCount: recommendationCount,
    detail: detail);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
