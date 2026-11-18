# Lusid.Sdk.Model.RegisterDeltaMovement
A register balance delta one of a transaction type's movements carries, as the engine books it, named by that movement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The holding property key of the register balance, for example PaidInCapital or UncalledCommitment. | 
**Direction** | **string** | The direction the balance moves in when the type is booked, the movement&#39;s own direction folded into the delta&#39;s. Available values: Increase, Decrease. | 
**Source** | **string** | The movement figure the delta moves the balance by. Available values: Amount, Units, PortfolioAmount, ProportionOfBalance, PortfolioAmountAtAverageRate. | 
**MovementName** | **string** | The name of the movement that carries the delta. | [optional] 
**Side** | **string** | The side of the movement that carries the delta. | 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
string direction = "direction";
string source = "source";
string movementName = "example movementName";
string side = "side";

RegisterDeltaMovement registerDeltaMovementInstance = new RegisterDeltaMovement(
    key: key,
    direction: direction,
    source: source,
    movementName: movementName,
    side: side);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
