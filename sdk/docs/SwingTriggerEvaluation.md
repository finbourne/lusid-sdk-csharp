# Lusid.Sdk.Model.SwingTriggerEvaluation
How a Market swing trigger was evaluated at a valuation point.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Fired** | **bool** | Whether the net cashflow was in the trigger&#39;s direction and above its threshold. | 
**Threshold** | **decimal** | The trigger&#39;s threshold. | 
**Metric** | **string** | What the threshold measured: NetCashflowAbsolute or NetCashflowPctOfNav. | 

```csharp
using Lusid.Sdk.Model;
using System;

bool fired = //"True";decimal threshold = "threshold";

string metric = "metric";

SwingTriggerEvaluation swingTriggerEvaluationInstance = new SwingTriggerEvaluation(
    fired: fired,
    threshold: threshold,
    metric: metric);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
