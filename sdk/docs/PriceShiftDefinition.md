# Lusid.Sdk.Model.PriceShiftDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ScenarioShiftType** | **string** | Available values: RateCurveShiftDefinition, FxShiftDefinition, PriceShiftDefinition, VolSurfaceShiftDefinition, MdkrGroupShiftDefinition, InflationCurveShiftDefinition, CreditSpreadShiftDefinition, ModelOptionShiftDefinition. | 
**Instrument** | **string** | A single instrument identifier this shift applies to. Exactly one of Instrument and Filter  must be supplied. | [optional] 
**Filter** | **string** | A LUSID filter expression over the instrument entity - fields and properties - selecting which  instruments&#39; quotes the shift applies to, e.g.  \&quot;assetClass eq &#39;Bond&#39; and properties[Instrument/Issuer/Name] eq &#39;X&#39;\&quot;.  Exactly one of Instrument and Filter must be supplied. | [optional] 
**Amount** | **decimal?** |  | [optional] 
**ShiftType** | **string** | Available values: Absolute, Relative, Percentage. | 
**QuoteType** | **string** | Available values: Price, Spread, Rate, LogNormalVol, NormalVol, ParSpread, IsdaSpread, Upfront, Index, Ratio, Delta, PoolFactor, InflationAssumption, DirtyPrice, PrincipalWriteOff, InterestDeferred, InterestShortfall, ConstituentWeightFactor. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrument = "example instrument";
string filter = "example filter";
string shiftType = "shiftType";
string quoteType = "example quoteType";

PriceShiftDefinition priceShiftDefinitionInstance = new PriceShiftDefinition(
    instrument: instrument,
    filter: filter,
    amount: amount,
    shiftType: shiftType,
    quoteType: quoteType);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
