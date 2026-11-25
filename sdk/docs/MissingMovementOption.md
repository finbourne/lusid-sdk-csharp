# Lusid.Sdk.Model.MissingMovementOption
A movement option one of a transaction type's line legs must carry for the register to see what it books, and does not, named by that movement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MovementName** | **string** | The name of the movement that carries the delta. | [optional] 
**Side** | **string** | The side of the movement that carries the delta. | 
**Option** | **string** | The movement option the leg lacks. Currently always &#39;Registry&#39;. | 

```csharp
using Lusid.Sdk.Model;
using System;

string movementName = "example movementName";
string side = "side";
string option = "option";

MissingMovementOption missingMovementOptionInstance = new MissingMovementOption(
    movementName: movementName,
    side: side,
    option: option);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
