# Lusid.Sdk.Model.CancelTransferAgencyTransactionRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**TransactionId** | **string** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
string transactionId = "transactionId";

CancelTransferAgencyTransactionRequest cancelTransferAgencyTransactionRequestInstance = new CancelTransferAgencyTransactionRequest(
    portfolioId: portfolioId,
    transactionId: transactionId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
