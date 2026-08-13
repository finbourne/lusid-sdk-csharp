# Lusid.Sdk.Model.ResetSchedule
The schedule on which the price return of the asset leg of a total return swap is observed and exchanged.  Each reset period pays the change in the asset's price over the period, sourced from quoted market data.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Conventions** | [**FlowConventions**](FlowConventions.md) |  | [optional] 
**FirstResetDate** | **DateTimeOffset?** | The date of the first price reset. Optional; when absent the reset dates are rolled forward from the swap start date. | [optional] 
**Frequency** | **string** | The frequency at which the asset price is reset and the price return is exchanged, e.g. 3M. | 
**LastResetDate** | **DateTimeOffset?** | The date of the last price reset. Optional; when absent the reset dates are rolled forward until the swap maturity date. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

FlowConventions? conventions = new FlowConventions();

string frequency = "frequency";

ResetSchedule resetScheduleInstance = new ResetSchedule(
    conventions: conventions,
    firstResetDate: firstResetDate,
    frequency: frequency,
    lastResetDate: lastResetDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
