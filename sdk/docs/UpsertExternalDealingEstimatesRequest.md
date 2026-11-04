# Lusid.Sdk.Model.UpsertExternalDealingEstimatesRequest
One dealing point's dealing estimates for the fund named in the route, as a third-party transfer agent sends them.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DealingPoint** | **DateTimeOffset** |  | 
**Source** | [**ExternalDealingEstimateSource**](ExternalDealingEstimateSource.md) |  | 
**Complete** | **bool** |  | [optional] 
**SentAt** | **DateTimeOffset?** |  | [optional] 
**Lines** | [**Dictionary&lt;string, ExternalDealingEstimateLine&gt;**](ExternalDealingEstimateLine.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ExternalDealingEstimateSource source = new ExternalDealingEstimateSource();
bool complete = //"True";
Dictionary<string, ExternalDealingEstimateLine> lines = new Dictionary<string, ExternalDealingEstimateLine>();

UpsertExternalDealingEstimatesRequest upsertExternalDealingEstimatesRequestInstance = new UpsertExternalDealingEstimatesRequest(
    dealingPoint: dealingPoint,
    source: source,
    complete: complete,
    sentAt: sentAt,
    lines: lines);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
