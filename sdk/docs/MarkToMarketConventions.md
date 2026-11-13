# Lusid.Sdk.Model.MarkToMarketConventions
A set of conventions for mark to market. Mark to market is a method   that values financial instruments based on current market prices,   reflecting their current value, rather than historical cost.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**CalendarCode** | **string** | The calendar to use when generating mark to market cashflows and events. | [optional] 
**HourOffsetTenor** | **string** | The hour tenor component of the time offset against the maturity date.  This is an optional field, if a value is provided it must be a positive value between &#39;0hour&#39; and &#39;23hour&#39;. | [optional] 
**MinuteOffsetTenor** | **string** | The minute tenor component of the time offset against the maturity date.  This is an optional field, if a value is provided it must be a positive value between &#39;0min&#39; and &#39;59min&#39;. | [optional] 
**MtmSettleDays** | **int?** | The number of business days after each mark to market date on which its variation margin is paid.  This is an optional field, defaulting to 0 (paid on the mark to market date); if a value is provided it must be between 0 and 10 inclusive. | [optional] 
**MtmSettlementCalendar** | **string** | The calendar the mark to market settlement days are counted on.  This is an optional field; if no value is provided the mark to market calendar is used, and without that only weekends are non-business days. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string calendarCode = "example calendarCode";
string hourOffsetTenor = "example hourOffsetTenor";
string minuteOffsetTenor = "example minuteOffsetTenor";
string mtmSettlementCalendar = "example mtmSettlementCalendar";

MarkToMarketConventions markToMarketConventionsInstance = new MarkToMarketConventions(
    calendarCode: calendarCode,
    hourOffsetTenor: hourOffsetTenor,
    minuteOffsetTenor: minuteOffsetTenor,
    mtmSettleDays: mtmSettleDays,
    mtmSettlementCalendar: mtmSettlementCalendar);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
