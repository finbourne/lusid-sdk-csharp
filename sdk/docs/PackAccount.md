# Lusid.Sdk.Model.PackAccount
An account on a partnership configuration pack's chart of accounts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Code** | **string** | The account code. | 
**Name** | **string** | The account name. | 
**Type** | **string** | The account type: Asset, Liability, Capital, Income or Expense. | 

```csharp
using Lusid.Sdk.Model;
using System;

string code = "code";
string name = "name";
string type = "type";

PackAccount packAccountInstance = new PackAccount(
    code: code,
    name: name,
    type: type);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
