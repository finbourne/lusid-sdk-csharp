# Lusid.Sdk.Model.TransactionReconciliationRequest
Specifies the parameter to be use when performing a Transaction Reconciliation.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LeftPortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**RightPortfolioId** | [**ResourceId**](ResourceId.md) |  | 
**MappingId** | [**ResourceId**](ResourceId.md) |  | [optional] 
**FromTransactionDate** | **DateTimeOffset** |  | 
**ToTransactionDate** | **DateTimeOffset** |  | 
**AsAt** | **DateTimeOffset?** |  | [optional] 
**PropertyKeys** | **List&lt;string&gt;** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId leftPortfolioId = new ResourceId();
ResourceId rightPortfolioId = new ResourceId();
ResourceId? mappingId = new ResourceId();

List<string> propertyKeys = new List<string>();

TransactionReconciliationRequest transactionReconciliationRequestInstance = new TransactionReconciliationRequest(
    leftPortfolioId: leftPortfolioId,
    rightPortfolioId: rightPortfolioId,
    mappingId: mappingId,
    fromTransactionDate: fromTransactionDate,
    toTransactionDate: toTransactionDate,
    asAt: asAt,
    propertyKeys: propertyKeys);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
