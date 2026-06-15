# Lusid.Sdk.Model.ResourceListWithPostBodiesOfSettlementActivityToSettlementActivityQuery
A version of the resource list for use with list endpoints that use the POST verb instead of GET, allowing  the endpoint to return the POST body(s) that can be sent in conjunction with the Next Page and/or Previous  Page links to retrieve the next/previous page of results. This should make it easier for SDK consumers to  fluently page through results. The PagedResourceList only exposes a page token string, typically for use in  a query parameter, and thus is more suited to GET endpoints.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Values** | [**List&lt;SettlementActivity&gt;**](SettlementActivity.md) | The resources to list. | 
**Href** | **string** | The URI of the resource list. | [optional] 
**PostBody** | [**SettlementActivityQuery**](SettlementActivityQuery.md) |  | [optional] 
**NextPage** | [**SettlementActivityQuery**](SettlementActivityQuery.md) |  | [optional] 
**PreviousPage** | [**SettlementActivityQuery**](SettlementActivityQuery.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<SettlementActivity> values = new List<SettlementActivity>();
string href = "example href";
SettlementActivityQuery? postBody = new SettlementActivityQuery();

SettlementActivityQuery? nextPage = new SettlementActivityQuery();

SettlementActivityQuery? previousPage = new SettlementActivityQuery();

List<Link> links = new List<Link>();

ResourceListWithPostBodiesOfSettlementActivityToSettlementActivityQuery resourceListWithPostBodiesOfSettlementActivityToSettlementActivityQueryInstance = new ResourceListWithPostBodiesOfSettlementActivityToSettlementActivityQuery(
    values: values,
    href: href,
    postBody: postBody,
    nextPage: nextPage,
    previousPage: previousPage,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
