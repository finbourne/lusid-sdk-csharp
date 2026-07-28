# Lusid.Sdk.Model.PaymentRecordReference
Identifies a Payment Record attached to a specific transaction within a portfolio.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**TransactionId** | **string** | The ID of the cash transaction within the portfolio to which the Payment Record is attached. | 
**PaymentRecordId** | **string** | The unique identifier of the Payment Record attached to the above transaction. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
string transactionId = "transactionId";
string paymentRecordId = "paymentRecordId";

PaymentRecordReference paymentRecordReferenceInstance = new PaymentRecordReference(
    portfolioId: portfolioId,
    transactionId: transactionId,
    paymentRecordId: paymentRecordId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
