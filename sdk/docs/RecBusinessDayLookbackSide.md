# Lusid.Sdk.Model.RecBusinessDayLookbackSide
One side of a FixedBusinessDayLookback activity window: how many business days the side reaches back, the time  zone the days are counted in, the holiday calendars that take days out of the count, and the local time the  since bound falls at.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**LookbackBusinessDays** | **int** | The number of business days before the effectiveAt&#39;s local date the window opens on, from 1 to 366. If the effectiveAt falls on a non-business day it counts from the most recent business day before it. | 
**VarTimeZone** | **string** | The IANA time zone (e.g. Europe/London, Asia/Hong_Kong) the effectiveAt is read in and the business days are counted in. The since bound is stamped in UTC. | 
**HolidayCalendars** | [**List&lt;ResourceId&gt;**](ResourceId.md) | Up to 5 holiday calendars whose dates are not business days, each by scope and code. A day that is a weekend or a holiday in any of them is skipped. With none, business days are Monday to Friday. Every calendar must exist when the definition is written and when a rec is instantiated. | [optional] 
**SinceTimeOfDay** | [**RecTimeOfDay**](RecTimeOfDay.md) |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string varTimeZone = "varTimeZone";
List<ResourceId> holidayCalendars = new List<ResourceId>();
RecTimeOfDay? sinceTimeOfDay = new RecTimeOfDay();


RecBusinessDayLookbackSide recBusinessDayLookbackSideInstance = new RecBusinessDayLookbackSide(
    lookbackBusinessDays: lookbackBusinessDays,
    varTimeZone: varTimeZone,
    holidayCalendars: holidayCalendars,
    sinceTimeOfDay: sinceTimeOfDay);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
