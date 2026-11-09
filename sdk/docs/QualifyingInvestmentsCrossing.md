# Lusid.Sdk.Model.QualifyingInvestmentsCrossing
A flip of the qualifying-investments result between two consecutive observed days.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**From** | **DateTimeOffset** | The date of the observation before the flip. | 
**To** | **DateTimeOffset** | The date of the observation after the flip. | 
**WasBondFundBefore** | **bool** | Whether the scheme was a bond fund on the From date. | 
**IsBondFundAfter** | **bool** | Whether the scheme was a bond fund on the To date. | 

```csharp
using Lusid.Sdk.Model;
using System;

bool wasBondFundBefore = //"True";
bool isBondFundAfter = //"True";

QualifyingInvestmentsCrossing qualifyingInvestmentsCrossingInstance = new QualifyingInvestmentsCrossing(
    from: from,
    to: to,
    wasBondFundBefore: wasBondFundBefore,
    isBondFundAfter: isBondFundAfter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
