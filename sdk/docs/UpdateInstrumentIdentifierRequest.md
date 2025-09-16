# Lusid.Sdk.Model.UpdateInstrumentIdentifierRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The allowable instrument identifier to update, insert or remove e.g. &#39;Figi&#39;. | 
**Value** | **string** | The new value of the allowable instrument identifier. If unspecified the identifier will be removed from the instrument. | [optional] 
**EffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The effective datetime from which the identifier should be updated, inserted or removed. Defaults to the current LUSID system datetime if not specified. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";
string value = "example value";
DateTimeOrCutLabel effectiveAt = "example effectiveAt";

UpdateInstrumentIdentifierRequest updateInstrumentIdentifierRequestInstance = new UpdateInstrumentIdentifierRequest(
    type: type,
    value: value,
    effectiveAt: effectiveAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
