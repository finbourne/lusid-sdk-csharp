# Lusid.Sdk.Model.MarginSettlementLag
Business days between a margin call and settlement, by asset kind.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Cash** | **int** | The business days between a cash margin call and settlement. | 
**Securities** | **int** | The business days between a securities margin call and settlement. | 

```csharp
using Lusid.Sdk.Model;
using System;


MarginSettlementLag marginSettlementLagInstance = new MarginSettlementLag(
    cash: cash,
    securities: securities);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
