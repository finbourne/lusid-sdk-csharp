# Lusid.Sdk.Model.TaxExceptionItem

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | An identifier stable within a response, built from the category, portfolio and instrument. | 
**Category** | **string** | The kind of exception: UnmatchedDisposal, NegativePool, MissingValuation or UnclassifiedInstrument. | 
**Severity** | **string** | Error when the exception blocks the tax computation, Warning when it casts doubt on it. | 
**Portfolio** | [**ResourceId**](ResourceId.md) |  | 
**Instrument** | **string** | The LUSID unique identifier of the instrument the exception was raised against. | [optional] 
**Message** | **string** | A description of the exception. | 
**RaisedAt** | **DateTimeOffset** | The asAt the exception was observed at. | 
**TaxAtStake** | **decimal?** | The tax effect, in the Fund&#39;s base currency, of the position or gain the exception blocks, at the Fund&#39;s configured rate. Absent when the rate or the exposure is not known. | [optional] 
**RootCause** | [**TaxExceptionRootCause**](TaxExceptionRootCause.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "id";
string category = "category";
string severity = "severity";
ResourceId portfolio = new ResourceId();
string instrument = "example instrument";
string message = "message";
TaxExceptionRootCause? rootCause = new TaxExceptionRootCause();


TaxExceptionItem taxExceptionItemInstance = new TaxExceptionItem(
    id: id,
    category: category,
    severity: severity,
    portfolio: portfolio,
    instrument: instrument,
    message: message,
    raisedAt: raisedAt,
    taxAtStake: taxAtStake,
    rootCause: rootCause);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
