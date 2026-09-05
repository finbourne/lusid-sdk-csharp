# Lusid.Sdk.Model.TransferAgencyOrderToEstimate
The values of an order to estimate, for an order that has not been saved yet or whose values are being  changed. Carries only what the estimate reads - it is not a whole order and cannot be used to create one.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**InstrumentIdentifierType** | **string** |  | 
**InstrumentIdentifier** | **string** |  | 
**InstrumentScope** | **string** |  | [optional] 
**TransactionCategory** | **string** | Available values: Subscription, Redemption, SwitchOut, SwitchIn, TransferOut, TransferIn. | [optional] 
**Currency** | **string** |  | 
**Quantity** | **decimal?** |  | [optional] 
**Amount** | **decimal?** |  | [optional] 
**Weight** | **decimal?** |  | [optional] 
**TransactionDate** | **DateTimeOffset?** |  | [optional] 
**ExchangeRate** | **decimal?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId portfolioId = new ResourceId();
string instrumentIdentifierType = "instrumentIdentifierType";
string instrumentIdentifier = "instrumentIdentifier";
string instrumentScope = "example instrumentScope";
string transactionCategory = "example transactionCategory";
string currency = "currency";

TransferAgencyOrderToEstimate transferAgencyOrderToEstimateInstance = new TransferAgencyOrderToEstimate(
    portfolioId: portfolioId,
    instrumentIdentifierType: instrumentIdentifierType,
    instrumentIdentifier: instrumentIdentifier,
    instrumentScope: instrumentScope,
    transactionCategory: transactionCategory,
    currency: currency,
    quantity: quantity,
    amount: amount,
    weight: weight,
    transactionDate: transactionDate,
    exchangeRate: exchangeRate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
