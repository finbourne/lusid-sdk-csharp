# Lusid.Sdk.Model.SweepBlocksRequest
A request to sweep specified blocks.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BlockIds** | [**List&lt;ResourceId&gt;**](ResourceId.md) | The identifiers of the blocks to sweep. | 
**LatestAllowableModificationTime** | **string** | Timestamp, cut label or tenor. A block can only be swept if none of its executions or allocations were modified after this time. A tenor is relative to the current time, for example &#39;1D&#39; means one day ago. A business day tenor, for example &#39;1BD&#39;, requires calendarId. A tenor cannot go back further than 1 January 1900. For more information on tenors, see [Specifying tenors in LUSID](https://support.lusid.com/docs/specifying-tenors-in-lusid) | 
**CalendarId** | [**ResourceId**](ResourceId.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> blockIds = new List<ResourceId>();
string latestAllowableModificationTime = "latestAllowableModificationTime";
ResourceId? calendarId = new ResourceId();


SweepBlocksRequest sweepBlocksRequestInstance = new SweepBlocksRequest(
    blockIds: blockIds,
    latestAllowableModificationTime: latestAllowableModificationTime,
    calendarId: calendarId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
