# Lusid.Sdk.Model.SeriesBreakdown
The valuation of one series within a share class at a valuation point.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SeriesIdentifier** | **string** | The identifier of the series within its share class. | 
**Units** | **decimal** | The units in issue in the series at the valuation point. | 
**Nav** | **decimal** | The series&#39; share of the share class NAV, in the fund currency. | 
**NavPerUnit** | **decimal** | The series NAV per unit in the share class currency, rounded as the share class unit price is. | 
**CapitalRatio** | **decimal** | The series&#39; opening NAV as a proportion of the share class&#39;s opening NAV. Zero for a series with no units; sums to 1 across the series that hold units. | 
**Pnl** | **decimal** | The P&amp;L apportioned to the series in the period: its NAV less its opening NAV. | 
**PreviousNav** | **decimal** | The series NAV at the previous valuation point, in the fund currency. | 

```csharp
using Lusid.Sdk.Model;
using System;

string seriesIdentifier = "seriesIdentifier";decimal units = "units";
decimal nav = "nav";
decimal navPerUnit = "navPerUnit";
decimal capitalRatio = "capitalRatio";
decimal pnl = "pnl";
decimal previousNav = "previousNav";


SeriesBreakdown seriesBreakdownInstance = new SeriesBreakdown(
    seriesIdentifier: seriesIdentifier,
    units: units,
    nav: nav,
    navPerUnit: navPerUnit,
    capitalRatio: capitalRatio,
    pnl: pnl,
    previousNav: previousNav);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
