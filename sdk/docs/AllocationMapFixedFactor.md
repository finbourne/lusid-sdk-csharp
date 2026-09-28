# Lusid.Sdk.Model.AllocationMapFixedFactor
The weight of one investor record under a FixedPercentage basis.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InvestorRecordId** | **string** | The investor record the factor belongs to. | 
**Factor** | **decimal** | The weight of the investor record. Weights are normalised over the participants that receive the remainder, so they need not sum to 1. | 

```csharp
using Lusid.Sdk.Model;
using System;

string investorRecordId = "investorRecordId";decimal factor = "factor";


AllocationMapFixedFactor allocationMapFixedFactorInstance = new AllocationMapFixedFactor(
    investorRecordId: investorRecordId,
    factor: factor);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
