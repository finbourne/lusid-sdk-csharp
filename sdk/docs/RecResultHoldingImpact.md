# Lusid.Sdk.Model.RecResultHoldingImpact
One holding, and where known the tax lot within it, that a transaction or settlement activity item impacted.  Also holds the display names of the holding's instrument.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HoldingId** | **string** | The impacted holding, at holding level: the id a holding item over it carries. | 
**TaxLotId** | **string** | The impacted tax lot within the holding, where the source states one; null when the impact is known at holding level only. Opaque: compare it whole, do not parse it. | [optional] 
**HoldingInstrumentScope** | **string** | The scope of the impacted holding&#39;s instrument. Null where the source does not state one. | [optional] 
**HoldingLusidInstrumentId** | **string** | The LUID of the impacted holding&#39;s instrument. Null where the source does not state it. | [optional] 
**HoldingInstrumentName** | **string** | The name of the impacted holding&#39;s instrument, as it stood at the asAt the run read its data. Null where the run did not resolve it. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string holdingId = "holdingId";
string taxLotId = "example taxLotId";
string holdingInstrumentScope = "example holdingInstrumentScope";
string holdingLusidInstrumentId = "example holdingLusidInstrumentId";
string holdingInstrumentName = "example holdingInstrumentName";

RecResultHoldingImpact recResultHoldingImpactInstance = new RecResultHoldingImpact(
    holdingId: holdingId,
    taxLotId: taxLotId,
    holdingInstrumentScope: holdingInstrumentScope,
    holdingLusidInstrumentId: holdingLusidInstrumentId,
    holdingInstrumentName: holdingInstrumentName);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
