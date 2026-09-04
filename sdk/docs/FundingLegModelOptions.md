# Lusid.Sdk.Model.FundingLegModelOptions

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelOptionsType** | **string** | Available values: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, CdsModelOptions, FlexibleLoanPricerOptions, HullWhiteModelOptions, BondLookupModelOptions, BondForwardModelOptions. | 
**ExpectedFundingLegNotional** | **string** | Assumption made on future expected notional of the funding leg. | 

```csharp
using Lusid.Sdk.Model;
using System;

string expectedFundingLegNotional = "expectedFundingLegNotional";

FundingLegModelOptions fundingLegModelOptionsInstance = new FundingLegModelOptions(
    expectedFundingLegNotional: expectedFundingLegNotional);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
