# Lusid.Sdk.Model.BookTransactionsResponse

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**Dictionary&lt;string, Transaction&gt;**](Transaction.md) |  | [optional] 
**Failed** | [**Dictionary&lt;string, ErrorDetail&gt;**](ErrorDetail.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, Transaction> values = new Dictionary<string, Transaction>();
Dictionary<string, ErrorDetail> failed = new Dictionary<string, ErrorDetail>();

BookTransactionsResponse bookTransactionsResponseInstance = new BookTransactionsResponse(
    values: values,
    failed: failed);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
