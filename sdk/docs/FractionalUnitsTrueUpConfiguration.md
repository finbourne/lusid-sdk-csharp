# Lusid.Sdk.Model.FractionalUnitsTrueUpConfiguration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FractionalUnitsHandling** | **string** | The fractional-units handling scheme for the portfolio&#39;s corporate-action processing. This can be: LotLevelRounding or CustodianLevelTrueUp. Defaults to LotLevelRounding, today&#39;s per-lot-only processing, if not specified. Available values: LotLevelRounding, CustodianLevelTrueUp. | [optional] 
**NominatedSubHoldingKey** | **string** | The sub-holding key (from the &#39;Transaction&#39; domain) that custodian-level fractional-units true-ups are booked to. The key must be one of the portfolio&#39;s sub-holding keys, must have a pre-defined property definition, and event processing never creates it. | [optional] 
**NominatedSubHoldingKeyValue** | **string** | The value of the nominated sub-holding key under which the true-up holding is booked, for example the bucket that quarantines fractional rounding true-ups. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string fractionalUnitsHandling = "example fractionalUnitsHandling";
string nominatedSubHoldingKey = "example nominatedSubHoldingKey";
string nominatedSubHoldingKeyValue = "example nominatedSubHoldingKeyValue";

FractionalUnitsTrueUpConfiguration fractionalUnitsTrueUpConfigurationInstance = new FractionalUnitsTrueUpConfiguration(
    fractionalUnitsHandling: fractionalUnitsHandling,
    nominatedSubHoldingKey: nominatedSubHoldingKey,
    nominatedSubHoldingKeyValue: nominatedSubHoldingKeyValue);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
