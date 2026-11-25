# Lusid.Sdk.Model.FixedBusinessDayLookbackActivityWindow
The activity window whose since bound on each side is a set number of business days before that side's  effectiveAt, counted in a time zone against optional holiday calendars, with each side configured on its own.  Stateless, so it is accepted under every effectiveAtProgression.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | [**RecBusinessDayLookbackSide**](RecBusinessDayLookbackSide.md) |  | 
**Right** | [**RecBusinessDayLookbackSide**](RecBusinessDayLookbackSide.md) |  | 
**WindowType** | **string** | Polymorphic discriminator. Supported types: Contiguous, FixedPeriodLookback, FixedBusinessDayLookback. Contiguous requires effectiveAtProgression Series; the lookback types are accepted under any progression. Available values: Contiguous, FixedPeriodLookback, FixedBusinessDayLookback, Explicit, ClosedPeriod, ContiguousAsAt. | 

```csharp
using Lusid.Sdk.Model;
using System;

RecBusinessDayLookbackSide left = new RecBusinessDayLookbackSide();
RecBusinessDayLookbackSide right = new RecBusinessDayLookbackSide();
string windowType = "windowType";

FixedBusinessDayLookbackActivityWindow fixedBusinessDayLookbackActivityWindowInstance = new FixedBusinessDayLookbackActivityWindow(
    left: left,
    right: right,
    windowType: windowType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
