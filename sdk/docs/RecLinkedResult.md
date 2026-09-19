# Lusid.Sdk.Model.RecLinkedResult
A rec result of a different rec type in the same rec instance whose items share an identifier with this  result's items, and the keys that established the link. Links are symmetric: the linked result carries one back.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The id of the linked result, as carried in that result&#39;s own id field. | 
**RecType** | **string** | The rec type of the linked result. Always differs from this result&#39;s rec type. Available values: Holding, CashHolding, Valuation, InputTransaction, OutputTransaction, SettlementActivity. | 
**LinkedBy** | [**RecLinkedBy**](RecLinkedBy.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

string id = "id";
string recType = "recType";
RecLinkedBy linkedBy = new RecLinkedBy();

RecLinkedResult recLinkedResultInstance = new RecLinkedResult(
    id: id,
    recType: recType,
    linkedBy: linkedBy);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
