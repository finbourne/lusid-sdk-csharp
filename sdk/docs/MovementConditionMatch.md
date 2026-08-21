# Lusid.Sdk.Model.MovementConditionMatch
The outcome of one movement's condition for a transaction. Reported per movement rather than keyed by  movement, because a transaction type may configure several movements that share a side and have no name.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MovementName** | **string** | The name of the movement, or null if the movement is unnamed. | [optional] 
**Side** | **string** | The side the movement is configured against. | 
**ConditionMatched** | **bool** | Whether the movement&#39;s condition was satisfied by this transaction. A movement with no condition always matches. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string movementName = "example movementName";
string side = "side";
bool conditionMatched = //"True";

MovementConditionMatch movementConditionMatchInstance = new MovementConditionMatch(
    movementName: movementName,
    side: side,
    conditionMatched: conditionMatched);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
