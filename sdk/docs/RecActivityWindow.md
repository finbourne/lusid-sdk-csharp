# Lusid.Sdk.Model.RecActivityWindow
Base class for the activity windows that give the date range a rec definition's activity-based  reconciliations cover. Polymorphic by windowType; each supported type has a corresponding inherited class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WindowType** | **string** | Polymorphic discriminator. Supported types: Contiguous, FixedPeriodLookback. Contiguous requires effectiveAtProgression Series; FixedPeriodLookback is accepted under any progression. Available values: Contiguous, FixedPeriodLookback, Explicit, ClosedPeriod, ContiguousAsAt. | 
**InitialActivitySinceEffectiveAt** | [**RecActivitySinceEffectiveAt**](RecActivitySinceEffectiveAt.md) |  | 
**LookbackPeriod** | **string** | The ISO 8601 period each side&#39;s window reaches back from its effectiveAt, e.g. P1D or PT12H. Whole counts of years, months, days, hours, minutes and seconds (P[n]Y[n]M[n]DT[n]H[n]M[n]S); weeks and fractions are not supported. Must be greater than zero, and applies to both sides. Evaluated in UTC, so P1D is exactly 24 hours. The since bound is exclusive. | 

```csharp
using Lusid.Sdk.Model;
using System;
```
 [ContiguousActivityWindow](./ContiguousActivityWindow.md)See all compatible oneOf types with RecActivityWindow

# Example with RecActivityWindow
{
     Type  =  "ContiguousActivityWindow"
};
//Create RecActivityWindow Instance
var recActivityWindowInstance = new recActivityWindow(contiguousActivityWindowInstance)


 * [FixedPeriodLookbackActivityWindow](./FixedPeriodLookbackActivityWindow.md)

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
