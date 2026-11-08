# Lusid.Sdk.Model.FundTaxExceptionItem
A tax exception row seen across funds, so the fund and the owning life-company entity travel with it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarClient** | [**ResourceId**](ResourceId.md) |  | [optional] 
**Fund** | [**ResourceId**](ResourceId.md) |  | 
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

ResourceId? varClient = new ResourceId();

ResourceId fund = new ResourceId();
string id = "id";
string category = "category";
string severity = "severity";
ResourceId portfolio = new ResourceId();
string instrument = "example instrument";
string message = "message";
TaxExceptionRootCause? rootCause = new TaxExceptionRootCause();


FundTaxExceptionItem fundTaxExceptionItemInstance = new FundTaxExceptionItem(
    varClient: varClient,
    fund: fund,
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
