# Lusid.Sdk.Model.WeekendMask

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Days** | [**List&lt;DayOfWeek&gt;**](DayOfWeek.md) |  | 
**VarTimeZone** | **string** |  | 

```csharp
using Lusid.Sdk.Model;
using System;

List<DayOfWeek> days = new List<DayOfWeek>();
string varTimeZone = "varTimeZone";

WeekendMask weekendMaskInstance = new WeekendMask(
    days: days,
    varTimeZone: varTimeZone);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
