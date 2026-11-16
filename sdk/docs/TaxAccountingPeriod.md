# Lusid.Sdk.Model.TaxAccountingPeriod

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | The label of the period, for example the four-digit year. | [optional] 
**Start** | **DateTimeOffset** | The first day of the period, inclusive. | [optional] 
**End** | **DateTimeOffset** | The last day of the period, inclusive. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string label = "example label";

TaxAccountingPeriod taxAccountingPeriodInstance = new TaxAccountingPeriod(
    label: label,
    start: start,
    end: end);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
