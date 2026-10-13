# Lusid.Sdk.Model.FeeStepDown

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Trigger** | **string** | Available values: EndOfInvestmentPeriod, Date, Closing. | 
**StepDownDate** | **DateTimeOffset?** |  | [optional] 
**ClosingId** | **string** |  | [optional] 
**Rate** | **decimal?** |  | [optional] 
**Basis** | **string** | Available values: CommittedCapital, InvestedCapital, NetInvestedCapital, Nav. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string trigger = "trigger";
string closingId = "example closingId";
string basis = "example basis";

FeeStepDown feeStepDownInstance = new FeeStepDown(
    trigger: trigger,
    stepDownDate: stepDownDate,
    closingId: closingId,
    rate: rate,
    basis: basis);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
