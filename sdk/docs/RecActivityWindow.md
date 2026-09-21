# Lusid.Sdk.Model.RecActivityWindow
Base class for the activity windows that give the date range a rec definition's activity-based  reconciliations cover. Polymorphic by windowType; each supported type has a corresponding inherited class.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WindowType** | **string** | Polymorphic discriminator. Supported types: Contiguous. Contiguous requires effectiveAtProgression Series. Available values: Contiguous, FixedLookback, Explicit, ClosedPeriod, ContiguousAsAt. | 
**InitialActivitySinceEffectiveAt** | [**RecActivitySinceEffectiveAt**](RecActivitySinceEffectiveAt.md) |  | 

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



[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
