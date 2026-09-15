# Lusid.Sdk.Model.GetTransferResponse
A transfer and both of the transactions it booked.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransferId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TransferType** | **string** |  | [optional] 
**PortfolioIdOut** | [**ResourceId**](ResourceId.md) |  | [optional] 
**PortfolioIdIn** | [**ResourceId**](ResourceId.md) |  | [optional] 
**TransactionOut** | [**Transaction**](Transaction.md) |  | [optional] 
**TransactionIn** | [**Transaction**](Transaction.md) |  | [optional] 
**Properties** | [**Dictionary&lt;string, Property&gt;**](Property.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId? transferId = new ResourceId();

string transferType = "example transferType";
ResourceId? portfolioIdOut = new ResourceId();

ResourceId? portfolioIdIn = new ResourceId();

Transaction? transactionOut = new Transaction();

Transaction? transactionIn = new Transaction();

Dictionary<string, Property> properties = new Dictionary<string, Property>();

GetTransferResponse getTransferResponseInstance = new GetTransferResponse(
    transferId: transferId,
    transferType: transferType,
    portfolioIdOut: portfolioIdOut,
    portfolioIdIn: portfolioIdIn,
    transactionOut: transactionOut,
    transactionIn: transactionIn,
    properties: properties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
