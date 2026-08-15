# Lusid.Sdk.Model.CancelSchedule
Cancel schedule represents the embedded option on a cancellable swap, allowing one party to  terminate the swap on one or more predefined dates.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleType** | **string** | Available values: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, PikSchedule, CommodityCalendarSchedule, Invalid, CancelSchedule. | 
**CancelDates** | **List&lt;DateTimeOffset&gt;** | The dates on which cancellation may be elected. | 
**CancelType** | **string** | The type of cancellation option: European (single cancel date) or Bermudan (two or more).                Supported string (enumeration) values are: [European, Bermudan]. Available values: European, Bermudan. | 
**NoticeConvention** | [**NoticeConvention**](NoticeConvention.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

List<DateTimeOffset> cancelDates = new List<DateTimeOffset>();
string cancelType = "cancelType";
NoticeConvention noticeConvention = new NoticeConvention();

CancelSchedule cancelScheduleInstance = new CancelSchedule(
    cancelDates: cancelDates,
    cancelType: cancelType,
    noticeConvention: noticeConvention);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
