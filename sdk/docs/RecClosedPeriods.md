# Lusid.Sdk.Model.RecClosedPeriods
References to the closed periods created on the left and right timelines when a Closed Period  instance is locked.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**RecClosedPeriodReference**](RecClosedPeriodReference.md) |  | 
**Right** | [**RecClosedPeriodReference**](RecClosedPeriodReference.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

RecClosedPeriodReference left = new RecClosedPeriodReference();
RecClosedPeriodReference right = new RecClosedPeriodReference();

RecClosedPeriods recClosedPeriodsInstance = new RecClosedPeriods(
    left: left,
    right: right);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
