# Lusid.Sdk.Model.HoldingPropertyDelta

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**HoldingPropertyKey** | **string** | The running balance on the holding to adjust. Allowed values: &#39;CommittedCapital&#39;, &#39;FundedCapital&#39;, &#39;UnfundedCapital&#39;, &#39;RecallableCapital&#39; and &#39;NonRecallableCapital&#39;. Available values: CommittedCapital, FundedCapital, UnfundedCapital, RecallableCapital, NonRecallableCapital. | 
**Source** | **string** | The movement value that sources the adjustment. Allowed values: &#39;Amount&#39; (the movement&#39;s signed amount in transaction currency), &#39;Units&#39; (the movement&#39;s signed units) and &#39;PortfolioAmount&#39; (the movement&#39;s signed amount converted to portfolio currency). Available values: Amount, Units, PortfolioAmount. | 
**Direction** | **string** | Whether the sourced value increases or decreases the balance. Allowed values: &#39;Increase&#39; and &#39;Decrease&#39;. Available values: Increase, Decrease. | 

```csharp
using Lusid.Sdk.Model;
using System;

string holdingPropertyKey = "holdingPropertyKey";
string source = "source";
string direction = "direction";

HoldingPropertyDelta holdingPropertyDeltaInstance = new HoldingPropertyDelta(
    holdingPropertyKey: holdingPropertyKey,
    source: source,
    direction: direction);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
