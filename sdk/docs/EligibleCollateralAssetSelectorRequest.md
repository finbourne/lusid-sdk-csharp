# Lusid.Sdk.Model.EligibleCollateralAssetSelectorRequest
The assets an eligible collateral row applies to, as supplied when a schedule is created or upserted.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Kind** | **string** | What the selector matches. One of BaseCurrencyCash, Cash or Instrument. Available values: BaseCurrencyCash, Cash, Instrument. | 
**Currency** | **string** | The currency of the cash. Required for a Cash selector and not allowed otherwise. | [optional] 
**InstrumentFilter** | **string** | A filter selecting the instruments. Required for an Instrument selector and not allowed otherwise. Checked for structure only when the schedule is stored. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string kind = "kind";
string currency = "example currency";
string instrumentFilter = "example instrumentFilter";

EligibleCollateralAssetSelectorRequest eligibleCollateralAssetSelectorRequestInstance = new EligibleCollateralAssetSelectorRequest(
    kind: kind,
    currency: currency,
    instrumentFilter: instrumentFilter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
