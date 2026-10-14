# Lusid.Sdk.Model.CashInterest
Interest accrued on posted cash.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Index** | **string** | The name of the rate index. | 
**SpreadBps** | **int** | The spread over the index, in basis points. | 

```csharp
using Lusid.Sdk.Model;
using System;

string index = "index";

CashInterest cashInterestInstance = new CashInterest(
    index: index,
    spreadBps: spreadBps);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
