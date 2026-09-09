# Lusid.Sdk.Model.CurrencyGroupMinorUnit
A minor unit currency within a currency group.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Currency** | **string** | The three-letter, case-sensitive currency code of the minor unit, e.g. GBX. | 
**FractionOfMajor** | **decimal** | The fraction of the major unit that one minor unit is worth, greater than zero and no more than one, e.g. 0.01 for GBX against GBP. | 

```csharp
using Lusid.Sdk.Model;
using System;

string currency = "currency";decimal fractionOfMajor = "fractionOfMajor";


CurrencyGroupMinorUnit currencyGroupMinorUnitInstance = new CurrencyGroupMinorUnit(
    currency: currency,
    fractionOfMajor: fractionOfMajor);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
