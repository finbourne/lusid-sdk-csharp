# Lusid.Sdk.Model.SwingTrigger
When a Market swing fires in one direction: the net cashflow measure and the size it must exceed.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | What the threshold measures: NetCashflowAbsolute, the size of the net cashflow in the fund currency, or NetCashflowPctOfNav, the net cashflow as a percentage of the previous valuation point&#39;s NAV. A NetCashflowPctOfNav trigger does not fire when there is no previous NAV. Available values: NetCashflowAbsolute, NetCashflowPctOfNav. | 
**Threshold** | **decimal** | The size of net cashflow, as a magnitude, the flow must be above for the trigger to fire. Above zero. | 

```csharp
using Lusid.Sdk.Model;
using System;

string type = "type";decimal threshold = "threshold";


SwingTrigger swingTriggerInstance = new SwingTrigger(
    type: type,
    threshold: threshold);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
