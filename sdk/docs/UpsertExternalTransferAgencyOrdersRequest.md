# Lusid.Sdk.Model.UpsertExternalTransferAgencyOrdersRequest
One dealing point's orders for one fund, as a third-party transfer agent sends them.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | 
**DealingPoint** | **DateTimeOffset** |  | 
**Source** | [**ExternalTransferAgencyOrderSource**](ExternalTransferAgencyOrderSource.md) |  | 
**Complete** | **bool** |  | [optional] 
**SentAt** | **DateTimeOffset?** |  | [optional] 
**Lines** | [**Dictionary&lt;string, ExternalTransferAgencyOrderLine&gt;**](ExternalTransferAgencyOrderLine.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId fundId = new ResourceId();
ExternalTransferAgencyOrderSource source = new ExternalTransferAgencyOrderSource();
bool complete = //"True";
Dictionary<string, ExternalTransferAgencyOrderLine> lines = new Dictionary<string, ExternalTransferAgencyOrderLine>();

UpsertExternalTransferAgencyOrdersRequest upsertExternalTransferAgencyOrdersRequestInstance = new UpsertExternalTransferAgencyOrdersRequest(
    fundId: fundId,
    dealingPoint: dealingPoint,
    source: source,
    complete: complete,
    sentAt: sentAt,
    lines: lines);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
