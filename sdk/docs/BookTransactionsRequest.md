# Lusid.Sdk.Model.BookTransactionsRequest

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AllocationIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | A collection of Allocation IDs | 
**TransactionProperties** | [**Dictionary&lt;string, PerpetualProperty&gt;**](PerpetualProperty.md) | A collection of properties | [optional] 
**FxInstrumentType** | **string** | The type of FX instrument to create when settlement currency differs from portfolio base currency. Use None to suppress FX instrument and order creation. Defaults to None. Available values: None, FxForward, FxSpot. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> allocationIds = new List<ResourceId>();
Dictionary<string, PerpetualProperty> transactionProperties = new Dictionary<string, PerpetualProperty>();
string fxInstrumentType = "example fxInstrumentType";

BookTransactionsRequest bookTransactionsRequestInstance = new BookTransactionsRequest(
    allocationIds: allocationIds,
    transactionProperties: transactionProperties,
    fxInstrumentType: fxInstrumentType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
