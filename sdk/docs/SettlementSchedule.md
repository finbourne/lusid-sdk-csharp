# Lusid.Sdk.Model.SettlementSchedule

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TradeId** | **string** |  | [optional] 
**SettlementDate** | **DateTimeOffset** |  | [optional] 
**Units** | **decimal** |  | [optional] 
**BondInterest** | **decimal** |  | [optional] 
**MovementName** | **string** |  | [optional] 
**MovementType** | **string** |  | [optional] 
**UnsettledUnits** | **decimal** |  | [optional] 
**OverdueUnits** | **decimal** |  | [optional] 

```csharp
using Lusid.Sdk.Model;
using System;

string tradeId = "example tradeId";decimal? units = "example units";decimal? bondInterest = "example bondInterest";
string movementName = "example movementName";
string movementType = "example movementType";decimal? unsettledUnits = "example unsettledUnits";decimal? overdueUnits = "example overdueUnits";

SettlementSchedule settlementScheduleInstance = new SettlementSchedule(
    tradeId: tradeId,
    settlementDate: settlementDate,
    units: units,
    bondInterest: bondInterest,
    movementName: movementName,
    movementType: movementType,
    unsettledUnits: unsettledUnits,
    overdueUnits: overdueUnits);
```

[Back to Model list](../README.md#documentation-for-models) &#8226; [Back to API list](../README.md#documentation-for-api-endpoints) &#8226; [Back to README](../README.md)
