# Lusid.Sdk.Model.UnattributedAmount
An amount on the income summary an allocation run could not attribute to any pool.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**GlCode** | **string** | The general ledger account the unattributed amount sits in. | 
**Amount** | **decimal** | The amount allocated to the partner. | 
**Reason** | **string** | Why the amount could not be attributed. | 

```csharp
using Lusid.Sdk.Model;
using System;

string glCode = "glCode";decimal amount = "amount";

string reason = "reason";

UnattributedAmount unattributedAmountInstance = new UnattributedAmount(
    glCode: glCode,
    amount: amount,
    reason: reason);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
