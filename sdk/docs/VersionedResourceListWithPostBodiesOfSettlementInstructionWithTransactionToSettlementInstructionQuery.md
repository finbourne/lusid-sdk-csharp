# Lusid.Sdk.Model.VersionedResourceListWithPostBodiesOfSettlementInstructionWithTransactionToSettlementInstructionQuery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**VarVersion** | [**ModelVersion**](ModelVersion.md) |  | 
**Values** | [**List&lt;SettlementInstructionWithTransaction&gt;**](SettlementInstructionWithTransaction.md) | The resources to list. | 
**Href** | **string** | The URI of the resource list. | [optional] 
**PostBody** | [**SettlementInstructionQuery**](SettlementInstructionQuery.md) |  | [optional] 
**NextPage** | [**SettlementInstructionQuery**](SettlementInstructionQuery.md) |  | [optional] 
**PreviousPage** | [**SettlementInstructionQuery**](SettlementInstructionQuery.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ModelVersion varVersion = new ModelVersion();
List<SettlementInstructionWithTransaction> values = new List<SettlementInstructionWithTransaction>();
string href = "example href";
SettlementInstructionQuery? postBody = new SettlementInstructionQuery();

SettlementInstructionQuery? nextPage = new SettlementInstructionQuery();

SettlementInstructionQuery? previousPage = new SettlementInstructionQuery();

List<Link> links = new List<Link>();

VersionedResourceListWithPostBodiesOfSettlementInstructionWithTransactionToSettlementInstructionQuery versionedResourceListWithPostBodiesOfSettlementInstructionWithTransactionToSettlementInstructionQueryInstance = new VersionedResourceListWithPostBodiesOfSettlementInstructionWithTransactionToSettlementInstructionQuery(
    varVersion: varVersion,
    values: values,
    href: href,
    postBody: postBody,
    nextPage: nextPage,
    previousPage: previousPage,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
