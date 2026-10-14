# Lusid.Sdk.Model.AllocationEventNoticeEvent
The allocation event a notice is issued for.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**Type** | **string** | The type of the allocation event. | 
**EventDate** | **DateTimeOffset** | The effective date of the allocation event. | 
**NoticeDate** | **DateTimeOffset?** | The date the notice is issued. | [optional] 
**DueDate** | **DateTimeOffset?** | The date the payment is due. | [optional] 
**Status** | **string** | The status of the allocation event. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId id = new ResourceId();
string type = "type";
string status = "status";

AllocationEventNoticeEvent allocationEventNoticeEventInstance = new AllocationEventNoticeEvent(
    id: id,
    type: type,
    eventDate: eventDate,
    noticeDate: noticeDate,
    dueDate: dueDate,
    status: status);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
