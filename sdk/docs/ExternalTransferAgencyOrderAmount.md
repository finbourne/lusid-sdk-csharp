# Lusid.Sdk.Model.ExternalTransferAgencyOrderAmount
A cash amount in a stated currency.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Value** | **decimal** |  | 
**Currency** | **string** |  | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal value = "value";

string currency = "currency";

ExternalTransferAgencyOrderAmount externalTransferAgencyOrderAmountInstance = new ExternalTransferAgencyOrderAmount(
    value: value,
    currency: currency);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
