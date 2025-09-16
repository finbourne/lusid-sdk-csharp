# Lusid.Sdk.Model.CalendarDependency
For indicating a dependency upon calendar codes

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**DependencyType** | **string** | The available values are: OpaqueDependency, CashDependency, DiscountingDependency, EquityCurveDependency, EquityVolDependency, FxDependency, FxForwardsDependency, FxVolDependency, IndexProjectionDependency, IrVolDependency, QuoteDependency, Vendor, CalendarDependency, InflationFixingDependency | 
**Calendars** | **List&lt;string&gt;** | The Codes of the calendars that are depended upon. | 

```csharp
using Lusid.Sdk.Model;
using System;

List<string> calendars = new List<string>();

CalendarDependency calendarDependencyInstance = new CalendarDependency(
    calendars: calendars);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
