# Lusid.Sdk.Model.CashLadderRecord

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**EffectiveDate** | **DateTimeOffset** |  | [optional] 
**Open** | **decimal** |  | 
**Activities** | **Dictionary&lt;string, decimal&gt;** |  | 
**Close** | **decimal** |  | 

```csharp
using Lusid.Sdk.Model;
using System;
decimal open = "open";

Dictionary<string, decimal> activities = new Dictionary<string, decimal>();decimal close = "close";


CashLadderRecord cashLadderRecordInstance = new CashLadderRecord(
    effectiveDate: effectiveDate,
    open: open,
    activities: activities,
    close: close);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
