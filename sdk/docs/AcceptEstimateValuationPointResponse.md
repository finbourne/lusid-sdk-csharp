# Lusid.Sdk.Model.AcceptEstimateValuationPointResponse
The Valuation Point Data Response for AcceptEstimate called on the Fund and specified date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Href** | **string** | The specific Uniform Resource Identifier (URI) for this resource at the requested effective and asAt datetime. | [optional] 
**CandidateValuationPoint** | [**ValuationPointDataResponse**](ValuationPointDataResponse.md) |  | 
**LatestValuationPoint** | [**ValuationPointDataResponse**](ValuationPointDataResponse.md) |  | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string href = "example href";
ValuationPointDataResponse candidateValuationPoint = new ValuationPointDataResponse();
ValuationPointDataResponse? latestValuationPoint = new ValuationPointDataResponse();

List<Link> links = new List<Link>();

AcceptEstimateValuationPointResponse acceptEstimateValuationPointResponseInstance = new AcceptEstimateValuationPointResponse(
    href: href,
    candidateValuationPoint: candidateValuationPoint,
    latestValuationPoint: latestValuationPoint,
    links: links);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
