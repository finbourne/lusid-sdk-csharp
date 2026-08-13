# Lusid.Sdk.Model.NoticeConvention
Defines the notice period by which a cancellation election must be made ahead of the  cancel effective date, else the option lapses.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Calendars** | **List&lt;string&gt;** | Holiday calendar code(s) used to resolve business days, required when the day type is Business. | [optional] 
**DayType** | **string** | Indicates whether the notice days are counted using business days or calendar days.                Supported string (enumeration) values are: [Business, Calendar]. Available values: Business, Calendar. | 
**NoticeDays** | **int** | The number of days prior to the cancel effective date by which the election must be made.                Defaults to 2 if not set. | [optional] [default to 2]

```csharp
using Lusid.Sdk.Model;
using System;

List<string> calendars = new List<string>();
string dayType = "dayType";

NoticeConvention noticeConventionInstance = new NoticeConvention(
    calendars: calendars,
    dayType: dayType,
    noticeDays: noticeDays);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
