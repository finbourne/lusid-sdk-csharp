# Lusid.Sdk.Model.AllocationEventRoundingResidual
The cents left over when one component of an Allocation Event was rounded to the currency's minor unit, and where they went.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Component** | **string** | The component the residual belongs to. | [optional] 
**Cents** | **int** | The number of minor units left over after each share was truncated to the currency. | [optional] 
**Amount** | **decimal** | The same, in the event currency. | [optional] 
**Method** | **string** | How the leftover was placed: LargestRemainder spreads it one minor unit at a time over the largest remainders; RoundingPartner gives all of it to the map&#39;s rounding partner line. Available values: LargestRemainder, RoundingPartner. | [optional] 
**TakenBy** | **List&lt;string&gt;** | The investor records that each took a minor unit, in the order they took it. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string component = "example component";decimal? amount = "example amount";
string method = "example method";
List<string> takenBy = new List<string>();

AllocationEventRoundingResidual allocationEventRoundingResidualInstance = new AllocationEventRoundingResidual(
    component: component,
    cents: cents,
    amount: amount,
    method: method,
    takenBy: takenBy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
