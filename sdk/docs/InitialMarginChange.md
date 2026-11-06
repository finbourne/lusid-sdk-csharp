# Lusid.Sdk.Model.InitialMarginChange

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**WePostBefore** | **decimal** | What we must post to the set today, after the threshold. | 
**WePostAfter** | **decimal** | What we would post to the set after the move, after the threshold. | 
**TheyPostBefore** | **decimal?** | What the counterparty must post today. Null where the run does not know it, as under SIMM without their sensitivities. | [optional] 
**TheyPostAfter** | **decimal?** | What the counterparty would post after the move. Null where the run does not know it. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;
decimal wePostBefore = "wePostBefore";
decimal wePostAfter = "wePostAfter";


InitialMarginChange initialMarginChangeInstance = new InitialMarginChange(
    wePostBefore: wePostBefore,
    wePostAfter: wePostAfter,
    theyPostBefore: theyPostBefore,
    theyPostAfter: theyPostAfter);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
