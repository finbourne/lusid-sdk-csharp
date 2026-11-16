# Lusid.Sdk.Model.TaxReturnMemoRow

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Label** | **string** | The label of the period, for example the four-digit year. | [optional] 
**Amount** | **decimal** | The amount, in pounds. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string label = "example label";decimal? amount = "example amount";

TaxReturnMemoRow taxReturnMemoRowInstance = new TaxReturnMemoRow(
    label: label,
    amount: amount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
