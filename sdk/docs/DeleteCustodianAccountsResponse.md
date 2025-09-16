# Lusid.Sdk.Model.DeleteCustodianAccountsResponse
The delete custodian accounts response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**CustodianAccountIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The Custodian Accounts which have been soft/hard deleted. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelVersion? varVersion = new ModelVersion();

List<ResourceId> custodianAccountIds = new List<ResourceId>();
List<Link> links = new List<Link>();

DeleteCustodianAccountsResponse deleteCustodianAccountsResponseInstance = new DeleteCustodianAccountsResponse(
    varVersion: varVersion,
    custodianAccountIds: custodianAccountIds,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
