# Lusid.Sdk.Model.FeeDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FeeCode** | **string** |  | 
**Basis** | **string** | Available values: CommittedCapital, InvestedCapital, NetInvestedCapital, Nav. | 
**Rate** | **decimal?** |  | [optional] 
**Tiers** | [**List&lt;FeeSizeTier&gt;**](FeeSizeTier.md) |  | [optional] 
**DayCountConvention** | **string** |  | [optional] 
**StepDown** | [**FeeStepDown**](FeeStepDown.md) |  | [optional] 
**OffsetPercentage** | **decimal?** |  | [optional] 
**WaiverPercentage** | **decimal?** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string feeCode = "feeCode";
string basis = "basis";
List<FeeSizeTier> tiers = new List<FeeSizeTier>();
string dayCountConvention = "example dayCountConvention";
FeeStepDown? stepDown = new FeeStepDown();


FeeDefinition feeDefinitionInstance = new FeeDefinition(
    feeCode: feeCode,
    basis: basis,
    rate: rate,
    tiers: tiers,
    dayCountConvention: dayCountConvention,
    stepDown: stepDown,
    offsetPercentage: offsetPercentage,
    waiverPercentage: waiverPercentage);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
