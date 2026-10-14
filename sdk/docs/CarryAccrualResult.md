# Lusid.Sdk.Model.CarryAccrualResult
The outcome of a carry accrual: the movement in each partner's carry against what was last accrued.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FundId** | [**ResourceId**](ResourceId.md) |  | 
**PeriodEnd** | **DateTimeOffset** | The date carry is accrued to. | 
**Source** | **string** | The waterfall or model the carry amounts came from. | 
**Lines** | [**List&lt;CarryAccrualLine&gt;**](CarryAccrualLine.md) | The accrual movement per partner. | 
**BookedTransactionIds** | **List&lt;string&gt;** | The identifiers of the transactions booked, if any. | 

```csharp
using Lusid.Sdk.Model;
using System;

ResourceId fundId = new ResourceId();
string source = "source";
List<CarryAccrualLine> lines = new List<CarryAccrualLine>();
List<string> bookedTransactionIds = new List<string>();

CarryAccrualResult carryAccrualResultInstance = new CarryAccrualResult(
    fundId: fundId,
    periodEnd: periodEnd,
    source: source,
    lines: lines,
    bookedTransactionIds: bookedTransactionIds);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
