# Lusid.Sdk.Model.CustodianAccountsUpsertResponse
The upsert accounts response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**CustodianAccounts** | [**List&lt;CustodianAccount&gt;**](CustodianAccount.md) | The Custodian Accounts which have been upserted. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ModelVersion? varVersion = new ModelVersion();

List<CustodianAccount> custodianAccounts = new List<CustodianAccount>();
List<Link> links = new List<Link>();

CustodianAccountsUpsertResponse custodianAccountsUpsertResponseInstance = new CustodianAccountsUpsertResponse(
    href: href,
    varVersion: varVersion,
    custodianAccounts: custodianAccounts,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
