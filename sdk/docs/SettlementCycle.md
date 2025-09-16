# Lusid.Sdk.Model.SettlementCycle
The settlement cycle for an instrument

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**BusinessDayOffset** | **int** |  | 
**Calendars** | [**List&lt;ResourceId&gt;**](ResourceId.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;

List<ResourceId> calendars = new List<ResourceId>();

SettlementCycle settlementCycleInstance = new SettlementCycle(
    businessDayOffset: businessDayOffset,
    calendars: calendars);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
