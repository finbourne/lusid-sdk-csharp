# Lusid.Sdk.Model.ManagementFeeRequest
The request to calculate a period's management fee for the partners of a partnership fund.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PeriodStart** | **DateTimeOffset** | The start of the fee period, exclusive. | 
**PeriodEnd** | **DateTimeOffset** | The end of the fee period, inclusive. | 
**Basis** | **string** | The capital base the fee is charged on. Available values: Auto, CommittedCapital, InvestedCapital. Auto charges on committed capital until the investment period ends and on invested capital after. | [optional] 
**Offsets** | [**List&lt;ManagementFeeOffset&gt;**](ManagementFeeOffset.md) | Fee income received by the manager that offsets the management fee. | [optional] 
**Book** | **bool** | When true, the net fee per partner is booked. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string basis = "example basis";
List<ManagementFeeOffset> offsets = new List<ManagementFeeOffset>();
bool book = //"True";

ManagementFeeRequest managementFeeRequestInstance = new ManagementFeeRequest(
    periodStart: periodStart,
    periodEnd: periodEnd,
    basis: basis,
    offsets: offsets,
    book: book);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
