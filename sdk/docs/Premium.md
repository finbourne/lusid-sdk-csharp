# Lusid.Sdk.Model.Premium
A class containing information for a given premium payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Amount** | **decimal** | Premium amount. | 
**Currency** | **string** | Premium currency. | 
**Date** | **DateTimeOffset** | Date when premium paid. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal amount = "amount";

string currency = "currency";

Premium premiumInstance = new Premium(
    amount: amount,
    currency: currency,
    date: date);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
