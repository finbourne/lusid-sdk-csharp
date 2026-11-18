# Lusid.Sdk.Model.ReactivatedNavTypesResponse
The response from reactivating NAV types on a fund. Contains the updated fund and, for each  reactivated follower, the number of valuation points finalised while the follower was dormant.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**Fund** | [**Fund**](Fund.md) |  | 
**CatchUpCounts** | [**List&lt;NavTypeCatchUp&gt;**](NavTypeCatchUp.md) | For each reactivated follower, the number of valuation points the leader finalised while the follower was dormant. Leaders are not included (they have no catch-up). | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
Fund fund = new Fund();
List<NavTypeCatchUp> catchUpCounts = new List<NavTypeCatchUp>();
List<Link> links = new List<Link>();

ReactivatedNavTypesResponse reactivatedNavTypesResponseInstance = new ReactivatedNavTypesResponse(
    href: href,
    fund: fund,
    catchUpCounts: catchUpCounts,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
