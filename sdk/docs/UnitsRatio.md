# Lusid.Sdk.Model.UnitsRatio
The number of units you have after the event (output) for a given number of units you have prior to the event (input).

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Input** | **decimal** | Input amount.  Denominator of the Ratio | 
**Output** | **decimal** | Output amount. Numerator of the Ratio | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal input = "input";
decimal output = "output";


UnitsRatio unitsRatioInstance = new UnitsRatio(
    input: input,
    output: output);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
