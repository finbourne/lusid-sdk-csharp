# Lusid.Sdk.Model.ShareClassPnlBreakdown
The breakdown of PnL for a Share Class on a specified date.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ApportionedNonClassSpecificPnl** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Bucket of detail for PnL within the queried period not explicitly allocated to any share class but has been apportioned to the share class. | 
**ClassPnl** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Bucket of detail for PnL specific to the share class within the queried period. | 
**GroupApportionedPnl** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Bucket of detail for the share class&#39;s apportioned share of PnL allocated to the allocation groups it belongs to, within the queried period. | 
**TotalPnl** | [**Dictionary&lt;string, ShareClassAmount&gt;**](ShareClassAmount.md) | Bucket of detail for the total PnL within the queried period: the sum of the class-specific, apportioned non-class-specific and allocation-group-apportioned PnL. | 

```csharp
using Lusid.Sdk.Model;
using System;

Dictionary<string, ShareClassAmount> apportionedNonClassSpecificPnl = new Dictionary<string, ShareClassAmount>();
Dictionary<string, ShareClassAmount> classPnl = new Dictionary<string, ShareClassAmount>();
Dictionary<string, ShareClassAmount> groupApportionedPnl = new Dictionary<string, ShareClassAmount>();
Dictionary<string, ShareClassAmount> totalPnl = new Dictionary<string, ShareClassAmount>();

ShareClassPnlBreakdown shareClassPnlBreakdownInstance = new ShareClassPnlBreakdown(
    apportionedNonClassSpecificPnl: apportionedNonClassSpecificPnl,
    classPnl: classPnl,
    groupApportionedPnl: groupApportionedPnl,
    totalPnl: totalPnl);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
