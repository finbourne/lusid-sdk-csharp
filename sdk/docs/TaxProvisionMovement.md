# Lusid.Sdk.Model.TaxProvisionMovement
The movement in a fund's deferred tax provision between the previous valuation point and this one,  split into the realised gains crystallised in the period, the change in the unrealised position,  the effect of a change in the applied rate and the offset from losses brought forward.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Realised** | **decimal** | The part of the movement that is due to gains realised in the period. | 
**UnrealisedChange** | **decimal** | The part of the movement that is due to the change in the unrealised position. | 
**RateChange** | **decimal** | The part of the movement that is due to a change in the applied rate. | 
**LossOffset** | **decimal** | The part of the movement that is due to losses brought forward being offset against gains. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal realised = "realised";
decimal unrealisedChange = "unrealisedChange";
decimal rateChange = "rateChange";
decimal lossOffset = "lossOffset";


TaxProvisionMovement taxProvisionMovementInstance = new TaxProvisionMovement(
    realised: realised,
    unrealisedChange: unrealisedChange,
    rateChange: rateChange,
    lossOffset: lossOffset);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
