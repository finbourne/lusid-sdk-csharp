# Lusid.Sdk.Model.RecTimeOfDay
A local time of day to the minute, read in the time zone of the side that names it.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Hours** | **int** | The hour of the day, 0 to 23. | 
**Minutes** | **int** | The minute of the hour, 0 to 59. | 

```csharp
using Lusid.Sdk.Model;
using System;


RecTimeOfDay recTimeOfDayInstance = new RecTimeOfDay(
    hours: hours,
    minutes: minutes);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
