# Lusid.Sdk.Model.QualifyingInvestmentsObservation
The qualifying-investments test result for one scheme on one day.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Date** | **DateTimeOffset** | The date the test was evaluated for. | 
**NonEquityPercent** | **decimal** | The percentage of the scheme&#39;s assets that were qualifying (non-equity) investments on the date. | 
**IsBondFund** | **bool** | Whether more than the threshold percentage of the scheme&#39;s assets were qualifying investments on the date, making it a bond fund. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal nonEquityPercent = "nonEquityPercent";

bool isBondFund = //"True";

QualifyingInvestmentsObservation qualifyingInvestmentsObservationInstance = new QualifyingInvestmentsObservation(
    date: date,
    nonEquityPercent: nonEquityPercent,
    isBondFund: isBondFund);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
