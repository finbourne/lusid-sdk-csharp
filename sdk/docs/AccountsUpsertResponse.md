# Lusid.Sdk.Model.AccountsUpsertResponse
The upsert accounts response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Accounts** | [**List&lt;Account&gt;**](Account.md) | The Accounts which have been upserted. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<Account> accounts = new List<Account>();
List<Link> links = new List<Link>();

AccountsUpsertResponse accountsUpsertResponseInstance = new AccountsUpsertResponse(
    href: href,
    varVersion: varVersion,
    accounts: accounts,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
