# Lusid.Sdk.Model.RecResultSubStreak
The part of a streak, ending at this result, over which a stricter condition held: same difference, or open.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Age** | **string** | The ISO 8601 duration from the startResult&#39;s asAtFirstSeen to the runAsAt of this result&#39;s latest run. Zero when the predecessor does not extend the sub-streak. | 
**CountInstances** | **int?** | The number of instances in the sub-streak, including this one. Null when the predecessor does not extend the sub-streak; otherwise 2 or more. | [optional] 
**StartResult** | [**RecAgedResult**](RecAgedResult.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string age = "age";
RecAgedResult? startResult = new RecAgedResult();


RecResultSubStreak recResultSubStreakInstance = new RecResultSubStreak(
    age: age,
    countInstances: countInstances,
    startResult: startResult);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
