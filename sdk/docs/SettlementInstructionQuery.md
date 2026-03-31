# Lusid.Sdk.Model.SettlementInstructionQuery

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAt** | **DateTimeOffset?** |  | [optional] 
**StartDate** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) |  | [optional] 
**EndDate** | [**DateTimeOrCutLabel**](DateTimeOrCutLabel.md) |  | [optional] 
**Limit** | **int?** |  | [optional] 
**Page** | **string** |  | [optional] 
**Filter** | **string** |  | [optional] 
**SettlementInstructionPropertyKeys** | **List&lt;string&gt;** |  | [optional] 
**TransactionPropertyKeys** | **List&lt;string&gt;** |  | [optional] 
**TimelineScope** | **string** |  | [optional] 
**TimelineCode** | **string** |  | [optional] 
**ClosedPeriodId** | **string** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

DateTimeOrCutLabel startDate = "example startDate";
DateTimeOrCutLabel endDate = "example endDate";
string page = "example page";
string filter = "example filter";
List<string> settlementInstructionPropertyKeys = new List<string>();
List<string> transactionPropertyKeys = new List<string>();
string timelineScope = "example timelineScope";
string timelineCode = "example timelineCode";
string closedPeriodId = "example closedPeriodId";

SettlementInstructionQuery settlementInstructionQueryInstance = new SettlementInstructionQuery(
    asAt: asAt,
    startDate: startDate,
    endDate: endDate,
    limit: limit,
    page: page,
    filter: filter,
    settlementInstructionPropertyKeys: settlementInstructionPropertyKeys,
    transactionPropertyKeys: transactionPropertyKeys,
    timelineScope: timelineScope,
    timelineCode: timelineCode,
    closedPeriodId: closedPeriodId);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
