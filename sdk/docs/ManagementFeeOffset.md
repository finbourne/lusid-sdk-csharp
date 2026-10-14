# Lusid.Sdk.Model.ManagementFeeOffset
A fee income the manager has earned elsewhere that offsets the management fee.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceRef** | **string** | A reference to the fee income being offset. | 
**Amount** | **decimal** | The amount of fee income received. | 
**OffsetPercentage** | **decimal** | The fraction of the fee income that offsets the management fee, between 0 and 1. | 
**Deal** | **string** | For a deal-linked offset, the deal the fee income relates to. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string sourceRef = "sourceRef";decimal amount = "amount";
decimal offsetPercentage = "offsetPercentage";

string deal = "example deal";

ManagementFeeOffset managementFeeOffsetInstance = new ManagementFeeOffset(
    sourceRef: sourceRef,
    amount: amount,
    offsetPercentage: offsetPercentage,
    deal: deal);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
