# Lusid.Sdk.Model.BookTransactionsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllocationIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | A collection of Allocation IDs | 
**TransactionProperties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | A collection of properties | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> allocationIds = new List<ResourceId>();
Dictionary<string, PerpetualProperty> transactionProperties = new Dictionary<string, PerpetualProperty>();

BookTransactionsRequest bookTransactionsRequestInstance = new BookTransactionsRequest(
    allocationIds: allocationIds,
    transactionProperties: transactionProperties);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
