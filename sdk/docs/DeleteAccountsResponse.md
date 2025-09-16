# Lusid.Sdk.Model.DeleteAccountsResponse
The delete accounts response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**AccountIds** | **List&lt;string&gt;** | The Accounts which have been soft/hard deleted. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelVersion? varVersion = new ModelVersion();

List<string> accountIds = new List<string>();
List<Link> links = new List<Link>();

DeleteAccountsResponse deleteAccountsResponseInstance = new DeleteAccountsResponse(
    varVersion: varVersion,
    accountIds: accountIds,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
