# Lusid.Sdk.Model.ContiguousActivityWindow
The activity window for a running series of instances: each instance's window starts where the previous  instance's ended, so the series tiles the effective timeline with no gaps and no overlap. Requires the  definition's effectiveAtProgression to be Series.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InitialActivitySinceEffectiveAt** | [**RecActivitySinceEffectiveAt**](RecActivitySinceEffectiveAt.md) |  | 
**WindowType** | **string** | Polymorphic discriminator. Supported types: Contiguous. Contiguous requires effectiveAtProgression Series. Available values: Contiguous, FixedLookback, Explicit, ClosedPeriod, ContiguousAsAt. | 

```csharp
using Lusid.Sdk.Model;
using System;

RecActivitySinceEffectiveAt initialActivitySinceEffectiveAt = new RecActivitySinceEffectiveAt();
string windowType = "windowType";

ContiguousActivityWindow contiguousActivityWindowInstance = new ContiguousActivityWindow(
    initialActivitySinceEffectiveAt: initialActivitySinceEffectiveAt,
    windowType: windowType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
