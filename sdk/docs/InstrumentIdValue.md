# Lusid.Sdk.Model.InstrumentIdValue

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **string** | The value of the identifier. | 
**EffectiveAt** | **DateTimeOffset** | The effective datetime from which the identifier will be valid. If left unspecified the default value is the beginning of time. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string value = "value";

InstrumentIdValue instrumentIdValueInstance = new InstrumentIdValue(
    value: value,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
