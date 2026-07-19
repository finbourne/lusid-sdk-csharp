# Lusid.Sdk.Model.ResolvedCustodianAccount

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountSelector** | **string** | Available values: From, To. | [optional] 
**CustodianAccount** | [**CustodianAccount**](CustodianAccount.md) |  | 
**ResolutionType** | **string** | Available values: BookingEntry, ContextCustodian, RelatedAccount, PortfolioDefault. | 

```csharp
using Lusid.Sdk.Model;
using System;

string accountSelector = "example accountSelector";
CustodianAccount custodianAccount = new CustodianAccount();
string resolutionType = "resolutionType";

ResolvedCustodianAccount resolvedCustodianAccountInstance = new ResolvedCustodianAccount(
    accountSelector: accountSelector,
    custodianAccount: custodianAccount,
    resolutionType: resolutionType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
