# Lusid.Sdk.Model.PartnerStatementLine
One figure on a partner statement.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Key** | **string** | The key of the figure. | 
**Label** | **string** | The label of the figure. | 
**Amount** | **decimal** | The amount of the figure. | 

```csharp
using Lusid.Sdk.Model;
using System;

string key = "key";
string label = "label";decimal amount = "amount";


PartnerStatementLine partnerStatementLineInstance = new PartnerStatementLine(
    key: key,
    label: label,
    amount: amount);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
