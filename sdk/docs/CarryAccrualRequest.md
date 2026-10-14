# Lusid.Sdk.Model.CarryAccrualRequest
The request to accrue carried interest on a partnership fund from amounts a waterfall has produced.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**PeriodEnd** | **DateTimeOffset** | The date carry is accrued to. | 
**Source** | **string** | The waterfall or model the carry amounts came from. | 
**Amounts** | [**List&lt;CarryAccrualAmount&gt;**](CarryAccrualAmount.md) | The carry each partner has earned to the period end, as the source states it. | 
**Book** | **bool** | When true, the accrual deltas are booked. | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string source = "source";
List<CarryAccrualAmount> amounts = new List<CarryAccrualAmount>();
bool book = //"True";

CarryAccrualRequest carryAccrualRequestInstance = new CarryAccrualRequest(
    periodEnd: periodEnd,
    source: source,
    amounts: amounts,
    book: book);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
