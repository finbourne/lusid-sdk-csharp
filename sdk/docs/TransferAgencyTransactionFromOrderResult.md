# Lusid.Sdk.Model.TransferAgencyTransactionFromOrderResult

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**OrderId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**SecurityTransactionId** | **string** |  | [optional] 
**AmendedCashTransactionId** | **string** |  | [optional] 
**Price** | **decimal** |  | [optional] 
**Units** | **decimal** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? orderId = new ResourceId();

string securityTransactionId = "example securityTransactionId";
string amendedCashTransactionId = "example amendedCashTransactionId";decimal? price = "example price";decimal? units = "example units";

TransferAgencyTransactionFromOrderResult transferAgencyTransactionFromOrderResultInstance = new TransferAgencyTransactionFromOrderResult(
    orderId: orderId,
    securityTransactionId: securityTransactionId,
    amendedCashTransactionId: amendedCashTransactionId,
    price: price,
    units: units);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
