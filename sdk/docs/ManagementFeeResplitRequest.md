# Lusid.Sdk.Model.ManagementFeeResplitRequest
The request to re-split a partnership fund's prepaid management fee periods between the fee payable and the  receivable from the manager.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PeriodStart** | **DateTimeOffset?** | The start of the window to re-split, exclusive: every prepaid period whose window meets it is re-split. Defaults to the fund&#39;s earliest prepaid period. | [optional] 
**PeriodEnd** | **DateTimeOffset?** | The end of the window to re-split, inclusive. Defaults to the latest prepaid period. | [optional] 
**DryRun** | **bool** | When true, nothing is written and the response says which prepaid periods&#39; splits are out of date. Defaults to false. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

bool dryRun = //"True";

ManagementFeeResplitRequest managementFeeResplitRequestInstance = new ManagementFeeResplitRequest(
    periodStart: periodStart,
    periodEnd: periodEnd,
    dryRun: dryRun);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
