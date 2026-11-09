# Lusid.Sdk.Model.TaxClassificationFieldVersion
One stored value of a classification input or override and the bitemporal window it held for.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Field** | **string** | The name of the classification input or override the version belongs to. | 
**Value** | **string** | The value of the field over the version&#39;s effective and asAt window. | [optional] 
**EffectiveFrom** | **DateTimeOffset** | The start of the effective window the value applies from. | 
**EffectiveUntil** | **DateTimeOffset** | The end of the effective window the value applies until. | 
**AsAtFrom** | **DateTimeOffset** | The asAt time the value was recorded. | 
**AsAtUntil** | **DateTimeOffset?** | The asAt time the value was superseded, if it has been. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string field = "field";
string value = "example value";

TaxClassificationFieldVersion taxClassificationFieldVersionInstance = new TaxClassificationFieldVersion(
    field: field,
    value: value,
    effectiveFrom: effectiveFrom,
    effectiveUntil: effectiveUntil,
    asAtFrom: asAtFrom,
    asAtUntil: asAtUntil);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
