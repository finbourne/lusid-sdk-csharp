# Lusid.Sdk.Model.PackRegisterDelta
A register balance delta: a partners' capital balance, the direction it moves in once booked and the figure it moves by.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The holding property key of the register balance, for example PaidInCapital or UncalledCommitment. | 
**Direction** | **string** | The direction the balance moves in when the type is booked, the movement&#39;s own direction folded into the delta&#39;s. Available values: Increase, Decrease. | 
**Source** | **string** | The movement figure the delta moves the balance by. Available values: Amount, Units, PortfolioAmount, ProportionOfBalance, PortfolioAmountAtAverageRate. | 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
string direction = "direction";
string source = "source";

PackRegisterDelta packRegisterDeltaInstance = new PackRegisterDelta(
    key: key,
    direction: direction,
    source: source);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
