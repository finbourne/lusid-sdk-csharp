# Lusid.Sdk.Model.ManagementFeeResplitResult
What a re-split of a partnership fund's prepaid management fee periods found and wrote.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | 
**Periods** | [**List&lt;ManagementFeePrepaidSplit&gt;**](ManagementFeePrepaidSplit.md) | Every partner line&#39;s prepaid period the re-split read, in date order. | 
**WrittenTransactionIds** | **List&lt;string&gt;** | The fee transactions the re-split wrote in the fund&#39;s own books, new or replaced. Empty on a dry run, and when no split changed. | 
**CancelledTransactionIds** | **List&lt;string&gt;** | The fee transactions the re-split cancelled in the fund&#39;s own books. Empty on a dry run, and when no split changed. | 
**Warnings** | **List&lt;string&gt;** | What the re-split noticed but did not refuse, each starting with its code: on a dry run each out of date split (FeePrepaidSplitStale), and a payment to the manager in a currency other than the fee&#39;s (FeePaymentCurrencyIgnored). Absent when there is nothing to warn of. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId fundId = new ResourceId();
List<ManagementFeePrepaidSplit> periods = new List<ManagementFeePrepaidSplit>();
List<string> writtenTransactionIds = new List<string>();
List<string> cancelledTransactionIds = new List<string>();
List<string> warnings = new List<string>();

ManagementFeeResplitResult managementFeeResplitResultInstance = new ManagementFeeResplitResult(
    fundId: fundId,
    periods: periods,
    writtenTransactionIds: writtenTransactionIds,
    cancelledTransactionIds: cancelledTransactionIds,
    warnings: warnings);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
