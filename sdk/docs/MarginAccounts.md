# Lusid.Sdk.Model.MarginAccounts
The custodian account each party's collateral is held in.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WePost** | **string** | The code of the custodian account, within each applicable portfolio, that holds collateral we post. Empty means collateral we post is not held in a custodian account the item knows of. | [optional] 
**TheyPost** | **string** | The code of the custodian account, within each applicable portfolio, that holds collateral the counterparty posts. Empty means collateral they post is not held in a custodian account the item knows of. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string wePost = "example wePost";
string theyPost = "example theyPost";

MarginAccounts marginAccountsInstance = new MarginAccounts(
    wePost: wePost,
    theyPost: theyPost);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
