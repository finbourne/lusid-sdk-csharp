# Lusid.Sdk.Model.CommodityCalendarSchedule
Schedule describing the periodic calendar-average settlement periods of a commodity calendar swap.  Each period settles in cash against the average of the observed commodity price over the period.  The schedule is currently stored and validated only; period expansion is not yet implemented.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScheduleType** | **string** | Available values: FixedSchedule, FloatSchedule, OptionalitySchedule, StepSchedule, Exercise, FxRateSchedule, FxLinkedNotionalSchedule, BondConversionSchedule, PikSchedule, CommodityCalendarSchedule, Invalid, CancelSchedule. | 
**StartDate** | **DateTimeOffset** | The date from which the first settlement period accrues. | [optional] 
**MaturityDate** | **DateTimeOffset** | The date on which the final settlement period ends. | [optional] 
**FlowConventions** | [**FlowConventions**](FlowConventions.md) |  | [optional] 
**PaymentCurrency** | **string** | The currency in which each periodic cash settlement is paid. | [optional] 
**StubType** | **string** | How any non-integral first or last period is handled when generating the settlement periods.  If not specified, this defaults to None.                Supported string (enumeration) values are: [ShortFront, ShortBack, LongBack, LongFront, Both]. Available values: None, ShortFront, ShortBack, LongBack, LongFront, Both, Invalid. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

FlowConventions? flowConventions = new FlowConventions();

string paymentCurrency = "example paymentCurrency";
string stubType = "example stubType";

CommodityCalendarSchedule commodityCalendarScheduleInstance = new CommodityCalendarSchedule(
    startDate: startDate,
    maturityDate: maturityDate,
    flowConventions: flowConventions,
    paymentCurrency: paymentCurrency,
    stubType: stubType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
