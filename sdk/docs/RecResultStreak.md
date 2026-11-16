# Lusid.Sdk.Model.RecResultStreak
The run of consecutive instances, ending at this result, in which the same result was produced, with its  difference and open sub-streaks.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Predecessor** | [**RecResultStreakPredecessor**](RecResultStreakPredecessor.md) |  | 
**Age** | **string** | The ISO 8601 duration from the startResult&#39;s asAtFirstSeen to the runAsAt of this result&#39;s latest run. Always positive. | 
**CountInstances** | **int** | The number of instances in the streak, including this one. Always 2 or more. | 
**StartResult** | [**RecAgedResult**](RecAgedResult.md) |  | 
**DifferenceStreak** | [**RecResultSubStreak**](RecResultSubStreak.md) |  | 
**OpenStreak** | [**RecResultSubStreak**](RecResultSubStreak.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

RecResultStreakPredecessor predecessor = new RecResultStreakPredecessor();
string age = "age";
RecAgedResult startResult = new RecAgedResult();
RecResultSubStreak differenceStreak = new RecResultSubStreak();
RecResultSubStreak openStreak = new RecResultSubStreak();

RecResultStreak recResultStreakInstance = new RecResultStreak(
    predecessor: predecessor,
    age: age,
    countInstances: countInstances,
    startResult: startResult,
    differenceStreak: differenceStreak,
    openStreak: openStreak);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
