# Lusid.Sdk.Model.CollateralInstrument
Wrapper for one instrument in a larger collateral basket, as part of a repurchase agreement modelled as a FlexibleRepo.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Units** | **decimal** | The amount of the instrument in the basket for this repurchase agreement. | 
**Instrument** | [**MasteredInstrument**](MasteredInstrument.md) |  | 
**CollateralStartDate** | **DateTimeOffset?** | The date from which the instrument is held as collateral for this repurchase agreement.  Read only: an instrument upsert cannot set or change it. An existing value must be sent back unchanged.  When not set, the instrument is held from the StartDate of the FlexibleRepo. | [optional] 
**CollateralEndDate** | **DateTimeOffset?** | The date on which the instrument stops being held as collateral for this repurchase agreement.  Read only: an instrument upsert cannot set or change it. An existing value must be sent back unchanged.  When not set, the instrument is held until the MaturityDate of the FlexibleRepo. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal units = "units";

MasteredInstrument instrument = new MasteredInstrument();

CollateralInstrument collateralInstrumentInstance = new CollateralInstrument(
    units: units,
    instrument: instrument,
    collateralStartDate: collateralStartDate,
    collateralEndDate: collateralEndDate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
