# Lusid.Sdk.Model.ProcessingGroupSchedule
Specification of the dates on which a Processing Group is executed: a date range plus  tenor / roll / business-day conventions and holiday calendars that generate the schedule,  or an explicit override set of dates. Modelled on the valuation schedule shape, without the  bitemporal timeline fields.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveFrom** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The start of the date range over which the schedule is generated. | [optional] 
**EffectiveAt** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) | The end of the date range over which the schedule is generated. | [optional] 
**Tenor** | **string** | Tenor, e.g. \&quot;1D\&quot;, \&quot;1M\&quot;, used to generate the date schedule between EffectiveFrom and EffectiveAt. | [optional] 
**RollConvention** | **string** | When Tenor is \&quot;1M\&quot; or longer, the rule used to generate the date schedule, e.g. \&quot;EndOfMonth\&quot; or \&quot;1\&quot;. | [optional] 
**HolidayCalendars** | **List&lt;string&gt;** | The holiday calendar(s), by name, used when determining business days for the schedule. | [optional] 
**ScheduleDates** | **List&lt;string&gt;** | If given, the exact set of dates on which to execute. Overrides the generated schedule. | [optional] 
**BusinessDayConvention** | **string** | When Tenor is not \&quot;1D\&quot;, the convention (e.g. \&quot;MF\&quot;) used to roll dates that land on non-business days. | [optional] 
**VarTimeZone** | **string** | The IANA approved time zone (tzdb id, e.g. \&quot;Europe/London\&quot;) the schedule is expressed in.  Informational for consumers of the schedule: the generated schedule dates are calendar dates  and are not adjusted by this time zone. Optional. | [optional] 
**BusinessDayOffset** | **int?** | If given, the number of good business days (per the holiday calendars) added to each generated  date. Can be negative. For example, the 10th business day of each month is a \&quot;1M\&quot; tenor with an  \&quot;EndOfMonth\&quot; roll convention and a business day offset of 10. Cannot be combined with ScheduleDates. | [optional] 
**DateExceptions** | **List&lt;string&gt;** | Dates, in yyyy-MM-dd format, on which the Processing Group does not run. These are removed  from the generated schedule after all other conventions and offsets have been applied. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateTimeOrCutLabel effectiveFrom = "example effectiveFrom";
DateTimeOrCutLabel effectiveAt = "example effectiveAt";
string tenor = "example tenor";
string rollConvention = "example rollConvention";
List<string> holidayCalendars = new List<string>();
List<string> scheduleDates = new List<string>();
string businessDayConvention = "example businessDayConvention";
string varTimeZone = "example varTimeZone";
List<string> dateExceptions = new List<string>();

ProcessingGroupSchedule processingGroupScheduleInstance = new ProcessingGroupSchedule(
    effectiveFrom: effectiveFrom,
    effectiveAt: effectiveAt,
    tenor: tenor,
    rollConvention: rollConvention,
    holidayCalendars: holidayCalendars,
    scheduleDates: scheduleDates,
    businessDayConvention: businessDayConvention,
    varTimeZone: varTimeZone,
    businessDayOffset: businessDayOffset,
    dateExceptions: dateExceptions);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
