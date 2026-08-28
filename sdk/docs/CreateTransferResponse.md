# Lusid.Sdk.Model.CreateTransferResponse
The transfer that was created, and the transaction legs it booked.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransferId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TransferType** | **string** |  | [optional] 
**PortfolioIdOut** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PortfolioIdIn** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TransactionIdOut** | **string** |  | [optional] 
**TransactionIdIn** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? transferId = new ResourceId();

string transferType = "example transferType";
ResourceId? portfolioIdOut = new ResourceId();

ResourceId? portfolioIdIn = new ResourceId();

string transactionIdOut = "example transactionIdOut";
string transactionIdIn = "example transactionIdIn";

CreateTransferResponse createTransferResponseInstance = new CreateTransferResponse(
    transferId: transferId,
    transferType: transferType,
    portfolioIdOut: portfolioIdOut,
    portfolioIdIn: portfolioIdIn,
    transactionIdOut: transactionIdOut,
    transactionIdIn: transactionIdIn);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
