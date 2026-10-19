# Lusid.Sdk.Model.RecDefCurrencies

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Left** | **string** | The currency used on the left side of the reconciliation. Required when the left side has portfolio sources; must be null when it draws on relational data. | [optional] 
**Right** | **string** | The currency used on the right side of the reconciliation. Required when the right side has portfolio sources; must be null when it draws on relational data. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string left = "example left";
string right = "example right";

RecDefCurrencies recDefCurrenciesInstance = new RecDefCurrencies(
    left: left,
    right: right);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
