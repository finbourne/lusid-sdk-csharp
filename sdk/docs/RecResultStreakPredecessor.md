# Lusid.Sdk.Model.RecResultStreakPredecessor
The same result in the previous instance, and which streaks it extends.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Result** | [**RecAgedResult**](RecAgedResult.md) |  | 
**StreakTypes** | **List&lt;string&gt;** | Which streaks the predecessor extends: always Core, and Difference if the aggregate rule differences are unchanged. Open is not set yet. Available values: Core, Difference, Open. | 

```csharp
using Lusid.Sdk.Model;
using System;

RecAgedResult result = new RecAgedResult();
List<string> streakTypes = new List<string>();

RecResultStreakPredecessor recResultStreakPredecessorInstance = new RecResultStreakPredecessor(
    result: result,
    streakTypes: streakTypes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
