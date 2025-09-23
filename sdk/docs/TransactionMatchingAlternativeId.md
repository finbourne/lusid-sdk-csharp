# Lusid.Sdk.Model.TransactionMatchingAlternativeId

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PropertyKey** | **string** | An property key (from the &#39;Transaction&#39; domain) that can be used as an alternative to TransactionId when matching transactions to settlement instructions. This property must be pre-defined and must be present on the transaction in order to be used for matching. | 

```csharp
using Lusid.Sdk.Model;
using System;

string propertyKey = "propertyKey";

TransactionMatchingAlternativeId transactionMatchingAlternativeIdInstance = new TransactionMatchingAlternativeId(
    propertyKey: propertyKey);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
