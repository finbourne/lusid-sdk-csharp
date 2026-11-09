# Lusid.Sdk.Model.TaxClassificationExceptionRecord
An instrument the engine could not classify, or a qualifying-investments flip, for the exceptions feed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Luid** | **string** | The LUSID instrument identifier of the instrument the exception was raised for. | 
**InstrumentName** | **string** | The name of the instrument the exception was raised for. | [optional] 
**Exception** | [**TaxClassificationException**](TaxClassificationException.md) |  | 
**EffectiveAt** | **DateTimeOffset** | The effective date the exception was observed at. | 
**AsAt** | **DateTimeOffset** | The asAt time the exception was observed at. | 

```csharp
using Lusid.Sdk.Model;
using System;

string luid = "luid";
string instrumentName = "example instrumentName";
TaxClassificationException exception = new TaxClassificationException();

TaxClassificationExceptionRecord taxClassificationExceptionRecordInstance = new TaxClassificationExceptionRecord(
    luid: luid,
    instrumentName: instrumentName,
    exception: exception,
    effectiveAt: effectiveAt,
    asAt: asAt);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
