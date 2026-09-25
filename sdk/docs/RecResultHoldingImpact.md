# Lusid.Sdk.Model.RecResultHoldingImpact
One holding, and where known the tax lot within it, that a transaction or settlement activity item impacted.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HoldingId** | **string** | The impacted holding, at holding level: the id a holding item over it carries. | 
**TaxLotId** | **string** | The impacted tax lot within the holding, where the source states one; null when the impact is known at holding level only. Opaque: compare it whole, do not parse it. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string holdingId = "holdingId";
string taxLotId = "example taxLotId";

RecResultHoldingImpact recResultHoldingImpactInstance = new RecResultHoldingImpact(
    holdingId: holdingId,
    taxLotId: taxLotId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
