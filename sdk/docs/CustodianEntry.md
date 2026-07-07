# Lusid.Sdk.Model.CustodianEntry

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AccountId** | [**ResourceId**](ResourceId.md) |  | 
**AccountSelector** | **string** | Available values: From, To. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId accountId = new ResourceId();
string accountSelector = "example accountSelector";

CustodianEntry custodianEntryInstance = new CustodianEntry(
    accountId: accountId,
    accountSelector: accountSelector);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
