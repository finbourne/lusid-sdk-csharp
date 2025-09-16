# Lusid.Sdk.Model.CollateralInstrument
Wrapper for one instrument in a larger collateral basket, as part of a repurchase agreement modelled as a FlexibleRepo.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Units** | **decimal** | The amount of the instrument in the basket for this repurchase agreement. | 
**Instrument** | [**MasteredInstrument**](MasteredInstrument.md) |  | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal units = "units";

MasteredInstrument instrument = new MasteredInstrument();

CollateralInstrument collateralInstrumentInstance = new CollateralInstrument(
    units: units,
    instrument: instrument);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
