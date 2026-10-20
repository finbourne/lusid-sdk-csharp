# Lusid.Sdk.Model.WithholdingTaxRateSplit

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**StopAtSourceRate** | **decimal** | The rate withheld at source. | 
**IrrecoverableRate** | **decimal** | The part of the country rate that cannot be recovered. | 
**ReliefAtSourceRate** | **decimal** | The part of the country rate relieved at source. | 
**ReclaimableRate** | **decimal** | The part of the rate withheld at source that can be reclaimed. | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal stopAtSourceRate = "stopAtSourceRate";
decimal irrecoverableRate = "irrecoverableRate";
decimal reliefAtSourceRate = "reliefAtSourceRate";
decimal reclaimableRate = "reclaimableRate";


WithholdingTaxRateSplit withholdingTaxRateSplitInstance = new WithholdingTaxRateSplit(
    stopAtSourceRate: stopAtSourceRate,
    irrecoverableRate: irrecoverableRate,
    reliefAtSourceRate: reliefAtSourceRate,
    reclaimableRate: reclaimableRate);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
