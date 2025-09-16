# Lusid.Sdk.Model.CashFlowLineage
Lineage for cash flow value

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**InstrumentType** | **string** | The instrument type of the instrument to which the cash flow belongs to. When upserting CashFlowValues, this  should be null. | [optional] 
**CashFlowType** | **string** | The cashflow type.When upserting CashFlowValues, this should be null, or one of [Unknown, Coupon, Notional,  Premium, Principal, Protection, Cash] | [optional] 
**InstrumentId** | **string** | The LUID of the instrument to which the cash flow belongs to. When upserting this should be null. | [optional] 
**LegId** | **string** | The leg id to which the cash flow belongs to. | [optional] 
**SourceTransactionId** | **string** | The source transaction of the instrument to which the cash flow belongs to. When upserting this should be null | [optional] 
**PayReceive** | **string** | Does the cash flow belong to the Pay or Receive leg. When upserting this should either be null or one of [Pay, Receive, NotApplicable] | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string instrumentType = "example instrumentType";
string cashFlowType = "example cashFlowType";
string instrumentId = "example instrumentId";
string legId = "example legId";
string sourceTransactionId = "example sourceTransactionId";
string payReceive = "example payReceive";

CashFlowLineage cashFlowLineageInstance = new CashFlowLineage(
    instrumentType: instrumentType,
    cashFlowType: cashFlowType,
    instrumentId: instrumentId,
    legId: legId,
    sourceTransactionId: sourceTransactionId,
    payReceive: payReceive);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
