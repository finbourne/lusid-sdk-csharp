# Lusid.Sdk.Model.BondForwardModelOptions
Model options for bond forward pricing.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ModelOptionsType** | **string** | Available values: Invalid, OpaqueModelOptions, EmptyModelOptions, IndexModelOptions, FxForwardModelOptions, FundingLegModelOptions, EquityModelOptions, CdsModelOptions, FlexibleLoanPricerOptions, HullWhiteModelOptions, BondLookupModelOptions, BondForwardModelOptions. | 
**BondForwardProjectionType** | **string** | Determines how the forward price of the deliverable bond is projected to the settlement date.                Supported string (enumeration) values are: [QuotedContractPrice, ForwardProjectedFromFundingCurve].  Defaults to QuotedContractPrice - the original quote-driven behaviour - when not supplied, so  options persisted before this property existed keep the behaviour they were saved under. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string bondForwardProjectionType = "example bondForwardProjectionType";

BondForwardModelOptions bondForwardModelOptionsInstance = new BondForwardModelOptions(
    bondForwardProjectionType: bondForwardProjectionType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
